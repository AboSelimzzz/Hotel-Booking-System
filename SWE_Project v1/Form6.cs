using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SWE_Project
{
    public partial class Form6 : Form
    {
        Crystal1 CR;
        CrystalReport2 CR2;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void report1_Click(object sender, EventArgs e)
        {
            CR = new Crystal1();
            crystalReportViewer1.ReportSource = CR;
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form4.Show();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            CR2 = new CrystalReport2();
            CR2.SetParameterValue(0, monthCalendar1.SelectionEnd);
            CR2.SetParameterValue(1, monthCalendar2.SelectionEnd);
            crystalReportViewer1.ReportSource = CR2;
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }
    }
}
