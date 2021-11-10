namespace contacts
{
    partial class frmmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblkeyword = new System.Windows.Forms.Label();
            this.comboBoxsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btndark = new System.Windows.Forms.RadioButton();
            this.btngotolast = new System.Windows.Forms.Button();
            this.btngotofirst = new System.Windows.Forms.Button();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnumberofcontacts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnprevius = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(695, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.LightGray;
            this.txtname.Location = new System.Drawing.Point(212, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(270, 27);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Name";
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtfamily
            // 
            this.txtfamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtfamily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamily.ForeColor = System.Drawing.Color.LightGray;
            this.txtfamily.Location = new System.Drawing.Point(212, 63);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(270, 27);
            this.txtfamily.TabIndex = 2;
            this.txtfamily.Text = "Family";
            this.txtfamily.TextChanged += new System.EventHandler(this.txtfamily_TextChanged);
            this.txtfamily.Enter += new System.EventHandler(this.txtfamily_Enter);
            this.txtfamily.Leave += new System.EventHandler(this.txtfamily_Leave);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtnumber.ForeColor = System.Drawing.Color.LightGray;
            this.txtnumber.Location = new System.Drawing.Point(212, 108);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(270, 27);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.Text = "Number";
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            this.txtnumber.Enter += new System.EventHandler(this.txtnumber_Enter);
            this.txtnumber.Leave += new System.EventHandler(this.txtnumber_Leave);
            // 
            // txtaddres
            // 
            this.txtaddres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtaddres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtaddres.ForeColor = System.Drawing.Color.LightGray;
            this.txtaddres.Location = new System.Drawing.Point(213, 155);
            this.txtaddres.Multiline = true;
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(269, 70);
            this.txtaddres.TabIndex = 4;
            this.txtaddres.Text = "Addres";
            this.txtaddres.TextChanged += new System.EventHandler(this.txtaddres_TextChanged);
            this.txtaddres.Enter += new System.EventHandler(this.txtaddres_Enter);
            this.txtaddres.Leave += new System.EventHandler(this.txtaddres_Leave);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnbrowse.FlatAppearance.BorderSize = 0;
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnbrowse.Location = new System.Drawing.Point(710, 197);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(110, 31);
            this.btnbrowse.TabIndex = 5;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.lblsearch.Location = new System.Drawing.Point(208, 266);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(136, 40);
            this.lblsearch.TabIndex = 10;
            this.lblsearch.Text = "search by";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // lblkeyword
            // 
            this.lblkeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblkeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.lblkeyword.Location = new System.Drawing.Point(208, 306);
            this.lblkeyword.Name = "lblkeyword";
            this.lblkeyword.Size = new System.Drawing.Size(136, 40);
            this.lblkeyword.TabIndex = 11;
            this.lblkeyword.Text = "contains";
            this.lblkeyword.Click += new System.EventHandler(this.lblkeyword_Click);
            // 
            // comboBoxsearch
            // 
            this.comboBoxsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBoxsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxsearch.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxsearch.FormattingEnabled = true;
            this.comboBoxsearch.Location = new System.Drawing.Point(333, 270);
            this.comboBoxsearch.Name = "comboBoxsearch";
            this.comboBoxsearch.Size = new System.Drawing.Size(132, 30);
            this.comboBoxsearch.TabIndex = 12;
            this.comboBoxsearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxsearch_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(246)))));
            this.btnsearch.Location = new System.Drawing.Point(266, 363);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 28);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(552, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(333, 306);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btndark);
            this.panel1.Controls.Add(this.btngotolast);
            this.panel1.Controls.Add(this.btngotofirst);
            this.panel1.Controls.Add(this.btndelete1);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 490);
            this.panel1.TabIndex = 16;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 155);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 225);
            this.pnlNav.TabIndex = 6;
            // 
            // btndark
            // 
            this.btndark.AutoSize = true;
            this.btndark.Checked = true;
            this.btndark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btndark.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndark.Image = ((System.Drawing.Image)(resources.GetObject("btndark.Image")));
            this.btndark.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndark.Location = new System.Drawing.Point(0, 463);
            this.btndark.Name = "btndark";
            this.btndark.Size = new System.Drawing.Size(186, 27);
            this.btndark.TabIndex = 5;
            this.btndark.TabStop = true;
            this.btndark.Text = "Dark theme";
            this.btndark.UseVisualStyleBackColor = true;
            // 
            // btngotolast
            // 
            this.btngotolast.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngotolast.FlatAppearance.BorderSize = 0;
            this.btngotolast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngotolast.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngotolast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btngotolast.Image = ((System.Drawing.Image)(resources.GetObject("btngotolast.Image")));
            this.btngotolast.Location = new System.Drawing.Point(0, 354);
            this.btngotolast.Name = "btngotolast";
            this.btngotolast.Size = new System.Drawing.Size(186, 42);
            this.btngotolast.TabIndex = 4;
            this.btngotolast.Text = "Go to last";
            this.btngotolast.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btngotolast.UseVisualStyleBackColor = true;
            this.btngotolast.Click += new System.EventHandler(this.btngotolast_Click);
            this.btngotolast.Leave += new System.EventHandler(this.btngotolast_Leave);
            // 
            // btngotofirst
            // 
            this.btngotofirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngotofirst.FlatAppearance.BorderSize = 0;
            this.btngotofirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngotofirst.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngotofirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btngotofirst.Image = ((System.Drawing.Image)(resources.GetObject("btngotofirst.Image")));
            this.btngotofirst.Location = new System.Drawing.Point(0, 312);
            this.btngotofirst.Name = "btngotofirst";
            this.btngotofirst.Size = new System.Drawing.Size(186, 42);
            this.btngotofirst.TabIndex = 4;
            this.btngotofirst.Text = "Go to first";
            this.btngotofirst.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btngotofirst.UseVisualStyleBackColor = true;
            this.btngotofirst.Click += new System.EventHandler(this.btngotofirst_Click);
            this.btngotofirst.Leave += new System.EventHandler(this.btngotofirst_Leave);
            // 
            // btndelete1
            // 
            this.btndelete1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndelete1.FlatAppearance.BorderSize = 0;
            this.btndelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndelete1.Image = ((System.Drawing.Image)(resources.GetObject("btndelete1.Image")));
            this.btndelete1.Location = new System.Drawing.Point(0, 270);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(186, 42);
            this.btndelete1.TabIndex = 4;
            this.btndelete1.Text = "Delete";
            this.btndelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndelete1.UseVisualStyleBackColor = true;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            this.btndelete1.Leave += new System.EventHandler(this.btndelete1_Leave);
            // 
            // btnedit
            // 
            this.btnedit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnedit.Location = new System.Drawing.Point(0, 228);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(186, 42);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            this.btnedit.Leave += new System.EventHandler(this.btnedit_Leave);
            // 
            // btnsave
            // 
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(0, 186);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(186, 42);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.Leave += new System.EventHandler(this.btnsave_Leave);
            // 
            // btnnew
            // 
            this.btnnew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(0, 144);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(186, 42);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New";
            this.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            this.btnnew.Leave += new System.EventHandler(this.btnnew_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblnumberofcontacts);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // lblnumberofcontacts
            // 
            this.lblnumberofcontacts.AutoSize = true;
            this.lblnumberofcontacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblnumberofcontacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblnumberofcontacts.Location = new System.Drawing.Point(48, 120);
            this.lblnumberofcontacts.Name = "lblnumberofcontacts";
            this.lblnumberofcontacts.Size = new System.Drawing.Size(80, 15);
            this.lblnumberofcontacts.TabIndex = 2;
            this.lblnumberofcontacts.Text = "26 contacts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soheil H";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(884, 8);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(25, 25);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnprevius
            // 
            this.btnprevius.FlatAppearance.BorderSize = 0;
            this.btnprevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevius.Image = ((System.Drawing.Image)(resources.GetObject("btnprevius.Image")));
            this.btnprevius.Location = new System.Drawing.Point(213, 420);
            this.btnprevius.Name = "btnprevius";
            this.btnprevius.Size = new System.Drawing.Size(58, 46);
            this.btnprevius.TabIndex = 18;
            this.btnprevius.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.Image")));
            this.btnnext.Location = new System.Drawing.Point(407, 420);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(58, 46);
            this.btnnext.TabIndex = 19;
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(921, 490);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprevius);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboBoxsearch);
            this.Controls.Add(this.lblkeyword);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtaddres);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contact soheil";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtaddres;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblkeyword;
        private System.Windows.Forms.ComboBox comboBoxsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblnumberofcontacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btngotolast;
        private System.Windows.Forms.Button btngotofirst;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RadioButton btndark;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnprevius;
        private System.Windows.Forms.Button btnnext;
    }
}

