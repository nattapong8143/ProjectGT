using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string user = userbox.Text;
            string pass = passbox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `username` =  @use and `password` = @pass", db.getconnection() );

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            // cheack user exist?
            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mform = new MainForm();
                mform.textBox1.Text = userbox.Text;
                mform.Show();
            }
            else
            {
                MessageBox.Show("Please Cheack username or password again");
            }

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            //is.Hide();
         // RegisterForm rform = new RegisterForm();
         // rform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                passbox.UseSystemPasswordChar = false;
            }
            else
            {
                passbox.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
