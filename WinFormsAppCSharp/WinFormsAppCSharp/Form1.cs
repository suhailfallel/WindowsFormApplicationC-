using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=SUHAIL_PV\SQLEXPRESS;Initial Catalog=myDb;Integrated Security=True";

            string sqlQuery = "insert into Employee(EmpId, Name, Adress, PhoneNo, Department, Position) values(" +
                "'" + empid.Text + "'" + "," + "'" + name.Text + "'" + "," + "'" + address.Text + "'" + "," + "'" + phoneno.Text + "'" + "," +
                "'" + dept.Text + "'" + "," + "'" + pos.Text + "'" + ")";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
            con.Close();

            empid.Clear();
            name.Clear();
            address.Clear();
            phoneno.Clear();
            dept.Clear();
            pos.Clear();

            BindGrid();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            empid.Clear();
            name.Clear();
            address.Clear();
            phoneno.Clear();
            dept.Clear();
            pos.Clear();
        }

        private void BindGrid()
        {
            string conString = @"Data Source=SUHAIL_PV\SQLEXPRESS;Initial Catalog=myDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listallBTN_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=SUHAIL_PV\SQLEXPRESS;Initial Catalog=myDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employee set Name='" + name.Text + "',Adress='" + address.Text + "',PhoneNo='" +
                phoneno.Text + "',Department='" + dept.Text + "',Position='" + pos.Text + "' where Empid='" + empid.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
            name.Clear();
            empid.Clear();
            address.Clear();
            phoneno.Clear();
            dept.Clear();
            pos.Clear();
        }

        private void dltBTN_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=SUHAIL_PV\SQLEXPRESS;Initial Catalog=myDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete Employee where Empid='" + empid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
            empid.Clear();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=SUHAIL_PV\SQLEXPRESS;Initial Catalog=myDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where Empid='" + empid.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void extBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
