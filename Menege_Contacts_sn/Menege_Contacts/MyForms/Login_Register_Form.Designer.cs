namespace Menege_Contacts.NewFolder1
{
    partial class Login_Register_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_register = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_profile_img = new System.Windows.Forms.PictureBox();
            this.textBox_passw_register = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_usrn_register = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_lastn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_firstn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_pssw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_usrn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close_login = new System.Windows.Forms.Button();
            this.button_min_login = new System.Windows.Forms.Button();
            this.label_GoRegister = new System.Windows.Forms.Label();
            this.label_GoLogin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button_min_login);
            this.panel1.Controls.Add(this.button_Close_login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_GoLogin);
            this.panel2.Controls.Add(this.label_GoRegister);
            this.panel2.Controls.Add(this.button_register);
            this.panel2.Controls.Add(this.button_browse);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox_profile_img);
            this.panel2.Controls.Add(this.textBox_passw_register);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_usrn_register);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_lastn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_firstn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_login);
            this.panel2.Controls.Add(this.textBox_pssw);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_usrn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 628);
            this.panel2.TabIndex = 0;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(555, 525);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(215, 39);
            this.button_register.TabIndex = 18;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_browse
            // 
            this.button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.Location = new System.Drawing.Point(791, 386);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(31, 112);
            this.button_browse.TabIndex = 17;
            this.button_browse.Text = "///";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(509, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Picture:";
            // 
            // pictureBox_profile_img
            // 
            this.pictureBox_profile_img.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox_profile_img.Location = new System.Drawing.Point(617, 386);
            this.pictureBox_profile_img.Name = "pictureBox_profile_img";
            this.pictureBox_profile_img.Size = new System.Drawing.Size(153, 112);
            this.pictureBox_profile_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile_img.TabIndex = 15;
            this.pictureBox_profile_img.TabStop = false;
            // 
            // textBox_passw_register
            // 
            this.textBox_passw_register.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_passw_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passw_register.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_passw_register.Location = new System.Drawing.Point(617, 325);
            this.textBox_passw_register.Name = "textBox_passw_register";
            this.textBox_passw_register.Size = new System.Drawing.Size(205, 34);
            this.textBox_passw_register.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(476, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password:";
            // 
            // textBox_usrn_register
            // 
            this.textBox_usrn_register.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_usrn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usrn_register.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_usrn_register.Location = new System.Drawing.Point(617, 257);
            this.textBox_usrn_register.Name = "textBox_usrn_register";
            this.textBox_usrn_register.Size = new System.Drawing.Size(205, 34);
            this.textBox_usrn_register.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(472, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Username:";
            // 
            // textBox_lastn
            // 
            this.textBox_lastn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_lastn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_lastn.Location = new System.Drawing.Point(617, 191);
            this.textBox_lastn.Name = "textBox_lastn";
            this.textBox_lastn.Size = new System.Drawing.Size(205, 34);
            this.textBox_lastn.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(467, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name:";
            // 
            // textBox_firstn
            // 
            this.textBox_firstn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_firstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_firstn.Location = new System.Drawing.Point(617, 123);
            this.textBox_firstn.Name = "textBox_firstn";
            this.textBox_firstn.Size = new System.Drawing.Size(205, 34);
            this.textBox_firstn.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(463, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "First Name:";
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(120, 272);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(215, 39);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_pssw
            // 
            this.textBox_pssw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_pssw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pssw.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_pssw.Location = new System.Drawing.Point(190, 194);
            this.textBox_pssw.Name = "textBox_pssw";
            this.textBox_pssw.Size = new System.Drawing.Size(205, 34);
            this.textBox_pssw.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(49, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // textBox_usrn
            // 
            this.textBox_usrn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_usrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usrn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_usrn.Location = new System.Drawing.Point(190, 126);
            this.textBox_usrn.Name = "textBox_usrn";
            this.textBox_usrn.Size = new System.Drawing.Size(205, 34);
            this.textBox_usrn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(45, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(487, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create New Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(114, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Login";
            // 
            // button_Close_login
            // 
            this.button_Close_login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Close_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close_login.Location = new System.Drawing.Point(320, 6);
            this.button_Close_login.Name = "button_Close_login";
            this.button_Close_login.Size = new System.Drawing.Size(75, 36);
            this.button_Close_login.TabIndex = 1;
            this.button_Close_login.Text = "x";
            this.button_Close_login.UseVisualStyleBackColor = false;
            this.button_Close_login.Click += new System.EventHandler(this.button_Close_login_Click);
            // 
            // button_min_login
            // 
            this.button_min_login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_min_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_min_login.Location = new System.Drawing.Point(239, 6);
            this.button_min_login.Name = "button_min_login";
            this.button_min_login.Size = new System.Drawing.Size(75, 36);
            this.button_min_login.TabIndex = 2;
            this.button_min_login.Text = "-";
            this.button_min_login.UseVisualStyleBackColor = false;
            this.button_min_login.Click += new System.EventHandler(this.button_min_login_Click);
            // 
            // label_GoRegister
            // 
            this.label_GoRegister.AutoSize = true;
            this.label_GoRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_GoRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.label_GoRegister.Location = new System.Drawing.Point(45, 577);
            this.label_GoRegister.Name = "label_GoRegister";
            this.label_GoRegister.Size = new System.Drawing.Size(349, 25);
            this.label_GoRegister.TabIndex = 19;
            this.label_GoRegister.Text = "Don\'t have an account yet? Sign up >>";
            this.label_GoRegister.Click += new System.EventHandler(this.label_GoRegister_Click);
            // 
            // label_GoLogin
            // 
            this.label_GoLogin.AutoSize = true;
            this.label_GoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_GoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GoLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.label_GoLogin.Location = new System.Drawing.Point(472, 577);
            this.label_GoLogin.Name = "label_GoLogin";
            this.label_GoLogin.Size = new System.Drawing.Size(288, 25);
            this.label_GoLogin.TabIndex = 20;
            this.label_GoLogin.Text = "<< Have an account yet? Log in";
            this.label_GoLogin.Click += new System.EventHandler(this.label_GoLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Login_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 676);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Register_Form";
            this.Text = "Login_Register_Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_profile_img;
        private System.Windows.Forms.TextBox textBox_passw_register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_usrn_register;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_lastn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_firstn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_pssw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_usrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_min_login;
        private System.Windows.Forms.Button button_Close_login;
        private System.Windows.Forms.Label label_GoLogin;
        private System.Windows.Forms.Label label_GoRegister;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}