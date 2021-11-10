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
using System.Runtime.InteropServices;



namespace contacts
{
    public partial class frmmain : Form
    {
        // /////////////////////////////////////////////////////////////////////
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        // /////////////////////////////////////////////////////////////////////////////
        string photopath;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        public frmmain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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
            btnbrowse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnbrowse.Width, btnbrowse.Height, 20, 20));
            btnsearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnsearch.Width, btnsearch.Height, 20, 20));

        }


        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.White;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Name";
                txtname.ForeColor = Color.LightGray;
            }
        }

        private void txtfamily_Enter(object sender, EventArgs e)
        {
            if (txtfamily.Text == "Family")
            {
                txtfamily.Text = "";
                txtfamily.ForeColor = Color.White;
            }
        }

        private void txtfamily_Leave(object sender, EventArgs e)
        {
            if (txtfamily.Text == "")
            {
                txtfamily.Text = "Family";
                txtfamily.ForeColor = Color.LightGray;
            }
        }

        private void txtnumber_Enter(object sender, EventArgs e)
        {
            if (txtnumber.Text == "Number")
            {
                txtnumber.Text = "";
                txtnumber.ForeColor = Color.White;
            }
        }

        private void txtnumber_Leave(object sender, EventArgs e)
        {
            if (txtnumber.Text == "")
            {
                txtnumber.Text = "Number";
                txtnumber.ForeColor = Color.LightGray;
            }
        }

        private void txtaddres_Enter(object sender, EventArgs e)
        {
            if (txtaddres.Text == "Addres")
            {
                txtaddres.Text = "";
                txtaddres.ForeColor = Color.White;
            }
        }

        private void txtaddres_Leave(object sender, EventArgs e)
        {
            if (txtaddres.Text == "")
            {
                txtaddres.Text = "Addres";
                txtaddres.ForeColor = Color.LightGray;
            }
        }

        private void txtaddres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblkeyword_Click(object sender, EventArgs e)
        {

        }

        private void lblsearch_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnnew.Height;
            pnlNav.Top = btnnew.Top;
            pnlNav.Left = btnnew.Left;
            btnnew.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsave.Height;
            pnlNav.Top = btnsave.Top;
            pnlNav.Left = btnsave.Left;
            btnsave.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnedit.Height;
            pnlNav.Top = btnedit.Top;
            pnlNav.Left = btnedit.Left;
            btnedit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btndelete1.Height;
            pnlNav.Top = btndelete1.Top;
            pnlNav.Left = btndelete1.Left;
            btndelete1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btngotofirst_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btngotofirst.Height;
            pnlNav.Top = btngotofirst.Top;
            pnlNav.Left = btngotofirst.Left;
            btngotofirst.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btngotolast_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btngotolast.Height;
            pnlNav.Top = btngotolast.Top;
            pnlNav.Left = btngotolast.Left;
            btngotolast.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnnew_Leave(object sender, EventArgs e)
        {
            btnnew.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsave_Leave(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnedit_Leave(object sender, EventArgs e)
        {
            btnedit.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btndelete1_Leave(object sender, EventArgs e)
        {
            btndelete1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btngotofirst_Leave(object sender, EventArgs e)
        {
            btngotofirst.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btngotolast_Leave(object sender, EventArgs e)
        {
            btngotolast.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
