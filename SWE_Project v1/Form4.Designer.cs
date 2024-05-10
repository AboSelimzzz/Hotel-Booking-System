namespace SWE_Project
{
    partial class Form4
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
            this.Employees = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.Apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(79, 42);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(102, 35);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Rooms
            // 
            this.Rooms.Location = new System.Drawing.Point(361, 42);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(80, 35);
            this.Rooms.TabIndex = 1;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // Reports
            // 
            this.Reports.Location = new System.Drawing.Point(622, 48);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(87, 29);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 554);
            this.dataGridView1.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(366, 100);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 38);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Suite"});
            this.checkedListBox1.Location = new System.Drawing.Point(764, 201);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 96);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.Visible = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.checkedListBox2.Location = new System.Drawing.Point(764, 316);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 50);
            this.checkedListBox2.TabIndex = 6;
            this.checkedListBox2.Visible = false;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(779, 398);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 34);
            this.Apply.TabIndex = 7;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Visible = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 699);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Employees);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button Apply;
    }
}