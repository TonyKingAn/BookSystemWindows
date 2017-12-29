using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemWindows
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            // Application.Run(new LoginForm());
            Application.Run(new MainForm());
            //Application.Run(new CreateBookDialog());

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
          
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            else
            {
                MessageBox.Show("系统出现异常：" + (ex.Message + " " + (ex.InnerException != null && ex.InnerException.Message != null && ex.Message != ex.InnerException.Message ? ex.InnerException.Message : "")));
                return;
            }
        }
    }
}
