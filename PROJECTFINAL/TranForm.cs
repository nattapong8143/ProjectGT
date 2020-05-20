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
    public partial class TranForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=test");
        MySqlCommand cmd;
        public TranForm()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //System.Diagnostics.Process.Start("https://www.google.co.th/?hl=th");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = userbox2.Text;
            string sql = "SELECT * FROM `testtable`";

            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("nme", MySqlDbType.Text).Value = name;

            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
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
            mf.textBox1.Text = userbox2.Text;
            mf.ShowDialog();
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

        private void TranForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
