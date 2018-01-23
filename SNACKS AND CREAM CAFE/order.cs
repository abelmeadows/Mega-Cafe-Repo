using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace SNACKS_AND_CREAM_CAFE
{
    public partial class order : Form
    {
        decimal TaxValue;
        decimal DirectDecimal;
        decimal LineTax;
        decimal sum;

        public order(string bannerNam)
        {
            InitializeComponent();
            OrderUserBanner.Text = bannerNam;
            GetDrinks();


        }

        MySqlConnection connect = new MySqlConnection("server =localhost; database = mega; username = root; password=;");

        void GetDrinks()
        {
            //MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            //string query = "select* from soda;";
            //MySqlCommand Combodata = new MySqlCommand(query,connect);
            //MySqlDataReader myreader;

            //try
            //{
            //    connect.Open();

            //    myreader = Combodata.ExecuteReader();

            //    while(myreader.Read())
            //    {
            //        string DrinkName = myreader.GetString("Item");
            //        comboBox1.Items.Add(DrinkName);

            //    }

            //    connect.Close();

            //}

            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void order_Load(object sender, EventArgs e)
        {
            ShowMyDateTime.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            numericUpDown11.Value = 0;
            comboBox1.Text = null;
            IceCreamcomboBox.Text = null;
            SnackscomboBox.Text = null;
            CoffeecomboBox.Text = null;
        }

        private void OptionsCloseBtn_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {
            const string message = "Confirm Logout";
            const string caption = "User Log Out";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                myLogin usrlgn = new myLogin();
                usrlgn.Show();
                this.Close();
            }
        }

        private void ExitOrderBtn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit?";
            const string caption = "Exit Order System";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //this.dataGridView1.Rows[e.RowIndex].Cells["Sn"].Value = (e.RowIndex + 1).ToString();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ComboBox.ObjectCollection comboBox1;
            decimal ItemQty = Convert.ToDecimal(numericUpDown11.Value);

            //decimal ZeroQTy = 0;

            if (numericUpDown11.Value == 0)
            {
                MessageBox.Show("Quantity cannot be Zero");
            }

            else
            {

                //decimal ItemQty = Convert.ToDecimal(numericUpDown11.Value);
                //decimal ItemCost = Convert.ToDecimal(DrinkPriceBox.Text);
                decimal LineTotal = ItemQty * DirectDecimal;

                if (TabControl1.SelectedTab.Text == "Soda")
                {


                    AddToGrid(comboBox1.SelectedItem.ToString(),tabPage1.Text, numericUpDown11.Value, DrinkPriceBox.Text, LineTotal);
                }
                else if (TabControl1.SelectedTab.Text == "Ice Cream")
                {
                    AddToGrid(IceCreamcomboBox.SelectedItem.ToString(), tabPage2.Text, numericUpDown11.Value, IceCreamPriceBox.Text, LineTotal);

                }
                else if (TabControl1.SelectedTab.Text == "Coffee")
                {

                    AddToGrid(CoffeecomboBox.SelectedItem.ToString(), tabPage3.Text, numericUpDown11.Value, CoffeePricetextBox.Text, LineTotal);
                }

                else if (TabControl1.SelectedTab.Text == "Snacks")
                {

                    AddToGrid(SnackscomboBox.SelectedItem.ToString(), tabPage4.Text, numericUpDown11.Value, SnacksPricetextBox.Text, LineTotal);
                }


                sum = 0;
                for (int n = 0; n < dataGridView1.Rows.Count; ++n)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[n].Cells[4].Value);
                }

                //decimal sumOriginal = sum;

                SubTotalCalc.Text = sum.ToString();


                decimal rate = Convert.ToDecimal(0.085);

                LineTax = LineTotal * rate;
                TaxValue = sum * rate;
                TaxCalc.Text = TaxValue.ToString();

                decimal TotalDue = TaxValue + sum;
                TotalDueCalc.Text = TotalDue.ToString();

            }


        }

        private void AddToGrid(string item, string cat, decimal qty, string price, decimal val)
        {

            dataGridView1.Rows.Add(item, cat, qty, price, val);
        }



        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            decimal DrinkPrice;
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select* from soda where Item = '" + comboBox1.Text + "' ;";
            MySqlCommand Combodata = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

            //decimal ReturnDecimalPrice(decimal price)
            //{
            //    return price;
            //}

            try
            {
                connect.Open();

                myreader = Combodata.ExecuteReader();

                while (myreader.Read())
                {
                    DrinkPrice = myreader.GetDecimal("Prices");


                    DirectDecimal = DrinkPrice;

                    //DrinkPriceBox.Text = "$"+DrinkPrice;
                    DrinkPriceBox.Text = "$" + DrinkPrice.ToString();

                    byte[] img = (byte[])(myreader["Image"]);
                    if (img == null)

                    {
                        DrinkPictureBox.Image = null;

                    }
                    else
                    {
                        MemoryStream ImageStream = new MemoryStream(img);
                        DrinkPictureBox.Image = System.Drawing.Image.FromStream(ImageStream);
                    }


                }

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //decimal ReturnDecimalPrice(decimal price)
            //{
            //    price = DrinkPrice;
            //    return price;

            //}


        }
        public static decimal GetDecimalPrice(decimal price)
        {

            return price;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearGrid_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                sum = sum - Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[3].Value);
                SubTotalCalc.Text = sum.ToString();

                decimal rate = Convert.ToDecimal(0.085);
                TaxValue = sum * rate;
                TaxCalc.Text = TaxValue.ToString();

                decimal TotalDue = TaxValue + sum;
                TotalDueCalc.Text = TotalDue.ToString();

                //Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells[3].Value);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            const string message = "Confirm Payment?";
            const string caption = "Payment Confirmation";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {



                try
                {
                    //int CurrentRoll = 0;

                    for (int n = 0; n < dataGridView1.Rows.Count - 1; n++)
                    {

                        //MessageBox.Show("N=" + n + "and row="+ dataGridView1.Rows.Count);

                        MySqlCommand save = new MySqlCommand();

                        save.Connection = connect;

                        save.CommandText = ("Insert into itemorder(Item, Category, Quantity, Amount,Date, Tax, Clark)values(@Item,@Category, @Quantity,@Amount, @Date, @Tax, @Clark);");



                        save.Parameters.AddWithValue("@Item", dataGridView1.Rows[n].Cells[0].Value);
                        save.Parameters.AddWithValue("@Category", dataGridView1.Rows[n].Cells[1].Value);
                        save.Parameters.AddWithValue("@Quantity", dataGridView1.Rows[n].Cells[2].Value);
                        
                        save.Parameters.AddWithValue("@Amount", dataGridView1.Rows[n].Cells[4].Value);
                        save.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd h:mm tt"));
                        save.Parameters.AddWithValue("@Tax", LineTax);
                        save.Parameters.AddWithValue("@Clark", OrderUserBanner.Text);

                        //if (TabControl1.SelectedTab.Text == "Soda")
                        //{
                        //    

                            
                        //}

                        // else if (TabControl1.SelectedTab.Text == "Ice Cream")
                        // {
                        //    save.Parameters.AddWithValue("@Category", tabPage2.Text);

                        //}

                        //else if (TabControl1.SelectedTab.Text == "Coffee")
                        //{

                        //    save.Parameters.AddWithValue("@Category", tabPage3.Text);
                        //}

                        //else if (TabControl1.SelectedTab.Text == "Snacks")
                        //{

                        //    save.Parameters.AddWithValue("@Category", tabPage4.Text);
                        //}

                        connect.Open();

                        save.ExecuteNonQuery();

                        connect.Close();




                    }

                }

                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }


                MessageBox.Show("Transaction Recorded Successfully!");
                //MessageBox.Show("Transaction Recorded Successfully!");
                numericUpDown11.Value = 0;
                comboBox1.Text = null;
                SubTotalCalc.Text = null;
                TaxCalc.Text = null;
                TotalDueCalc.Text = null;
                dataGridView1.Rows.Clear();

            }





        }

        private void ShowMyDateTime_Click(object sender, EventArgs e)
        {

        }

        private void DrinkPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ginger_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal SnackPrice;
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select* from snacks where Item = '" + SnackscomboBox.Text + "' ;";
            MySqlCommand Combodata = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

            try
            {
                connect.Open();

                myreader = Combodata.ExecuteReader();

                while (myreader.Read())
                {
                    SnackPrice = myreader.GetDecimal("Prices");

                    DirectDecimal = SnackPrice;

                    //DrinkPriceBox.Text = "$"+DrinkPrice;
                    SnacksPricetextBox.Text = "$" + SnackPrice.ToString();

                    byte[] img = (byte[])(myreader["Image"]);
                    if (img == null)

                    {
                        SnackspictureBox.Image = null;

                    }
                    else
                    {
                        MemoryStream ImageStream = new MemoryStream(img);
                        SnackspictureBox.Image = System.Drawing.Image.FromStream(ImageStream);
                    }


                }

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void IceCreamcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            decimal IceCreamPrice;
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select* from icecream where Item = '" + IceCreamcomboBox.Text + "' ;";
            MySqlCommand Combodata = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

            try
            {
                connect.Open();

                myreader = Combodata.ExecuteReader();

                while (myreader.Read())
                {
                    IceCreamPrice = myreader.GetDecimal("Prices");

                    DirectDecimal = IceCreamPrice;

                    //DrinkPriceBox.Text = "$"+DrinkPrice;
                    IceCreamPriceBox.Text = "$" + IceCreamPrice.ToString();

                    byte[] img = (byte[])(myreader["Image"]);
                    if (img == null)

                    {
                        IceCreampictureBox.Image = null;

                    }
                    else
                    {
                        MemoryStream ImageStream = new MemoryStream(img);
                        IceCreampictureBox.Image = System.Drawing.Image.FromStream(ImageStream);
                    }


                }

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CoffeecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal CoffeePrice;
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select* from coffee where Item = '" + CoffeecomboBox.Text + "' ;";
            MySqlCommand Combodata = new MySqlCommand(query, connect);
            MySqlDataReader myreader;

            try
            {
                connect.Open();

                myreader = Combodata.ExecuteReader();

                while (myreader.Read())
                {
                    CoffeePrice = myreader.GetDecimal("Prices");

                    DirectDecimal = CoffeePrice;

                    //DrinkPriceBox.Text = "$"+DrinkPrice;
                    CoffeePricetextBox.Text = "$" + CoffeePrice.ToString();

                    byte[] img = (byte[])(myreader["Image"]);
                    if (img == null)

                    {
                        CoffeepictureBox.Image = null;

                    }
                    else
                    {
                        MemoryStream ImageStream = new MemoryStream(img);
                        CoffeepictureBox.Image = System.Drawing.Image.FromStream(ImageStream);
                    }


                }

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
