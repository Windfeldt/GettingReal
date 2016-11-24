namespace GettingReal
{
    partial class Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.registereName = new System.Windows.Forms.TextBox();
            this.registereUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loginEnter);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.loginPassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.loginUserName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loginEnter
            // 
            this.loginEnter.Location = new System.Drawing.Point(105, 182);
            this.loginEnter.Name = "loginEnter";
            this.loginEnter.Size = new System.Drawing.Size(75, 23);
            this.loginEnter.TabIndex = 18;
            this.loginEnter.Text = "Enter";
            this.loginEnter.UseVisualStyleBackColor = true;
            this.loginEnter.Click += new System.EventHandler(this.loginEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kode";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(75, 131);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(140, 20);
            this.loginPassword.TabIndex = 16;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brugernavn";
            // 
            // loginUserName
            // 
            this.loginUserName.Location = new System.Drawing.Point(75, 91);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(140, 20);
            this.loginUserName.TabIndex = 14;
            this.loginUserName.TextChanged += new System.EventHandler(this.loginUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.registereUser);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.confirmPassword);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.userName);
            this.tabPage2.Controls.Add(this.registereName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ny bruger";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bekræft password:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(118, 142);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.confirmPassword.TabIndex = 15;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Registere ny bruger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bruger navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Navn:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(118, 116);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(118, 90);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // registereName
            // 
            this.registereName.Location = new System.Drawing.Point(118, 64);
            this.registereName.Name = "registereName";
            this.registereName.Size = new System.Drawing.Size(100, 20);
            this.registereName.TabIndex = 0;
            this.registereName.TextChanged += new System.EventHandler(this.registereName_TextChanged);
            // 
            // registereUser
            // 
            this.registereUser.Location = new System.Drawing.Point(94, 177);
            this.registereUser.Name = "registereUser";
            this.registereUser.Size = new System.Drawing.Size(93, 27);
            this.registereUser.TabIndex = 17;
            this.registereUser.Text = "Registere";
            this.registereUser.UseVisualStyleBackColor = true;
            this.registereUser.Click += new System.EventHandler(this.registereUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button loginEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox registereName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button registereUser;
    }
}