namespace SNACKS_AND_CREAM_CAFE
{
    partial class Options
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageLabel = new System.Windows.Forms.Label();
            this.OptionsCloseBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ManagePicture = new System.Windows.Forms.PictureBox();
            this.SupplyPicture = new System.Windows.Forms.PictureBox();
            this.OrderPicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserBanner = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(343, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TAKE ORDER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(614, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "RECEIVE SUPPLY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageLabel
            // 
            this.ManageLabel.AutoSize = true;
            this.ManageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ManageLabel.Location = new System.Drawing.Point(923, 475);
            this.ManageLabel.Name = "ManageLabel";
            this.ManageLabel.Size = new System.Drawing.Size(67, 17);
            this.ManageLabel.TabIndex = 7;
            this.ManageLabel.Text = "MANAGE";
            this.ManageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // OptionsCloseBtn
            // 
            this.OptionsCloseBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.OptionsCloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OptionsCloseBtn.Location = new System.Drawing.Point(736, 576);
            this.OptionsCloseBtn.Name = "OptionsCloseBtn";
            this.OptionsCloseBtn.Size = new System.Drawing.Size(92, 23);
            this.OptionsCloseBtn.TabIndex = 9;
            this.OptionsCloseBtn.Text = "Close";
            this.OptionsCloseBtn.UseVisualStyleBackColor = false;
            this.OptionsCloseBtn.Click += new System.EventHandler(this.OptionsCloseBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Gold;
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOutBtn.Location = new System.Drawing.Point(552, 576);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(92, 23);
            this.LogOutBtn.TabIndex = 10;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManagePicture
            // 
            this.ManagePicture.Image = global::SNACKS_AND_CREAM_CAFE.Properties.Resources.N27Ksupervisor_icon;
            this.ManagePicture.Location = new System.Drawing.Point(865, 292);
            this.ManagePicture.Name = "ManagePicture";
            this.ManagePicture.Size = new System.Drawing.Size(180, 180);
            this.ManagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManagePicture.TabIndex = 2;
            this.ManagePicture.TabStop = false;
            this.ManagePicture.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // SupplyPicture
            // 
            this.SupplyPicture.Image = global::SNACKS_AND_CREAM_CAFE.Properties.Resources.database_development_icon;
            this.SupplyPicture.Location = new System.Drawing.Point(586, 292);
            this.SupplyPicture.Name = "SupplyPicture";
            this.SupplyPicture.Size = new System.Drawing.Size(180, 180);
            this.SupplyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupplyPicture.TabIndex = 1;
            this.SupplyPicture.TabStop = false;
            this.SupplyPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // OrderPicture
            // 
            this.OrderPicture.Image = global::SNACKS_AND_CREAM_CAFE.Properties.Resources.pos_terminal1600;
            this.OrderPicture.Location = new System.Drawing.Point(306, 292);
            this.OrderPicture.Name = "OrderPicture";
            this.OrderPicture.Size = new System.Drawing.Size(180, 180);
            this.OrderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrderPicture.TabIndex = 0;
            this.OrderPicture.TabStop = false;
            this.OrderPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 12;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "User: ";
            // 
            // UserBanner
            // 
            this.UserBanner.AutoSize = true;
            this.UserBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBanner.Location = new System.Drawing.Point(344, 216);
            this.UserBanner.Name = "UserBanner";
            this.UserBanner.Size = new System.Drawing.Size(0, 17);
            this.UserBanner.TabIndex = 14;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("ShoCard Caps NF", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label100.Location = new System.Drawing.Point(400, 32);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(636, 77);
            this.label100.TabIndex = 25;
            this.label100.Text = "MEGA CREAM CAFE";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.UserBanner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.OptionsCloseBtn);
            this.Controls.Add(this.ManageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManagePicture);
            this.Controls.Add(this.SupplyPicture);
            this.Controls.Add(this.OrderPicture);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OrderPicture;
        private System.Windows.Forms.PictureBox SupplyPicture;
        private System.Windows.Forms.PictureBox ManagePicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ManageLabel;
        private System.Windows.Forms.Button OptionsCloseBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserBanner;
        private System.Windows.Forms.Label label100;
    }
}