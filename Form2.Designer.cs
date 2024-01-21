namespace Skills_International
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_register = new Button();
            groupBox4 = new GroupBox();
            txt_pphone = new TextBox();
            txt_nic = new TextBox();
            txt_parentName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            txt_hphone = new TextBox();
            txt_mphone = new TextBox();
            txt_email = new TextBox();
            txt_address = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            date = new DateTimePicker();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lable_logout = new LinkLabel();
            lable_exit = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(174, 30);
            label1.Name = "label1";
            label1.Size = new Size(308, 45);
            label1.TabIndex = 2;
            label1.Text = "Skills International ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 90);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(680, 623);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 28);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.Location = new Point(452, 584);
            btn_clear.Margin = new Padding(3, 2, 3, 2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(82, 34);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(556, 584);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(82, 34);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(140, 584);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(82, 34);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.Location = new Point(44, 584);
            btn_register.Margin = new Padding(3, 2, 3, 2);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(91, 34);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_pphone);
            groupBox4.Controls.Add(txt_nic);
            groupBox4.Controls.Add(txt_parentName);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(44, 432);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(594, 140);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // txt_pphone
            // 
            txt_pphone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pphone.Location = new Point(144, 94);
            txt_pphone.Margin = new Padding(3, 2, 3, 2);
            txt_pphone.Name = "txt_pphone";
            txt_pphone.Size = new Size(142, 26);
            txt_pphone.TabIndex = 9;
            // 
            // txt_nic
            // 
            txt_nic.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nic.Location = new Point(144, 59);
            txt_nic.Margin = new Padding(3, 2, 3, 2);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(344, 26);
            txt_nic.TabIndex = 8;
            // 
            // txt_parentName
            // 
            txt_parentName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_parentName.Location = new Point(143, 24);
            txt_parentName.Margin = new Padding(3, 2, 3, 2);
            txt_parentName.Name = "txt_parentName";
            txt_parentName.Size = new Size(344, 26);
            txt_parentName.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(10, 96);
            label13.Name = "label13";
            label13.Size = new Size(119, 19);
            label13.TabIndex = 5;
            label13.Text = "Contact Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(14, 62);
            label12.Name = "label12";
            label12.Size = new Size(33, 19);
            label12.TabIndex = 4;
            label12.Text = "NIC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 29);
            label11.Name = "label11";
            label11.Size = new Size(97, 19);
            label11.TabIndex = 3;
            label11.Text = "Parent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_hphone);
            groupBox3.Controls.Add(txt_mphone);
            groupBox3.Controls.Add(txt_email);
            groupBox3.Controls.Add(txt_address);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(44, 256);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(594, 172);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txt_hphone
            // 
            txt_hphone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_hphone.Location = new Point(382, 127);
            txt_hphone.Margin = new Padding(3, 2, 3, 2);
            txt_hphone.Name = "txt_hphone";
            txt_hphone.Size = new Size(110, 26);
            txt_hphone.TabIndex = 8;
            // 
            // txt_mphone
            // 
            txt_mphone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mphone.Location = new Point(147, 127);
            txt_mphone.Margin = new Padding(3, 2, 3, 2);
            txt_mphone.Name = "txt_mphone";
            txt_mphone.Size = new Size(114, 26);
            txt_mphone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_email.Location = new Point(147, 88);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(344, 26);
            txt_email.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_address.Location = new Point(147, 29);
            txt_address.Margin = new Padding(3, 2, 3, 2);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(344, 46);
            txt_address.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(278, 132);
            label10.Name = "label10";
            label10.Size = new Size(96, 19);
            label10.TabIndex = 4;
            label10.Text = "Home Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 132);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 3;
            label9.Text = "Mobile Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 91);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 2;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 41);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 1;
            label7.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(txt_lname);
            groupBox2.Controls.Add(txt_fname);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(44, 53);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(595, 198);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(408, 160);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(168, 160);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            date.Cursor = Cursors.Hand;
            date.CustomFormat = "dd-MM-yyyy";
            date.Format = DateTimePickerFormat.Custom;
            date.Location = new Point(168, 110);
            date.Margin = new Padding(3, 2, 3, 2);
            date.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(219, 23);
            date.TabIndex = 6;
            date.Value = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_lname.Location = new Point(168, 70);
            txt_lname.Margin = new Padding(3, 2, 3, 2);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(310, 26);
            txt_lname.TabIndex = 5;
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_fname.Location = new Point(168, 32);
            txt_fname.Margin = new Padding(3, 2, 3, 2);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(310, 26);
            txt_fname.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 160);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 113);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 2;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 72);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 38);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 0;
            label2.Text = "Reg No";
            // 
            // lable_logout
            // 
            lable_logout.AutoSize = true;
            lable_logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lable_logout.Location = new Point(29, 23);
            lable_logout.Name = "lable_logout";
            lable_logout.Size = new Size(56, 19);
            lable_logout.TabIndex = 4;
            lable_logout.TabStop = true;
            lable_logout.Text = "Logout";
            lable_logout.LinkClicked += lable_logout_LinkClicked;
            // 
            // lable_exit
            // 
            lable_exit.AutoSize = true;
            lable_exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lable_exit.Location = new Point(667, 716);
            lable_exit.Name = "lable_exit";
            lable_exit.Size = new Size(33, 19);
            lable_exit.TabIndex = 5;
            lable_exit.TabStop = true;
            lable_exit.Text = "Exit";
            lable_exit.LinkClicked += lable_exit_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 748);
            Controls.Add(lable_exit);
            Controls.Add(lable_logout);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student registration - Skills International";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_lname;
        private TextBox txt_fname;
        private DateTimePicker date;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox3;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox txt_hphone;
        private TextBox txt_mphone;
        private TextBox txt_email;
        private TextBox txt_address;
        private GroupBox groupBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txt_pphone;
        private TextBox txt_nic;
        private TextBox txt_parentName;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_register;
        private LinkLabel lable_logout;
        private LinkLabel lable_exit;
        private ComboBox comboBox1;
    }
}