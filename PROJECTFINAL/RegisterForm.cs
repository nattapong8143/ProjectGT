using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJECTFINAL
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `user`(`email`, `username`, `password`) VALUES (@email,@use,@pass)", db.getconnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = user.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text;

            db.openConnection();

            if (!CheackTextboxsValues())
            {
                if(pass.Text.Equals(pass2.Text))
                {
                    if (CheackUsername())
                    {
                        MessageBox.Show("This Username has Already!! Please Select New");
                    }
                    else
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Create");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirm Password");
                }
            }
            else
            {
                MessageBox.Show("Error!! Please Enter Information");
            }

            db.closeConnection();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        public Boolean CheackUsername()
        {
            DB db = new DB();

            string use = user.Text;
            //string pas = pass.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `username` =  @use", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = use;

            adapter.SelectCommand = cmd;

            adapter.Fill(table);

            //cheack username aleady in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheackTextboxsValues()
        {
            string ema = email.Text;
            string use = user.Text;
            string pas = pass.Text;
            if (ema.Equals("email address")|| use.Equals("username") || pas.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void user_Enter(object sender, EventArgs e)
        {
            string use = user.Text;
            if (use.ToLower().Trim().Equals("username"))
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            string use = user.Text;
            if(use.ToLower().Trim().Equals("username") || use.Trim().Equals(""))
            {
                user.Text = "username";
                user.ForeColor = Color.Gray;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            string ema = email.Text;
            if (ema.ToLower().Trim().Equals("email address"))
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            string ema = email.Text;
            if (ema.ToLower().Trim().Equals("email address") || ema.Trim().Equals(""))
            {
                email.Text = "email address";
                email.ForeColor = Color.Gray;
            }
        }
        private void pass_Enter(object sender, EventArgs e)
        {
            string pas = pass.Text;
            if(pas.ToLower().Trim().Equals("password"))
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            string pas= pass.Text;
            if(pas.ToLower().Trim().Equals("password") || pas.Trim().Equals(""))
            {
                pass.Text = "password";
                pass.ForeColor = Color.Gray;
            }
        }

        private void pass2_Enter(object sender, EventArgs e)
        {
            string pas2 = pass2.Text;
            if(pas2.ToLower().Trim().Equals("confirm password"))
            {
                pass2.Text = "";
                pass2.ForeColor = Color.Black;
            }
        }

        private void pass2_Leave(object sender, EventArgs e)
        {
            string pas2 = pass2.Text;
            if (pas2.ToLower().Trim().Equals("confirm password") || pas2.Trim().Equals(""))
            {
                pass2.Text = "confirm password";
                pass2.ForeColor = Color.Gray;
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Gray;
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
