namespace CourseProject2
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(179, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 93);
            this.panel1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Tan;
            this.textBox3.Location = new System.Drawing.Point(21, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Регистрация";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Sienna;
            this.buttonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClear.BackgroundImage")));
            this.buttonClear.Location = new System.Drawing.Point(263, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(71, 70);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(41, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.Tan;
            this.textBox_login.Location = new System.Drawing.Point(179, 171);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(205, 22);
            this.textBox_login.TabIndex = 11;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Tan;
            this.textBox_password.Location = new System.Drawing.Point(179, 232);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(205, 22);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password2_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonEnter.Location = new System.Drawing.Point(179, 292);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(200, 60);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel.Location = new System.Drawing.Point(197, 377);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(175, 16);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Еще не создали аккаунт?";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "log_in";
            this.Text = "log_in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}