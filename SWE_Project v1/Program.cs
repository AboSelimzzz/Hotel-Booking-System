using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 =new Form1();
            form2 =new Form2();
            Application.Run(form1);
            
        }
    }
}
