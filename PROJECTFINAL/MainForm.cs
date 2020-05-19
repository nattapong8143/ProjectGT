using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTFINAL
{
    public partial class MainForm : Form
    {
        //MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database= mamong ");
        //MySqlCommand cmd;
        private bool catagory;
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            PForm p = new PForm();
            p.userbox.Text = textBox1.Text;
            p.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(catagory)
            {
                panel2.Height += 10;
                if(panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    catagory = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    catagory = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Black;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Black;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm2 crt = new CartForm2();
            crt.textBox3.Text = textBox1.Text;
            crt.ShowDialog();
        }
        private void panel4_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Aquamarine;
        }

        private void panel4_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Wheat;
        }

        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Aquamarine;
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Wheat;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Aquamarine;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Wheat;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TForm t = new TForm();
            t.textBox1.Text = textBox1.Text;
            t.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FForm f = new FForm();
            f.textBox1.Text = textBox1.Text;
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TranForm tf = new TranForm();
            tf.userbox2.Text = textBox1.Text;
            tf.ShowDialog();
        }
        //double 
        private void button11_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
