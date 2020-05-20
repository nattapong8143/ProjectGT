using MySql.Data.MySqlClient;
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
    public partial class TForm : Form
    {
        public TForm()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Gray;
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.textBox1.Text = textBox1.Text;
            mf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PForm p = new PForm();
            p.userbox.Text = textBox1.Text;
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FForm f = new FForm();
            f.textBox1.Text = textBox1.Text;
            f.ShowDialog();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Aquamarine;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Wheat;
        }
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Aquamarine;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Wheat;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Aquamarine;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Wheat;
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Aquamarine;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Wheat;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Aquamarine;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Wheat;
        }

        private void linkLabel4_MouseEnter_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Aquamarine;
        }

        private void linkLabel4_MouseLeave_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Wheat;
        }

        private void T1_Click(object sender, EventArgs e)
        {
            string n1 = "T-SHIRT LIGHT BLUE";
            string un = textBox1.Text;
            int p1 = 990;

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.VarChar).Value = n1;
            cmd.Parameters.Add("@pri", MySqlDbType.VarChar).Value = p1;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void T2_Click(object sender, EventArgs e)
        {
            string n2 = "T-SHIRT PURPLE";
            string un = textBox1.Text;
            int p2 = 990;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.VarChar).Value = n2;
            cmd.Parameters.Add("@pri", MySqlDbType.VarChar).Value = p2;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void T3_Click(object sender, EventArgs e)
        {
            string n3 = "OVERSIZE WHITE COLOR";
            string un = textBox1.Text;
            int p3 = 420;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.VarChar).Value = n3;
            cmd.Parameters.Add("@pri", MySqlDbType.VarChar).Value = p3;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void T4_Click(object sender, EventArgs e)
        {
            string n4 = "EIGHTY EIGHT / BLUE";
            string un = textBox1.Text;
            int p4 = 590;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n4;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p4;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void T5_Click(object sender, EventArgs e)
        {
            string n5 = "BURNOUTS";
            string un = textBox1.Text;
            int p5 = 450;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n5;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p5;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void T6_Click(object sender, EventArgs e)
        {
            string n6 = "FOLLOW THE LIGHT";
            string un = textBox1.Text;
            int p6 = 590;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n6;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p6;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }
    }
}
