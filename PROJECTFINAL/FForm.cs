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
    public partial class FForm : Form
    {
        public FForm()
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
            label3.BackColor = Color.Gray;
            label3.ForeColor = Color.White;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.textBox1.Text = textBox1.Text;
            mf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TForm t = new TForm();
            t.textBox1.Text = textBox1.Text;
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PForm p = new PForm();
            p.userbox.Text = textBox1.Text;
            p.ShowDialog();
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

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Aquamarine;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
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

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Aquamarine;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Wheat;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Aquamarine;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Wheat;
        }

        private void f1_Click(object sender, EventArgs e)
        {
            string n1 = "NIKE W AIR MAX 2090";
            string un = textBox1.Text;
            int p1 = 5200;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n1;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p1;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void f2_Click(object sender, EventArgs e)
        {
            string n2 = "AIR VAPORMAX 360";
            string un = textBox1.Text;
            int p2 = 5250;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n2;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p2;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void f3_Click(object sender, EventArgs e)
        {
            string n3 = "ADIDAS 424 PRO MODEL";
            string un = textBox1.Text;
            int p3 = 5110;


            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `orange`(`username`,`name`, `price`) VALUES (@use,@nme,@pri)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = un;
            cmd.Parameters.Add("@nme", MySqlDbType.Text).Value = n3;
            cmd.Parameters.Add("@pri", MySqlDbType.Text).Value = p3;

            db.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("สั่งซื้อสำเร็จ!!");
            }

            db.closeConnection();
        }

        private void f4_Click(object sender, EventArgs e)
        {
            string n4 = "ADIDAS 424 SC PREMIERE";
            string un = textBox1.Text;
            int p4 = 5200;


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

        private void f5_Click(object sender, EventArgs e)
        {
            string n5 = "VANS OLD SKOOL";
            string un = textBox1.Text;
            int p5 = 2400;


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

        private void f6_Click(object sender, EventArgs e)
        {
            string n6 = "CONVERSE ALL STAR";
            string un = textBox1.Text;
            int p6 = 2290;


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
