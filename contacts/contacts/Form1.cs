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
            if (txtname.Text == "Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Name";
                txtname.ForeColor = Color.DimGray;
            }
        }

        private void txtfamily_Enter(object sender, EventArgs e)
        {
            if (txtfamily.Text == "Family")
            {
                txtfamily.Text = "";
                txtfamily.ForeColor = Color.Black;
            }
        }

        private void txtfamily_Leave(object sender, EventArgs e)
        {
            if (txtfamily.Text == "")
            {
                txtfamily.Text = "Family";
                txtfamily.ForeColor = Color.DimGray;
            }
        }

        private void txtnumber_Enter(object sender, EventArgs e)
        {
            if (txtnumber.Text == "Number")
            {
                txtnumber.Text = "";
                txtnumber.ForeColor = Color.Black;
            }
        }

        private void txtnumber_Leave(object sender, EventArgs e)
        {
            if (txtnumber.Text == "")
            {
                txtnumber.Text = "Number";
                txtnumber.ForeColor = Color.DimGray;
            }
        }

        private void txtaddres_Enter(object sender, EventArgs e)
        {
            if (txtaddres.Text == "Addres")
            {
                txtaddres.Text = "";
                txtaddres.ForeColor = Color.Black;
            }
        }

        private void txtaddres_Leave(object sender, EventArgs e)
        {
            if (txtaddres.Text == "")
            {
                txtaddres.Text = "Addres";
                txtaddres.ForeColor = Color.DimGray;
            }
        }
    }
}
