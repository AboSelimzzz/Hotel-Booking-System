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
    public partial class Form2 : Form
    {
        string ordb = Program.ordb;
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            string query = "Select ROOM_TYPE from COSTPERNIGHT_PROJECT";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                typecmb.Items.Add(dr[0]);
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
            Program.form2.Hide();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
                }
            }
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionStart.Date;
            Sdate.Text = selectedDate.ToString(selectedDate.ToString("dd-MM-yy"));
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            Edate.Text = selectedDate.ToString(selectedDate.ToString("dd-MM-yy"));
        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {
            if (Edate.Text == "" || Sdate.Text == "" || typecmb.SelectedItem == null)
            {
                MessageBox.Show("Fill all the data");
                return;
            }
            if(DateTime.Parse(Edate.Text) <= DateTime.Parse(Sdate.Text) || DateTime.Parse(Sdate.Text) < DateTime.Today)
            {
                MessageBox.Show("Select Valid Date");
                return;
            }
            OracleCommand c = new OracleCommand("GetMaxIDRES", conn);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("ID", OracleDbType.Int32, ParameterDirection.Output);
            int newID;
            c.ExecuteNonQuery();
            try
            {
                newID = Convert.ToInt32(c.Parameters["ID"].Value.ToString()) + 1;
            }
            catch
            {
                newID = 1;
            }
            string query = "Select r.ROOM_ID, c.ROOM_COST " +
                "from ROOMS_PROJECT r, COSTPERNIGHT_PROJECT c " +
                "where r.ROOM_TYPE = :type  and r.Room_state = 'YES' and c.ROOM_TYPE = :type";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add("type", typecmb.SelectedItem);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                decimal roomid = Decimal.Parse(dr[0].ToString());
                string roomcost = dr[1].ToString();
                int days = int.Parse(TimeSpan.Parse((DateTime.Parse(Edate.Text) - DateTime.Parse(Sdate.Text)).ToString()).TotalDays.ToString());
                string q1 = "INSERT INTO RESERVATIONS_PROJECT " +
                    "VALUES (:id, :rid, :eid, :cid, :cost, :sdate, :edate)";
                OracleTransaction t = conn.BeginTransaction();
                using (OracleCommand cmd1 = new OracleCommand(q1, conn))
                {
                    cmd1.Parameters.Add("id", OracleDbType.Int32).Value = newID;
                    cmd1.Parameters.Add("rid", OracleDbType.Int32).Value = roomid;
                    cmd1.Parameters.Add("eid", OracleDbType.Int32).Value = Program.empid; // Employee ID
                    cmd1.Parameters.Add("cid", OracleDbType.Int32).Value = Program.form1.id;
                    decimal cost = int.Parse(roomcost) * days;
                    cmd1.Parameters.Add("cost", OracleDbType.Decimal).Value = cost;
                    cmd1.Parameters.Add("sdate", OracleDbType.Date).Value = DateTime.Parse(Sdate.Text);
                    cmd1.Parameters.Add("edate", OracleDbType.Date).Value = DateTime.Parse(Edate.Text);
                    if (cmd1.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("The reservation cost is: " + cost.ToString() + "L.E.\nDo you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            q1 = "UPDATE ROOMS_PROJECT " +
                                "SET ROOM_STATE = 'NO'" +
                                "WHERE ROOM_ID = :id";
                            OracleCommand com = new OracleCommand(q1, conn);
                            com.Parameters.Add("id", roomid);
                            if (com.ExecuteNonQuery() != -1)
                                MessageBox.Show("Reservation Done");
                            else
                                MessageBox.Show("Error appeared");
                            t.Commit();
                            MessageBox.Show("The room number is: " + roomid.ToString());
                            this.Hide();
                            Program.form1.Update_datagrid();
                            Program.form1.Show();
                        }
                        else if (result == DialogResult.No)
                            t.Rollback();
                    }
                }
            }
            else
                MessageBox.Show("There is no rooms by this type available now");
        }
    }
}
