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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SWE_Project
{
    public partial class Form4 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string ordb = Program.ordb;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.form1.Hide();
                    Program.form2.Hide();
                    Program.form3.Show();
                    Program.form4.Hide();
                }
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {

            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
            Apply.Visible = false;
            string cmdstr = "Select * from EMPLOYEES_PROJECT";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Save is done");
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            string cmdstr = "Select ROOM_ID, ROOM_TYPE from ROOMS_PROJECT ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            checkedListBox1.Visible = true;
            checkedListBox2.Visible = true;
            Apply.Visible = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
            Apply.Visible = false;
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            List<string> state = new List<string>();
            List<string> type = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
                type.Add(item.ToString());
            foreach (var item in checkedListBox2.CheckedItems)
                state.Add(item.ToString());

            string cmdstr = "SELECT ROOM_ID, ROOM_TYPE FROM ROOMS_PROJECT ";

            if (state.Count > 0 || type.Count > 0)
            {
                cmdstr += "WHERE ";

                if (state.Count > 0)
                {
                    cmdstr += "Room_state IN (";
                    for (int i = 0; i < state.Count; i++)
                    {
                        cmdstr += $":state{i}";
                        if (i < state.Count - 1)
                            cmdstr += ",";
                    }
                    cmdstr += ") ";
                }

                if (state.Count > 0 && type.Count > 0)
                    cmdstr += "AND ";

                if (type.Count > 0)
                {
                    cmdstr += "Room_Type IN (";
                    for (int i = 0; i < type.Count; i++)
                    {
                        cmdstr += $":type{i}";
                        if (i < type.Count - 1)
                            cmdstr += ",";
                    }
                    cmdstr += ")";
                }
            }

            adapter = new OracleDataAdapter(cmdstr, ordb);

            for (int i = 0; i < state.Count; i++)
                adapter.SelectCommand.Parameters.Add($":state{i}", state[i]);

            for (int i = 0; i < type.Count; i++)
                adapter.SelectCommand.Parameters.Add($":type{i}", type[i]);

            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
