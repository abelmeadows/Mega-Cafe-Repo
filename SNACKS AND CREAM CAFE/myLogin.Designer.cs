namespace SNACKS_AND_CREAM_CAFE
{
    partial class myLogin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.PsWrd = new System.Windows.Forms.Label();
            this.UsrName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Banner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SNACKS_AND_CREAM_CAFE.Properties.Resources.Login_Image2;
            this.pictureBox2.Location = new System.Drawing.Point(655, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SNACKS_AND_CREAM_CAFE.Properties.Resources.Login_Image;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginBtn);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.textPass);
            this.groupBox1.Controls.Add(this.PsWrd);
            this.groupBox1.Controls.Add(this.UsrName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(326, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Here";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(101, 128);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 11;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelBtn.Location = new System.Drawing.Point(182, 128);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.Gold;
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(90, 36);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(180, 30);
            this.textUser.TabIndex = 9;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.Gold;
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(90, 75);
            this.textPass.Multiline = true;
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '^';
            this.textPass.Size = new System.Drawing.Size(180, 30);
            this.textPass.TabIndex = 8;
            // 
            // PsWrd
            // 
            this.PsWrd.AutoSize = true;
            this.PsWrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PsWrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PsWrd.Location = new System.Drawing.Point(15, 81);
            this.PsWrd.Name = "PsWrd";
            this.PsWrd.Size = new System.Drawing.Size(69, 17);
            this.PsWrd.TabIndex = 7;
            this.PsWrd.Text = "Password";
            // 
            // UsrName
            // 
            this.UsrName.AutoSize = true;
            this.UsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsrName.Location = new System.Drawing.Point(11, 42);
            this.UsrName.Name = "UsrName";
            this.UsrName.Size = new System.Drawing.Size(73, 17);
            this.UsrName.TabIndex = 6;
            this.UsrName.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(442, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Banner.Location = new System.Drawing.Point(413, 108);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(0, 17);
            this.Banner.TabIndex = 13;
            // 
            // myLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myLogin";
            this.Load += new System.EventHandler(this.myLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label PsWrd;
        private System.Windows.Forms.Label UsrName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Banner;
    }
}