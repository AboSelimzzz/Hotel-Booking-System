using System.Windows.Forms;

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
            this.Edate.Location = new System.Drawing.Point(644, 68);
            this.Edate.Name = "Edate";
            this.Edate.ReadOnly = true;
            this.Edate.Size = new System.Drawing.Size(153, 26);
            this.Edate.TabIndex = 2;
            // 
            // Sdate
            // 
            this.Sdate.Location = new System.Drawing.Point(264, 88);
            this.Sdate.Name = "Sdate";
            this.Sdate.ReadOnly = true;
            this.Sdate.Size = new System.Drawing.Size(160, 26);
            this.Sdate.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(585, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(217, 29);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // typecmb
            // 
            this.typecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecmb.FormattingEnabled = true;
            this.typecmb.Location = new System.Drawing.Point(37, 82);
            this.typecmb.Name = "typecmb";
            this.typecmb.Size = new System.Drawing.Size(121, 28);
            this.typecmb.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 309);
            this.button2.Name = "button2";
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
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typecmb);
            this.Controls.Add(this.Sdate);
            this.Controls.Add(this.Edate);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ComboBox typecmb;
        private System.Windows.Forms.Button button2;
    }
}