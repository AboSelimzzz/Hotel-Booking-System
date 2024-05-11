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
            Form7 f = new Form7();
            this.Hide();
            f.Show();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form4.Show();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            Program.m1 = monthCalendar1;
            Program.m2 = monthCalendar2;
            Form8 f = new Form8();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
