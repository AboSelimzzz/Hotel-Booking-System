using System;
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
            string query = "Select ROOM_TYPE"/*, row_number() over () id */+" from COSTPERNIGHT_PROJECT"/* order by id"*/;
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
            Application.Exit();
        }

        private void calbtn_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = !monthCalendar2.Visible;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionStart.Date;
            Sdate.Text = selectedDate.ToString(selectedDate.ToString("dd-MMM-yy"));
        }

        private void calbtn2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            Edate.Text = selectedDate.ToString(selectedDate.ToString("dd-MMM-yy"));
        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
            monthCalendar1.Visible = false;
            if (Edate.Text == "" && Edate.Text == "" && typecmb.SelectedText == "")
            {
                MessageBox.Show("Fill all the data");
                return;
            }
            if(DateTime.Parse(Edate.Text) < DateTime.Parse(Sdate.Text))
            {
                MessageBox.Show("Select Valid Date");
                return;
            }
            string query = "Select r.ROOM_ID, c.ROOM_COST " +
                "from ROOMS_PROJECT r, COSTPERNIGHT_PROJECT c " +
                "where r.ROOM_TYPE = :type  and r.Room_state = 'YES' and c.ROOM_TYPE = :type";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add("type", typecmb.SelectedItem);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                decimal roomid = Decimal.Parse(dr[0].ToString());
                string roomcost = dr[1].ToString();
                int days = int.Parse(TimeSpan.Parse((DateTime.Parse(Edate.Text) - DateTime.Parse(Sdate.Text)).ToString()).TotalDays.ToString()); 
                string q1 = "insert into RESERVATIONS_PROJECT " +
                    "values(:id, :rid, :eid, :cid, :cost, to_date(:sdate, 'dd-MMM-yy'), to_date(:edate, 'dd-MMM-yy')); " +
                    "Update Rooms_Project " +
                    "SET Room_State = 'NO' " +
                    "where Room_id = :roomid;";
                using (OracleCommand cmd1 = new OracleCommand(q1, conn))
                {
                    cmd1.Parameters.Add("id", 3);
                    cmd1.Parameters.Add("rid", roomid);
                    cmd1.Parameters.Add("eid", 1); //el id beta3 el employee
                    cmd1.Parameters.Add("cid", Program.form1.id);
                    cmd1.Parameters.Add("cost", Decimal.Parse((int.Parse(roomcost) * days).ToString()));
                    cmd1.Parameters.Add("sdate", DateTime.ParseExact(Sdate.Text, "dd-MMM-yy", System.Globalization.CultureInfo.InvariantCulture));
                    cmd1.Parameters.Add("edate", DateTime.ParseExact(Edate.Text, "dd-MMM-yy", System.Globalization.CultureInfo.InvariantCulture));
                    cmd1.Parameters.Add("roomid", roomid);
                    if (cmd1.ExecuteNonQuery() == -1)
                        MessageBox.Show("Error");
                    else
                        MessageBox.Show("Room number = " + dr[0].ToString());
                }
            }            
        }
    }
}
