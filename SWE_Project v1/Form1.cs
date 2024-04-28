﻿using System;
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
    public partial class Form1 : Form
    {
        string ordb = "Data Source = ORCl;user id=hr;Password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            dataGridView1.Columns.Add("resid", "resid");
            dataGridView1.Columns.Add("roomnumber", "roomnumber");
            dataGridView1.Columns.Add("roomtype", "roomtype");
            dataGridView1.Columns.Add("employee_name", "employee_name");
            dataGridView1.Columns.Add("cost", "cost");
            dataGridView1.Columns.Add("start_date", "start_date");
            dataGridView1.Columns.Add("end_date", "end_date");
            string query = "SELECT r.RESERVATION_ID, r.ROOM_ID, room.ROOM_TYPE, " +
                "emp.EMPLOYEE_NAME, r.RESERVATION_COST, r.START_DATE, r.END_DATE " +
                "FROM RESERVATIONS_PROJECT r " +
                "JOIN ROOMS_PROJECT room ON room.room_id = r.room_id " +
                "JOIN EMPLOYEES_PROJECT emp ON emp.employee_id = r.employee_id ";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader reader = cmd.ExecuteReader();
            string[] tmp = new string[7];
            while (reader.Read())
            {
                for (int i = 0; i < 7; i++)
                    tmp[i] = (reader[i].ToString());
                dataGridView1.Rows.Add(tmp);
            }
            reader.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string custIdQuery = "SELECT * FROM CUSTOMERS_PROJECT" +
                                     " WHERE customer_name = :name AND phone_number = :phone";
            OracleCommand cmdcust = new OracleCommand(custIdQuery, conn); 
            cmdcust.CommandText = custIdQuery;
            cmdcust.Parameters.Add("name", Custname.Text);
            cmdcust.Parameters.Add("phone", Custnumber.Text);
            OracleDataReader readercust = cmdcust.ExecuteReader();
            if (readercust.Read())
            {
                CustID.Text = readercust[0].ToString();
                Custname.Text = readercust[1].ToString();
                Custmail.Text = readercust[2].ToString();
                Custnumber.Text = readercust[3].ToString();
            }
            readercust.Close();
            OracleCommand cmdres;
            if (CustID.Text != "")
            {
                string query = "SELECT r.RESERVATION_ID, r.ROOM_ID, room.ROOM_TYPE," +
                    " emp.EMPLOYEE_NAME, r.RESERVATION_COST, r.START_DATE, r.END_DATE " +
                    "FROM RESERVATIONS_PROJECT r " +
                    "JOIN ROOMS_PROJECT room ON room.room_id = r.room_id " +
                    "JOIN EMPLOYEES_PROJECT emp ON emp.employee_id = r.employee_id " +
                    "WHERE r.CUSTOMER_ID = :id";
                cmdres = new OracleCommand(query, conn);
                cmdres.Parameters.Add("id", Decimal.Parse(CustID.Text));
                OracleDataReader dr = cmdres.ExecuteReader();
                while (dr.Read())
                {
                    string[] tmp = new string[7];
                    for (int i = 0; i < 7; i++)
                        tmp[i] = (dr[i].ToString());
                    dataGridView1.Rows.Add(tmp);
                }
                dr.Close();
            }
            else
            {
                string query = "SELECT r.RESERVATION_ID, r.ROOM_ID, room.ROOM_TYPE, " +
                    "emp.EMPLOYEE_NAME, r.RESERVATION_COST, r.START_DATE, r.END_DATE " +
                    "FROM RESERVATIONS_PROJECT r " +
                    "JOIN ROOMS_PROJECT room ON room.room_id = r.room_id " +
                    "JOIN EMPLOYEES_PROJECT emp ON emp.employee_id = r.employee_id ";
                cmdres = new OracleCommand(query, conn);
                OracleDataReader reader = cmdres.ExecuteReader();
                string[] tmp = new string[7];
                while (reader.Read())
                {
                    for (int i = 0; i < 7; i++)
                        tmp[i] = (reader[i].ToString());
                    dataGridView1.Rows.Add(tmp);
                }
                reader.Close();
            }
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            Program.form2.Show();
            Program.form1.Hide();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand("GetMaxID", conn);
            int newID;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try{
                newID = Convert.ToInt32(cmd.Parameters["ID"].Value.ToString()) + 1; 
            }
            catch {
                newID = 1; 
            }
            string query = "INSERT INTO CUSTOMERS_PROJECT " +
                "VALUES (:id, :name, :email, :phonenumber)";
            OracleCommand oc = new OracleCommand(query, conn);
            oc.Parameters.Add("id", newID);
            oc.Parameters.Add("name", Custname.Text);
            oc.Parameters.Add("email", Custmail.Text);
            oc.Parameters.Add("phonenumber", Custnumber.Text );
            CustID.Text = newID.ToString();
            if(oc.ExecuteNonQuery()!=-1)
                MessageBox.Show("Added Successfully");
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CUSTOMERS_PROJECT " +
                           "WHERE CUSTOMER_ID = :id";
            OracleCommand oc = new OracleCommand(query, conn);
            oc.Parameters.Add("id", Decimal.Parse(CustID.Text));
            CustID.Text = "";
            Custname.Text = "";
            Custmail.Text = "";
            Custnumber.Text = "";
            if (oc.ExecuteNonQuery() != -1)
                MessageBox.Show("Added Successfully");
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CUSTOMERS_PROJECT " +
               "SET CUSTOMER_NAME = :name, EMAIL = :email, PHONE_NUMBER = :phonenumber " +
               "WHERE CUSTOMER_ID = :id";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add("name", Custname.Text);
            cmd.Parameters.Add("email", Custmail.Text);
            cmd.Parameters.Add("phonenumber", Custnumber.Text);
            cmd.Parameters.Add("id", Decimal.Parse(CustID.Text));
            if (cmd.ExecuteNonQuery() != -1)
                MessageBox.Show("Customer modified");
        }
    }
}