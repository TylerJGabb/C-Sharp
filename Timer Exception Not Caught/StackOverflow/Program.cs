using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StackOverflow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionOccurred);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(UnhandledExceptionOccurred);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void UnhandledExceptionOccurred(object sender, UnhandledExceptionEventArgs e)
        {
            var x = (Exception)e.ExceptionObject;
            MessageBox.Show("Unhandled Exception\r\n" + x.Message);
            
        }

        public static void UnhandledExceptionOccurred(object sender, ThreadExceptionEventArgs e_thread)
        {
            var x = e_thread.Exception;
            MessageBox.Show("Thread Exception\r\n" + x.Message);
        }

        public static void GlobalEventHandler(object sender, EventArgs)
        {

        }

    }
}
