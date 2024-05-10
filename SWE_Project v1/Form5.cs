using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    public partial class Form5 : Form
    {
        public DataGridView dataGridView2 = new DataGridView();
        string ordb = Program.ordb;
        OracleConnection conn;
        public Form5()
        {
            InitializeComponent();
            dataGridView2.Columns.Add("resid", "resid");
            dataGridView2.Columns.Add("roomnumber", "roomnumber");
            dataGridView2.Columns.Add("roomtype", "roomtype");
            dataGridView2.Columns.Add("employee_name", "employee_name");
            dataGridView2.Columns.Add("cost", "cost");
            dataGridView2.Columns.Add("start_date", "start_date");
            dataGridView2.Columns.Add("end_date", "end_date");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (dataGridView2 != null && dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells.Count >= 7)
            {
                rid.Text = dataGridView2.Rows[0].Cells[0].Value?.ToString() ?? "";
                roomid.Text = dataGridView2.Rows[0].Cells[1].Value?.ToString() ?? "";
                roomtype.Text = dataGridView2.Rows[0].Cells[2].Value?.ToString() ?? "";
                empname.Text = dataGridView2.Rows[0].Cells[3].Value?.ToString() ?? "";
                cost.Text = dataGridView2.Rows[0].Cells[4].Value?.ToString() ?? "";
                Sdate.Text = dataGridView2.Rows[0].Cells[5].Value?.ToString() ?? "";
                Edate.Text = dataGridView2.Rows[0].Cells[6].Value?.ToString() ?? "";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(Sdate.Text) >= DateTime.Now)
            {
                string s = "Delete FROM RESERVATIONS_PROJECT " +
                    "WHERE RESERVATION_ID =: rid";
                OracleCommand cmd = new OracleCommand(s, conn);
                cmd.Parameters.Add("rid", decimal.Parse(rid.Text));
                if (cmd.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("DONE");
                    rid.Text = "";
                    roomid.Text = "";
                    roomtype.Text = "";
                    empname.Text = "";
                    cost.Text = "";
                    Sdate.Text = "";
                    Edate.Text = "";
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("TIME ERROR");
            }
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime time = monthCalendar1.SelectionStart.Date;
            Sdate.Text = time.ToString(time.ToString("dd-MM-yy"));
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime time = monthCalendar2.SelectionStart.Date;
            Edate.Text = time.ToString(time.ToString("dd-MM-yy"));
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string s = "Select c.ROOM_COST " +
                "FROM COSTPERNIGHT_PROJECT c " +
                "where c.ROOM_TYPE = :type";
            OracleCommand cmd = new OracleCommand(s, conn);
            cmd.Parameters.Add("type", roomtype.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                decimal costroom = decimal.Parse(dr[0].ToString());
                int days = int.Parse(TimeSpan.Parse((DateTime.Parse(Edate.Text) - DateTime.Parse(Sdate.Text)).ToString()).TotalDays.ToString());
                if (days <= 0) 
                {
                    MessageBox.Show("Select valid date");
                    return;
                }
                costroom *= days;
                DialogResult result = MessageBox.Show("The reservation cost is: " + costroom.ToString() + "L.E.\nDo you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cost.Text = costroom.ToString();
                    string q1 = "UPDATE RESERVATIONS_PROJECT " +
                                "SET RESERVATION_COST = :cost, EMPLOYEE_ID = :eid, START_DATE = :sdate, END_DATE = :edate " +
                                "WHERE RESERVATION_ID = :id";
                    OracleCommand com = new OracleCommand(q1, conn);
                    com.Parameters.Add("cost", costroom);
                    com.Parameters.Add("eid", Program.empid);
                    com.Parameters.Add("sdate", OracleDbType.Date).Value = DateTime.Parse(Sdate.Text);
                    com.Parameters.Add("edate", OracleDbType.Date).Value = DateTime.Parse(Edate.Text);
                    com.Parameters.Add("id", int.Parse(rid.Text));
                    if (com.ExecuteNonQuery() != -1)
                        MessageBox.Show("Update Done");
                    else
                        MessageBox.Show("Error appeared");
                }
                else
                {
                    Edate.Text = dataGridView2.Rows[0].Cells[6].Value.ToString();
                    Edate.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form1.Update_datagrid();
            Program.form1.Show();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            if (DateTime.Today == DateTime.Parse(Edate.Text.ToString()))
            {
                string q1 = "UPDATE ROOMS_PROJECT " +
                    "SET ROOM_STATE = 'YES'" +
                    "WHERE ROOM_ID = :id";
                OracleCommand com = new OracleCommand(q1, conn);
                com.Parameters.Add("id", int.Parse(roomid.Text));
                if (com.ExecuteNonQuery() != -1)
                    MessageBox.Show("Checkout Done");
                else
                    MessageBox.Show("Error appeared");
            }
            else
            {
                MessageBox.Show("MUST END YOUR RESERVATION TIME FIRST");
            }
            this.Close();
        }
    }
}
