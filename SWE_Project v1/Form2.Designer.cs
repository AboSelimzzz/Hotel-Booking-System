namespace SWE_Project
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Edate = new System.Windows.Forms.TextBox();
            this.Sdate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.calbtn = new System.Windows.Forms.Button();
            this.calbtn2 = new System.Windows.Forms.Button();
            this.typecmb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edate
            // 
            this.Edate.Location = new System.Drawing.Point(517, 88);
            this.Edate.Name = "Edate";
            this.Edate.Size = new System.Drawing.Size(153, 26);
            this.Edate.TabIndex = 2;
            // 
            // Sdate
            // 
            this.Sdate.Location = new System.Drawing.Point(264, 88);
            this.Sdate.Name = "Sdate";
            this.Sdate.Size = new System.Drawing.Size(160, 26);
            this.Sdate.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(470, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(140, 123);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // calbtn
            // 
            this.calbtn.Location = new System.Drawing.Point(420, 88);
            this.calbtn.Name = "calbtn";
            this.calbtn.Size = new System.Drawing.Size(29, 23);
            this.calbtn.TabIndex = 6;
            this.calbtn.Text = "cal";
            this.calbtn.UseVisualStyleBackColor = true;
            this.calbtn.Click += new System.EventHandler(this.calbtn_Click);
            // 
            // calbtn2
            // 
            this.calbtn2.Location = new System.Drawing.Point(660, 90);
            this.calbtn2.Name = "calbtn2";
            this.calbtn2.Size = new System.Drawing.Size(29, 23);
            this.calbtn2.TabIndex = 7;
            this.calbtn2.Text = "cal";
            this.calbtn2.UseVisualStyleBackColor = true;
            this.calbtn2.Click += new System.EventHandler(this.calbtn2_Click);
            // 
            // typecmb
            // 
            this.typecmb.FormattingEnabled = true;
            this.typecmb.Location = new System.Drawing.Point(37, 82);
            this.typecmb.Name = "typecmb";
            this.typecmb.Size = new System.Drawing.Size(121, 28);
            this.typecmb.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 312);
            this.button2.Name = "Book";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bookbtn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Bookbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typecmb);
            this.Controls.Add(this.calbtn2);
            this.Controls.Add(this.calbtn);
            this.Controls.Add(this.Sdate);
            this.Controls.Add(this.Edate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.monthCalendar2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Edate;
        private System.Windows.Forms.TextBox Sdate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button calbtn;
        private System.Windows.Forms.Button calbtn2;
        private System.Windows.Forms.ComboBox typecmb;
        private System.Windows.Forms.Button button2;
    }
}