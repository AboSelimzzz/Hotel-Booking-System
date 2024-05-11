using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    public partial class Form3 : Form
    {
        string ordb = Program.ordb;
        OracleConnection conn;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("PLease make the date format of your pc is dd/MM//yyyy");
            conn = new OracleConnection(ordb);
            conn.Open();
            Password.UseSystemPasswordChar = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    e.Cancel = true;
                else
                    Application.Exit();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (Email.Text == "LOL" && Password.Text == "LOL")
            {
                this.Hide();
                Email.Text = "";
                Password.Text = "";
                Program.form4.Show();
            }
            else
            {
                string q = "Select EMPLOYEE_ID " +
                    "FROM EMPLOYEES_PROJECT " +
                    "WHERE EMAIL = :mail AND Pass = :pass";
                OracleCommand cmd = new OracleCommand(q, conn);
                cmd.Parameters.Add("mail", Email.Text);
                cmd.Parameters.Add("pass", Password.Text);
                OracleDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Program.empid = int.Parse(rd[0].ToString());
                    Program.form1.Show();
                    this.Hide();
                    Password.Text = "";
                    Email.Text = "";
                    Program.form1.notify();
                }
                else
                    MessageBox.Show("There is an error in the data");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
