
namespace clinical_system_N
{
    partial class Add_Patient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ckFemale = new System.Windows.Forms.CheckBox();
            this.ckMale = new System.Windows.Forms.CheckBox();
            this.ckSingle = new System.Windows.Forms.CheckBox();
            this.ckDivorced = new System.Windows.Forms.CheckBox();
            this.ckMarried = new System.Windows.Forms.CheckBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.nationalID = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profession = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Admin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Calender = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_First_Name = new System.Windows.Forms.Label();
            this.label_Phone_Number = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Martrial_Status = new System.Windows.Forms.Label();
            this.label_Date_Of_Birth = new System.Windows.Forms.Label();
            this.label_Last_Name = new System.Windows.Forms.Label();
            this.label_National_ID = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Blood_Type = new System.Windows.Forms.Label();
            this.label_Patient_Employer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(157, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 84);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.Location = new System.Drawing.Point(429, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add New Patient";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(425, 354);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 60;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(267, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Date of Birth";
            // 
            // ckFemale
            // 
            this.ckFemale.AutoSize = true;
            this.ckFemale.Location = new System.Drawing.Point(1196, 313);
            this.ckFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckFemale.Name = "ckFemale";
            this.ckFemale.Size = new System.Drawing.Size(76, 21);
            this.ckFemale.TabIndex = 58;
            this.ckFemale.Text = "Female";
            this.ckFemale.UseVisualStyleBackColor = true;
            // 
            // ckMale
            // 
            this.ckMale.AutoSize = true;
            this.ckMale.Location = new System.Drawing.Point(1082, 313);
            this.ckMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckMale.Name = "ckMale";
            this.ckMale.Size = new System.Drawing.Size(60, 21);
            this.ckMale.TabIndex = 57;
            this.ckMale.Text = "Male";
            this.ckMale.UseVisualStyleBackColor = true;
            // 
            // ckSingle
            // 
            this.ckSingle.AutoSize = true;
            this.ckSingle.Location = new System.Drawing.Point(543, 310);
            this.ckSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckSingle.Name = "ckSingle";
            this.ckSingle.Size = new System.Drawing.Size(69, 21);
            this.ckSingle.TabIndex = 56;
            this.ckSingle.Text = "Single";
            this.ckSingle.UseVisualStyleBackColor = true;
            // 
            // ckDivorced
            // 
            this.ckDivorced.AutoSize = true;
            this.ckDivorced.Location = new System.Drawing.Point(633, 310);
            this.ckDivorced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckDivorced.Name = "ckDivorced";
            this.ckDivorced.Size = new System.Drawing.Size(86, 21);
            this.ckDivorced.TabIndex = 55;
            this.ckDivorced.Text = "Divorced";
            this.ckDivorced.UseVisualStyleBackColor = true;
            // 
            // ckMarried
            // 
            this.ckMarried.AutoSize = true;
            this.ckMarried.Location = new System.Drawing.Point(425, 310);
            this.ckMarried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckMarried.Name = "ckMarried";
            this.ckMarried.Size = new System.Drawing.Size(78, 21);
            this.ckMarried.TabIndex = 54;
            this.ckMarried.Text = "Married";
            this.ckMarried.UseVisualStyleBackColor = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(472, 166);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(180, 22);
            this.phoneNumber.TabIndex = 53;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(472, 214);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(180, 22);
            this.email.TabIndex = 52;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(472, 262);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(180, 22);
            this.address.TabIndex = 51;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(1076, 117);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 22);
            this.lastName.TabIndex = 50;
            // 
            // nationalID
            // 
            this.nationalID.Location = new System.Drawing.Point(1076, 169);
            this.nationalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nationalID.Name = "nationalID";
            this.nationalID.Size = new System.Drawing.Size(180, 22);
            this.nationalID.TabIndex = 49;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(1076, 214);
            this.city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(180, 22);
            this.city.TabIndex = 48;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(472, 114);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 22);
            this.firstName.TabIndex = 47;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(259, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(259, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 28);
            this.label10.TabIndex = 45;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(259, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(259, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 28);
            this.label8.TabIndex = 43;
            this.label8.Text = "Martrial Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(859, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(859, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "National ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(859, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(859, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(259, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "First Name";
            // 
            // profession
            // 
            this.profession.Location = new System.Drawing.Point(1076, 262);
            this.profession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(180, 22);
            this.profession.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(859, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 28);
            this.label15.TabIndex = 61;
            this.label15.Text = "Profession";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1167, 425);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 30);
            this.button7.TabIndex = 68;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1040, 425);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 30);
            this.button6.TabIndex = 69;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.panel5.Controls.Add(this.Admin);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.Calender);
            this.panel5.Location = new System.Drawing.Point(0, 122);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 690);
            this.panel5.TabIndex = 107;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Admin.Location = new System.Drawing.Point(19, 181);
            this.Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(103, 25);
            this.Admin.TabIndex = 108;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(19, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 109;
            this.button1.Text = "Finance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(19, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 110;
            this.button2.Text = "Records";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calender
            // 
            this.Calender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Calender.Location = new System.Drawing.Point(19, 30);
            this.Calender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calender.Name = "Calender";
            this.Calender.Size = new System.Drawing.Size(103, 25);
            this.Calender.TabIndex = 0;
            this.Calender.Text = "Calender";
            this.Calender.UseVisualStyleBackColor = false;
            this.Calender.Click += new System.EventHandler(this.Calender_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // label_First_Name
            // 
            this.label_First_Name.AutoSize = true;
            this.label_First_Name.Location = new System.Drawing.Point(512, 145);
            this.label_First_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_First_Name.Name = "label_First_Name";
            this.label_First_Name.Size = new System.Drawing.Size(0, 17);
            this.label_First_Name.TabIndex = 131;
            // 
            // label_Phone_Number
            // 
            this.label_Phone_Number.AutoSize = true;
            this.label_Phone_Number.Location = new System.Drawing.Point(512, 194);
            this.label_Phone_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Phone_Number.Name = "label_Phone_Number";
            this.label_Phone_Number.Size = new System.Drawing.Size(0, 17);
            this.label_Phone_Number.TabIndex = 132;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(512, 244);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(0, 17);
            this.label_Email.TabIndex = 133;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(512, 292);
            this.label_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(0, 17);
            this.label_Address.TabIndex = 134;
            // 
            // label_Martrial_Status
            // 
            this.label_Martrial_Status.AutoSize = true;
            this.label_Martrial_Status.Location = new System.Drawing.Point(512, 337);
            this.label_Martrial_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Martrial_Status.Name = "label_Martrial_Status";
            this.label_Martrial_Status.Size = new System.Drawing.Size(0, 17);
            this.label_Martrial_Status.TabIndex = 135;
            // 
            // label_Date_Of_Birth
            // 
            this.label_Date_Of_Birth.AutoSize = true;
            this.label_Date_Of_Birth.Location = new System.Drawing.Point(512, 388);
            this.label_Date_Of_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Date_Of_Birth.Name = "label_Date_Of_Birth";
            this.label_Date_Of_Birth.Size = new System.Drawing.Size(0, 17);
            this.label_Date_Of_Birth.TabIndex = 136;
            // 
            // label_Last_Name
            // 
            this.label_Last_Name.AutoSize = true;
            this.label_Last_Name.Location = new System.Drawing.Point(1117, 148);
            this.label_Last_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Last_Name.Name = "label_Last_Name";
            this.label_Last_Name.Size = new System.Drawing.Size(0, 17);
            this.label_Last_Name.TabIndex = 137;
            // 
            // label_National_ID
            // 
            this.label_National_ID.AutoSize = true;
            this.label_National_ID.Location = new System.Drawing.Point(1117, 199);
            this.label_National_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_National_ID.Name = "label_National_ID";
            this.label_National_ID.Size = new System.Drawing.Size(0, 17);
            this.label_National_ID.TabIndex = 138;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(1117, 247);
            this.label_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(0, 17);
            this.label_City.TabIndex = 139;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(1117, 353);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(0, 17);
            this.label_Gender.TabIndex = 140;
            // 
            // label_Blood_Type
            // 
            this.label_Blood_Type.AutoSize = true;
            this.label_Blood_Type.Location = new System.Drawing.Point(1117, 404);
            this.label_Blood_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Blood_Type.Name = "label_Blood_Type";
            this.label_Blood_Type.Size = new System.Drawing.Size(0, 17);
            this.label_Blood_Type.TabIndex = 141;
            // 
            // label_Patient_Employer
            // 
            this.label_Patient_Employer.AutoSize = true;
            this.label_Patient_Employer.Location = new System.Drawing.Point(1172, 308);
            this.label_Patient_Employer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Patient_Employer.Name = "label_Patient_Employer";
            this.label_Patient_Employer.Size = new System.Drawing.Size(0, 17);
            this.label_Patient_Employer.TabIndex = 142;
            // 
            // Add_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1459, 811);
            this.Controls.Add(this.label_Patient_Employer);
            this.Controls.Add(this.label_Blood_Type);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_National_ID);
            this.Controls.Add(this.label_Last_Name);
            this.Controls.Add(this.label_Date_Of_Birth);
            this.Controls.Add(this.label_Martrial_Status);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Phone_Number);
            this.Controls.Add(this.label_First_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.profession);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckFemale);
            this.Controls.Add(this.ckMale);
            this.Controls.Add(this.ckSingle);
            this.Controls.Add(this.ckDivorced);
            this.Controls.Add(this.ckMarried);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.nationalID);
            this.Controls.Add(this.city);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(16, 358);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Patient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckFemale;
        private System.Windows.Forms.CheckBox ckMale;
        private System.Windows.Forms.CheckBox ckSingle;
        private System.Windows.Forms.CheckBox ckDivorced;
        private System.Windows.Forms.CheckBox ckMarried;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox nationalID;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profession;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Calender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_First_Name;
        private System.Windows.Forms.Label label_Phone_Number;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Martrial_Status;
        private System.Windows.Forms.Label label_Date_Of_Birth;
        private System.Windows.Forms.Label label_Last_Name;
        private System.Windows.Forms.Label label_National_ID;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Blood_Type;
        private System.Windows.Forms.Label label_Patient_Employer;
    }
}

