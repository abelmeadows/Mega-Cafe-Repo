namespace SNACKS_AND_CREAM_CAFE
{
    partial class SalesReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalSales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSelectCategory = new System.Windows.Forms.Label();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.labelAttendantName = new System.Windows.Forms.Label();
            this.comboBoxAttendantName = new System.Windows.Forms.ComboBox();
            this.labelSelectProduct = new System.Windows.Forms.Label();
            this.comboBoxSelectProduct = new System.Windows.Forms.ComboBox();
            this.SalesTotal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction Report";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Product Category",
            "Product",
            "Attendant Clark"});
            this.comboBox1.Location = new System.Drawing.Point(288, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(336, 144);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Report type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTotalSales
            // 
            this.textBoxTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalSales.Location = new System.Drawing.Point(512, 512);
            this.textBoxTotalSales.Multiline = true;
            this.textBoxTotalSales.Name = "textBoxTotalSales";
            this.textBoxTotalSales.Size = new System.Drawing.Size(152, 32);
            this.textBoxTotalSales.TabIndex = 8;
            this.textBoxTotalSales.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL FOR SELECTED PERIOD";
            // 
            // labelSelectCategory
            // 
            this.labelSelectCategory.AutoSize = true;
            this.labelSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCategory.Location = new System.Drawing.Point(144, 112);
            this.labelSelectCategory.Name = "labelSelectCategory";
            this.labelSelectCategory.Size = new System.Drawing.Size(139, 15);
            this.labelSelectCategory.TabIndex = 11;
            this.labelSelectCategory.Text = "Select Item Category";
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Items.AddRange(new object[] {
            "Soda",
            "Ice Cream",
            "Coffee",
            "Snacks"});
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(288, 112);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(192, 21);
            this.comboBoxSelectCategory.TabIndex = 10;
            this.comboBoxSelectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCategory_SelectedIndexChanged);
            // 
            // labelAttendantName
            // 
            this.labelAttendantName.AutoSize = true;
            this.labelAttendantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttendantName.Location = new System.Drawing.Point(144, 112);
            this.labelAttendantName.Name = "labelAttendantName";
            this.labelAttendantName.Size = new System.Drawing.Size(153, 15);
            this.labelAttendantName.TabIndex = 13;
            this.labelAttendantName.Text = "Select Attendant Name";
            // 
            // comboBoxAttendantName
            // 
            this.comboBoxAttendantName.BackColor = System.Drawing.Color.Chartreuse;
            this.comboBoxAttendantName.FormattingEnabled = true;
            this.comboBoxAttendantName.Items.AddRange(new object[] {
            "Item Category",
            "Item",
            "Attendant Clark"});
            this.comboBoxAttendantName.Location = new System.Drawing.Point(300, 110);
            this.comboBoxAttendantName.Name = "comboBoxAttendantName";
            this.comboBoxAttendantName.Size = new System.Drawing.Size(192, 21);
            this.comboBoxAttendantName.TabIndex = 12;
            this.comboBoxAttendantName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttendantName_SelectedIndexChanged);
            // 
            // labelSelectProduct
            // 
            this.labelSelectProduct.AutoSize = true;
            this.labelSelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectProduct.Location = new System.Drawing.Point(144, 112);
            this.labelSelectProduct.Name = "labelSelectProduct";
            this.labelSelectProduct.Size = new System.Drawing.Size(142, 15);
            this.labelSelectProduct.TabIndex = 15;
            this.labelSelectProduct.Text = "Select Product Name";
            // 
            // comboBoxSelectProduct
            // 
            this.comboBoxSelectProduct.BackColor = System.Drawing.Color.Gold;
            this.comboBoxSelectProduct.FormattingEnabled = true;
            this.comboBoxSelectProduct.Items.AddRange(new object[] {
            "Item Category",
            "Item",
            "Attendant Clark"});
            this.comboBoxSelectProduct.Location = new System.Drawing.Point(292, 110);
            this.comboBoxSelectProduct.Name = "comboBoxSelectProduct";
            this.comboBoxSelectProduct.Size = new System.Drawing.Size(192, 21);
            this.comboBoxSelectProduct.TabIndex = 14;
            this.comboBoxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProduct_SelectedIndexChanged);
            // 
            // SalesTotal
            // 
            this.SalesTotal.Location = new System.Drawing.Point(512, 480);
            this.SalesTotal.Name = "SalesTotal";
            this.SalesTotal.Size = new System.Drawing.Size(152, 23);
            this.SalesTotal.TabIndex = 16;
            this.SalesTotal.Text = "GetTotal";
            this.SalesTotal.UseVisualStyleBackColor = true;
            this.SalesTotal.Click += new System.EventHandler(this.SalesTotal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(272, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SalesTotal);
            this.Controls.Add(this.labelSelectProduct);
            this.Controls.Add(this.comboBoxSelectProduct);
            this.Controls.Add(this.labelAttendantName);
            this.Controls.Add(this.comboBoxAttendantName);
            this.Controls.Add(this.labelSelectCategory);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSelectCategory;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.Label labelAttendantName;
        private System.Windows.Forms.ComboBox comboBoxAttendantName;
        private System.Windows.Forms.Label labelSelectProduct;
        private System.Windows.Forms.ComboBox comboBoxSelectProduct;
        private System.Windows.Forms.Button SalesTotal;
        private System.Windows.Forms.Button button1;
    }
}