using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace contacts
{
    public partial class Form1 : Form
    {
        string photopath;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\contacts\contacts\contacts\contacts\Database1.mdf;Integrated Security=True";
        }
        public void display()
        {
          
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = photopath;
            adp.Fill(ds, "Table");

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndelete1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_Leave(object sender, EventArgs e)
        {

        }

        private void txtname_TextCanged(object sender, EventArgs e)
        {

        }
    }
}
