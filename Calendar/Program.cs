using System;
using System.Windows.Forms;

namespace Calendar
{
    public static class Program
    {
        public static DateTime now
        {
            get;
            private set;
        }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            now = DateTime.Now;
            Application.Run(new MainForm());
        }
    }
}