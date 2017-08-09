using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Bar
    {
        Form1 ParentForm;
        public Bar(Form1 parentForm)
        {
            ParentForm = parentForm;
            throw new Exception("BAR!");
        }
    }
}
