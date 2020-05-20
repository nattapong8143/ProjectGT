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
    public partial class ScripForrm : Form
    {
        public ScripForrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            byte[] img = ms.ToArray();

            string user = textBox1.Text;
            string insertQuery = "INSERT INTO `payimage`(`username`, `image`) VALUES (@use,@img)";
            DB db = new DB();
            MySqlCommand cmd;
            db.openConnection();

            cmd = new MySqlCommand(insertQuery, db.getconnection());

            cmd.Parameters.Add("use", MySqlDbType.Text).Value = user;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Insert Success!!");
            }

            db.closeConnection();
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
            CartForm2 crt = new CartForm2();
            crt.textBox3.Text = textBox1.Text;
            crt.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string name = textBox2.Text;
            string ads = textBox3.Text;
            DB db = new DB();
            DataSet table = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `mango`(`username`, `name`, `address`) VALUES (@use,@nme,@ad)", db.getconnection());

            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@nme", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ads;

            db.openConnection();

            cmd.ExecuteNonQuery();

            db.closeConnection();

            DB bd = new DB();
            MySqlCommand cm;
            string sql = "DELETE FROM `orange` WHERE `username` = @use";

            cm = new MySqlCommand(sql, bd.getconnection());
            cm.Parameters.Add("@use", MySqlDbType.VarChar).Value = user; 

            bd.openConnection();

            cm.ExecuteNonQuery();

            bd.closeConnection();

            MessageBox.Show("ซื้อสำเร็จ รอรับของได้เลนครับ!!");
            MainForm mf = new MainForm();
            mf.textBox1.Text = textBox1.Text;
            mf.ShowDialog();
        }
    }
}
