namespace SWE_Project
{
    partial class Form5
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
            this.rid = new System.Windows.Forms.TextBox();
            this.roomid = new System.Windows.Forms.TextBox();
            this.roomtype = new System.Windows.Forms.TextBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.Sdate = new System.Windows.Forms.TextBox();
            this.Edate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.Checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rid
            // 
            this.rid.Location = new System.Drawing.Point(27, 43);
            this.rid.Name = "rid";
            this.rid.ReadOnly = true;
            this.rid.Size = new System.Drawing.Size(100, 26);
            this.rid.TabIndex = 0;
            // 
            // roomid
            // 
            this.roomid.Location = new System.Drawing.Point(148, 43);
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.Size = new System.Drawing.Size(100, 26);
            this.roomid.TabIndex = 1;
            // 
            // roomtype
            // 
            this.roomtype.Location = new System.Drawing.Point(281, 43);
            this.roomtype.Name = "roomtype";
            this.roomtype.ReadOnly = true;
            this.roomtype.Size = new System.Drawing.Size(100, 26);
            this.roomtype.TabIndex = 2;
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(418, 43);
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Size = new System.Drawing.Size(100, 26);
            this.empname.TabIndex = 3;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(551, 43);
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(100, 26);
            this.cost.TabIndex = 4;
            // 
            // Sdate
            // 
            this.Sdate.Location = new System.Drawing.Point(684, 43);
            this.Sdate.Name = "Sdate";
            this.Sdate.ReadOnly = true;
            this.Sdate.Size = new System.Drawing.Size(100, 26);
            this.Sdate.TabIndex = 5;
            // 
            // Edate
            // 
            this.Edate.Location = new System.Drawing.Point(825, 43);
            this.Edate.Name = "Edate";
            this.Edate.ReadOnly = true;
            this.Edate.Size = new System.Drawing.Size(100, 26);
            this.Edate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reservation id           room id                   room type                emp n" +
    "ame               cost                         Start Date                   End " +
    "Date";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(111, 429);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 39);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(394, 435);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 33);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 164);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(518, 154);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 11;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start date                                                                       " +
    "                                         End Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(729, 435);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(85, 34);
            this.Checkout.TabIndex = 13;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 537);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edate);
            this.Controls.Add(this.Sdate);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.roomid);
            this.Controls.Add(this.rid);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.TextBox roomid;
        private System.Windows.Forms.TextBox roomtype;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox Sdate;
        private System.Windows.Forms.TextBox Edate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Checkout;
    }
}