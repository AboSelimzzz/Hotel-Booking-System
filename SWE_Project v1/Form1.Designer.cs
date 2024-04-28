namespace SWE_Project
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
            this.Custnumber = new System.Windows.Forms.TextBox();
            this.bookbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Custname = new System.Windows.Forms.TextBox();
            this.Custmail = new System.Windows.Forms.TextBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.CustID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Custnumber
            // 
            this.Custnumber.Location = new System.Drawing.Point(983, 46);
            this.Custnumber.Name = "Custnumber";
            this.Custnumber.Size = new System.Drawing.Size(193, 26);
            this.Custnumber.TabIndex = 0;
            // 
            // bookbtn
            // 
            this.bookbtn.Location = new System.Drawing.Point(1048, 120);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(102, 34);
            this.bookbtn.TabIndex = 3;
            this.bookbtn.Text = "Book";
            this.bookbtn.UseVisualStyleBackColor = true;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(733, 120);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(92, 34);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(151, 120);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(97, 34);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 464);
            this.dataGridView1.TabIndex = 6;
            // 
            // Custname
            // 
            this.Custname.Location = new System.Drawing.Point(179, 46);
            this.Custname.Name = "Custname";
            this.Custname.Size = new System.Drawing.Size(219, 26);
            this.Custname.TabIndex = 7;
            // 
            // Custmail
            // 
            this.Custmail.Location = new System.Drawing.Point(552, 46);
            this.Custmail.Name = "Custmail";
            this.Custmail.Size = new System.Drawing.Size(273, 26);
            this.Custmail.TabIndex = 8;
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(412, 120);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(97, 34);
            this.Editbtn.TabIndex = 9;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(281, 120);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(97, 34);
            this.Deletebtn.TabIndex = 10;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // CustID
            // 
            this.CustID.Location = new System.Drawing.Point(23, 46);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(100, 26);
            this.CustID.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 682);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Custmail);
            this.Controls.Add(this.Custname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.bookbtn);
            this.Controls.Add(this.Custnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Custnumber;
        private System.Windows.Forms.Button bookbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Custname;
        private System.Windows.Forms.TextBox Custmail;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox CustID;
    }
}

