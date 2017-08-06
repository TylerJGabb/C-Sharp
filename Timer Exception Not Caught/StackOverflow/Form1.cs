using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace StackOverflow
{
    public partial class Form1 : Form
    {
        System.Timers.Timer T;
        public Form1()
        {
            InitializeComponent();
            T = new System.Timers.Timer();
            T.Interval = 5000; //Miliseconds;
            T.Elapsed += new ElapsedEventHandler(TimerElapsed);
            T.Start();
        }

        public void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            T.Stop();
            throw new Exception("Exception From Timer Elapsed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("Exception 1");
        }
    }
}
