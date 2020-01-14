namespace Menege_Contacts
{
    partial class Form1
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
            this.button_min_login = new System.Windows.Forms.Button();
            this.button_Close_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_curent_username = new System.Windows.Forms.Label();
            this.label_Edit_Info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label_Edit_Info);
            this.panel1.Controls.Add(this.label_curent_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_min_login);
            this.panel1.Controls.Add(this.button_Close_login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 663);
            this.panel1.TabIndex = 1;
            // 
            // button_min_login
            // 
            this.button_min_login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_min_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_min_login.Location = new System.Drawing.Point(832, 12);
            this.button_min_login.Name = "button_min_login";
            this.button_min_login.Size = new System.Drawing.Size(75, 36);
            this.button_min_login.TabIndex = 2;
            this.button_min_login.Text = "-";
            this.button_min_login.UseVisualStyleBackColor = false;
            this.button_min_login.Click += new System.EventHandler(this.button_min_login_Click);
            // 
            // button_Close_login
            // 
            this.button_Close_login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Close_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close_login.Location = new System.Drawing.Point(913, 12);
            this.button_Close_login.Name = "button_Close_login";
            this.button_Close_login.Size = new System.Drawing.Size(75, 36);
            this.button_Close_login.TabIndex = 1;
            this.button_Close_login.Text = "x";
            this.button_Close_login.UseVisualStyleBackColor = false;
            this.button_Close_login.Click += new System.EventHandler(this.button_Close_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 598);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_curent_username
            // 
            this.label_curent_username.AutoSize = true;
            this.label_curent_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_curent_username.Location = new System.Drawing.Point(128, 9);
            this.label_curent_username.Name = "label_curent_username";
            this.label_curent_username.Size = new System.Drawing.Size(199, 25);
            this.label_curent_username.TabIndex = 3;
            this.label_curent_username.Text = "Welcome(Username)";
            // 
            // label_Edit_Info
            // 
            this.label_Edit_Info.AutoSize = true;
            this.label_Edit_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Edit_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit_Info.Location = new System.Drawing.Point(129, 39);
            this.label_Edit_Info.Name = "label_Edit_Info";
            this.label_Edit_Info.Size = new System.Drawing.Size(97, 20);
            this.label_Edit_Info.TabIndex = 0;
            this.label_Edit_Info.Text = "Edit My Info";
            this.label_Edit_Info.Click += new System.EventHandler(this.label_Edit_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 663);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_min_login;
        private System.Windows.Forms.Button button_Close_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_curent_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Edit_Info;
    }
}

