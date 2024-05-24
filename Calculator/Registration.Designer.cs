namespace Calculator
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registration_Form = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Register = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Policy = new System.Windows.Forms.CheckBox();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Registration_Form);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-28, -40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 117);
            this.panel1.TabIndex = 0;
            // 
            // Registration_Form
            // 
            this.Registration_Form.AutoSize = true;
            this.Registration_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Form.Location = new System.Drawing.Point(185, 67);
            this.Registration_Form.Name = "Registration_Form";
            this.Registration_Form.Size = new System.Drawing.Size(222, 29);
            this.Registration_Form.TabIndex = 11;
            this.Registration_Form.Text = "Registration Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Register);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lable2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Policy);
            this.panel2.Controls.Add(this.CPassword);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.Name);
            this.panel2.Location = new System.Drawing.Point(-25, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 547);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.SteelBlue;
            this.Clear.ForeColor = System.Drawing.Color.Cornsilk;
            this.Clear.Location = new System.Drawing.Point(422, 453);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(51, 24);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(220, 501);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.SteelBlue;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Register.Location = new System.Drawing.Point(199, 423);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(191, 54);
            this.Register.TabIndex = 11;
            this.Register.Text = "REGISTER";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(128, 105);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(46, 16);
            this.lable2.TabIndex = 7;
            this.lable2.Tag = "Email";
            this.lable2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Policy
            // 
            this.Policy.AutoSize = true;
            this.Policy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Policy.Location = new System.Drawing.Point(128, 385);
            this.Policy.Name = "Policy";
            this.Policy.Size = new System.Drawing.Size(262, 20);
            this.Policy.TabIndex = 5;
            this.Policy.Text = "You agree to the protection policy";
            this.Policy.UseVisualStyleBackColor = true;
            this.Policy.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CPassword
            // 
            this.CPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.CPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPassword.Location = new System.Drawing.Point(128, 320);
            this.CPassword.Multiline = true;
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordChar = '*';
            this.CPassword.Size = new System.Drawing.Size(345, 40);
            this.CPassword.TabIndex = 4;
            this.CPassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Gainsboro;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(128, 258);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = 'y';
            this.Password.Size = new System.Drawing.Size(345, 40);
            this.Password.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(128, 192);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(345, 40);
            this.Username.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Gainsboro;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(128, 121);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(345, 40);
            this.Email.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.Gainsboro;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(128, 62);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(345, 40);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.CheckBox Policy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Registration_Form;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Register;
    }
}