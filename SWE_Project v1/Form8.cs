using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project
{
    public partial class Form8 : Form
    {
        CrystalReport2 CR2;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MonthCalendar m1 = Program.m1; 
            MonthCalendar m2 = Program.m2; 

            CR2 = new CrystalReport2();
            CR2.SetDatabaseLogon("hr", "hr");
            CR2.SetParameterValue(0, m1.SelectionEnd);
            CR2.SetParameterValue(1, m2.SelectionEnd);
            if (CR2.Rows.Count == 0)
            {
                MessageBox.Show("Error: No data available for the selected date range.");
                this.Close();
            }
            else
            {
                crystalReportViewer1.ReportSource = CR2;
            }
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form6.Show();
        }
    }
}
