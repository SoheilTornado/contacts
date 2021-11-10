namespace contacts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblkeyword = new System.Windows.Forms.Label();
            this.comboBoxsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(218, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtname
            // 
            this.txtname.ForeColor = System.Drawing.Color.DimGray;
            this.txtname.Location = new System.Drawing.Point(5, 7);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(201, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Name";
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtfamily
            // 
            this.txtfamily.ForeColor = System.Drawing.Color.DimGray;
            this.txtfamily.Location = new System.Drawing.Point(5, 35);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(201, 22);
            this.txtfamily.TabIndex = 2;
            this.txtfamily.Text = "Family";
            this.txtfamily.Enter += new System.EventHandler(this.txtfamily_Enter);
            this.txtfamily.Leave += new System.EventHandler(this.txtfamily_Leave);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtnumber.Location = new System.Drawing.Point(5, 63);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(201, 22);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.Text = "Number";
            this.txtnumber.Enter += new System.EventHandler(this.txtnumber_Enter);
            this.txtnumber.Leave += new System.EventHandler(this.txtnumber_Leave);
            // 
            // txtaddres
            // 
            this.txtaddres.ForeColor = System.Drawing.Color.DimGray;
            this.txtaddres.Location = new System.Drawing.Point(5, 91);
            this.txtaddres.Multiline = true;
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(201, 70);
            this.txtaddres.TabIndex = 4;
            this.txtaddres.Text = "Addres";
            this.txtaddres.Enter += new System.EventHandler(this.txtaddres_Enter);
            this.txtaddres.Leave += new System.EventHandler(this.txtaddres_Leave);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(218, 130);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(100, 31);
            this.btnbrowse.TabIndex = 5;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(15, 167);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(133, 42);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(181, 167);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 42);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(15, 215);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(133, 42);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Edit";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndelete1
            // 
            this.btndelete1.Location = new System.Drawing.Point(167, 215);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(133, 42);
            this.btndelete1.TabIndex = 9;
            this.btndelete1.Text = "Delete";
            this.btndelete1.UseCompatibleTextRendering = true;
            this.btndelete1.UseVisualStyleBackColor = true;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsearch.Location = new System.Drawing.Point(12, 282);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(136, 40);
            this.lblsearch.TabIndex = 10;
            this.lblsearch.Text = "search by";
            // 
            // lblkeyword
            // 
            this.lblkeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblkeyword.Location = new System.Drawing.Point(12, 322);
            this.lblkeyword.Name = "lblkeyword";
            this.lblkeyword.Size = new System.Drawing.Size(136, 40);
            this.lblkeyword.TabIndex = 11;
            this.lblkeyword.Text = "contains";
            // 
            // comboBoxsearch
            // 
            this.comboBoxsearch.FormattingEnabled = true;
            this.comboBoxsearch.Location = new System.Drawing.Point(167, 282);
            this.comboBoxsearch.Name = "comboBoxsearch";
            this.comboBoxsearch.Size = new System.Drawing.Size(132, 24);
            this.comboBoxsearch.TabIndex = 12;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(76, 365);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 28);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 322);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboBoxsearch);
            this.Controls.Add(this.lblkeyword);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btndelete1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtaddres);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "contact soheil";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblkeyword;
        private System.Windows.Forms.ComboBox comboBoxsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

