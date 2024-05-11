using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    public partial class Form7 : Form
    {
        Crystal1 CR;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            CR = new Crystal1();
            CR.SetDatabaseLogon("hr", "hr");
            if (CR.Rows.Count == 0)
                MessageBox.Show("Error: No data available for the selected date range.");
            else
            {
                crystalReportViewer1.ReportSource = CR;
            }
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form6.Show();
        }
    }
}
