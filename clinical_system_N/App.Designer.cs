namespace clinical_system_N
{
    partial class App

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medical_Record = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Attended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel46.SuspendLayout();
            this.panel43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_AddPatient.Location = new System.Drawing.Point(1144, 22);
            this.btn_AddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(141, 30);
            this.btn_AddPatient.TabIndex = 1;
            this.btn_AddPatient.Text = "Add Appointments";
            this.btn_AddPatient.UseVisualStyleBackColor = false;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.label10.Location = new System.Drawing.Point(480, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 45);
            this.label10.TabIndex = 15;
            this.label10.Text = "Appointments";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel46
            // 
            this.panel46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.panel46.Controls.Add(this.btn_AddPatient);
            this.panel46.Controls.Add(this.label10);
            this.panel46.Location = new System.Drawing.Point(157, -1);
            this.panel46.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(1301, 84);
            this.panel46.TabIndex = 14;
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.panel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.button3);
            this.panel43.Controls.Add(this.button4);
            this.panel43.Controls.Add(this.button2);
            this.panel43.Controls.Add(this.button1);
            this.panel43.Location = new System.Drawing.Point(1, 120);
            this.panel43.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(151, 691);
            this.panel43.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(19, 226);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(19, 166);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Finance";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(19, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Records";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(19, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calendar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Phone,
            this.Email,
            this.Date,
            this.Start_Time,
            this.End_Time,
            this.Medical_Record,
            this.Attended});
            this.dataGridView1.Location = new System.Drawing.Point(157, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 705);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 155;
            // 
            // Phone
            // 
            this.Phone.FillWeight = 12F;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.FillWeight = 20F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Start_Time
            // 
            this.Start_Time.HeaderText = "Start_Time";
            this.Start_Time.MinimumWidth = 6;
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Width = 125;
            // 
            // End_Time
            // 
            this.End_Time.HeaderText = "End_Time";
            this.End_Time.MinimumWidth = 6;
            this.End_Time.Name = "End_Time";
            this.End_Time.Width = 125;
            // 
            // Medical_Record
            // 
            this.Medical_Record.HeaderText = "Medical_Record";
            this.Medical_Record.MinimumWidth = 6;
            this.Medical_Record.Name = "Medical_Record";
            this.Medical_Record.Text = "View MR";
            this.Medical_Record.UseColumnTextForButtonValue = true;
            this.Medical_Record.Width = 125;
            // 
            // Attended
            // 
            this.Attended.HeaderText = "Attended";
            this.Attended.MinimumWidth = 6;
            this.Attended.Name = "Attended";
            this.Attended.Width = 75;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 811);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel46);
            this.Controls.Add(this.panel43);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            this.panel43.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Time;
        private System.Windows.Forms.DataGridViewButtonColumn Medical_Record;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attended;
    }
}

