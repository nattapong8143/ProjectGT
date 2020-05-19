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
    public partial class CartForm2 : Form
    {
        public CartForm2()
        {
            InitializeComponent();
            /**DB db = new DB();
            MySqlCommand cmd;
            string sql = "SELECT * FROM `orange`";

            cmd = new MySqlCommand(sql, db.getconnection());

            db.openConnection();

            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            db.closeConnection();*/
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.textBox1.Text = textBox3.Text;
            mf.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.textBox1.Text = textBox3.Text;
            mf.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd;
            string sql = "SELECT * FROM `orange`";
            sql = "DELETE FROM orange WHERE number='" + textBox2.Text + "'";

            cmd = new MySqlCommand(sql, db.getconnection());

            db.openConnection();

            if (!CheackTextboxsValues())
            {
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Please Enter Number for Delete!!");
            }
            db.closeConnection();

            DB bd = new DB();
            MySqlCommand cm;
            string sq = "SELECT * FROM `orange`WHERE `username` = @use";
            string useb = textBox3.Text;

            cm = new MySqlCommand(sq, bd.getconnection());
            cm.Parameters.Add("@use", MySqlDbType.VarChar).Value = useb;

            bd.openConnection();

            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(cm);
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            bd.closeConnection();
        }

        private void CartForm2_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd;
            string useb = textBox3.Text;
            string sql = "SELECT * FROM `orange` WHERE `username` = @use";

            cmd = new MySqlCommand(sql, db.getconnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            cmd.Parameters.Add("@use", MySqlDbType.VarChar).Value = useb;

            db.openConnection();

            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            db.closeConnection();
            //
        }
        
        public Boolean CheackTextboxsValues()
        {
            string ema = textBox2.Text;

            if (ema.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScripForrm sc = new ScripForrm();
            sc.textBox1.Text = textBox3.Text;
            sc.ShowDialog();
        }
        double all;
        private void sum_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `orange` WHERE CONCAT(username) LIKE '%"+textBox3.Text+"%'", db.getconnection());
            DataTable table = new DataTable();
            adp.Fill(table);
            int i = 0;
            while (i < table.Rows.Count)
            {
                all += Convert.ToDouble(table.Rows[i]["price"]);
                i++;
            }
            allbox.Text = all.ToString();
        }
    }
}
