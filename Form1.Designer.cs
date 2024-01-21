namespace Skills_International
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_login = new Button();
            btn_clear = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 209);
            label1.Name = "label1";
            label1.Size = new Size(385, 54);
            label1.TabIndex = 1;
            label1.Text = "Skills International ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(130, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 305);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(393, 232);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 45);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.Location = new Point(24, 232);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 45);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(244, 147);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(243, 34);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(244, 62);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(243, 34);
            txt_username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 62);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.Location = new Point(30, 694);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 45);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 765);
            Controls.Add(btn_exit);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_username;
        private Label label3;
        private Label label2;
        private TextBox txt_password;
        private Button btn_clear;
        private Button btn_login;
        private Button btn_exit;
    }
}