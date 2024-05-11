using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using SWE_Project_v1;

namespace SWE_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;
        public static Form4 form4;
        public static Form6 form6;
        public static int empid;
        public static MonthCalendar m1;
        public static MonthCalendar m2;
        public static string ordb = "Data Source = ORCl;user id=hr;Password=hr;";

        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            Application.Run(form3);
        }
    }
}
