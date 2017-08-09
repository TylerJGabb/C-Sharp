using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Foo
    {
        Bar B;
        System.Timers.Timer T;
        Form1 ParentForm;
        public Foo(Form1 parentForm)
        {
            ParentForm = parentForm;
            T = new System.Timers.Timer(5000);
            T.SynchronizingObject = parentForm;
            T.Elapsed += new System.Timers.ElapsedEventHandler(Something);
            FooBarEvent += new EventHandler(ThisIsFooBar);
            T.Start();
        }

        public event EventHandler FooBarEvent;
        public virtual void OnFoobar(EventArgs e)
        {
            FooBarEvent?.Invoke(this,e);
        }
        public void ThisIsFooBar(object sender, EventArgs e)
        {
            throw new Exception("From Inside Foo On FooBar");
        }
        public void Something(object sender, EventArgs e)
        {
            OnFoobar(new EventArgs());
        }



        public void ThrowIt(object sender, System.Timers.ElapsedEventArgs e)
        {
            T.Stop();
            throw new Exception("IT HAS BEEN THROWN");
        }
    }
}
