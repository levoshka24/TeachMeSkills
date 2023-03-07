namespace CourseProject2
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(123, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 93);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_password2
            // 
            this.textBox_password2.BackColor = System.Drawing.Color.Tan;
            this.textBox_password2.Location = new System.Drawing.Point(144, 251);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(205, 22);
            this.textBox_password2.TabIndex = 2;
            this.textBox_password2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_login2
            // 
            this.textBox_login2.BackColor = System.Drawing.Color.Tan;
            this.textBox_login2.Location = new System.Drawing.Point(144, 192);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(205, 22);
            this.textBox_login2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.Color.BurlyWood;
            this.button_Create.Location = new System.Drawing.Point(144, 321);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(200, 60);
            this.button_Create.TabIndex = 6;
            this.button_Create.Text = "Создать аккаунт";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button1_Click);
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
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox3;
    }
}