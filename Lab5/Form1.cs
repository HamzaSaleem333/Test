using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.169.82.62;Initial Catalog=virtualb_Classwork;User ID=taha248;Password=timein");
            String Query = "INSERT INTO UserAccount (username,password,email) Values('"+textBox1.Text.ToString()+"','"+textBox1.Text.ToString() + "','"+textBox1.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(Query,conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
