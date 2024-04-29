using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Form1 form1 ;
        public static Form2 form2 ;
        public static string ordb = "Data Source = ORCl;user id=hr;Password=hr;";

        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //form el login
            form1 =new Form1();
            form2 =new Form2();
            Application.Run(form1);
            
        }
    }
}
