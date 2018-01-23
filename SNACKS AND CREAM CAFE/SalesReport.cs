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

namespace SNACKS_AND_CREAM_CAFE
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();

            labelSelectCategory.Hide();
            comboBoxSelectCategory.Hide();

            labelAttendantName.Hide();
            comboBoxAttendantName.Hide();

            labelSelectProduct.Hide();
            comboBoxSelectProduct.Hide();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (comboBox1.Text == "Product Category")
            {
                labelAttendantName.Hide();
                comboBoxAttendantName.Hide();

                labelSelectProduct.Hide();
                comboBoxSelectProduct.Hide();

                labelSelectCategory.Show();
                comboBoxSelectCategory.Show();

                MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
                string query = "select* from category";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader reader;
                try
                {

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string Cat = reader.GetString("Product Category");
                        comboBoxSelectCategory.Items.Add(Cat);
                    }
                }

                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                //if (comboBoxSearch.SelectedItem.ToString() == "soda")
                //{
                //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";



                //    string query = "select* from soda";
                //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                //    DataTable tab = new DataTable();
                //    ExtractData.Fill(tab);

                //    dataGridViewItemEdit.DataSource = tab;

                //}

            }

            else if(comboBox1.Text == "Attendant Clark")
            { 
                labelAttendantName.Show();
               comboBoxAttendantName.Show();

                labelSelectProduct.Hide();
                comboBoxSelectProduct.Hide();


                labelSelectCategory.Hide();
                comboBoxSelectCategory.Hide();
                MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
                string query = "select* from loginpage";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader reader;
                try
                {

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string User = reader.GetString("username");
                        comboBoxAttendantName.Items.Add(User);
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                //if (comboBoxSearch.SelectedItem.ToString() == "soda")
                //{
                //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";



                //    string query = "select* from soda";
                //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                //    DataTable tab = new DataTable();
                //    ExtractData.Fill(tab);

                //    dataGridViewItemEdit.DataSource = tab;

                //}

            }

            else if (comboBox1.Text == "Product")
            { 
               labelSelectProduct.Show();
                comboBoxSelectProduct.Show();


                labelSelectCategory.Hide();
                comboBoxSelectCategory.Hide();

                labelAttendantName.Hide();
                comboBoxAttendantName.Hide();

                MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
                string query = "select* from itembrief";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader reader;
                try
                {

                    connect.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string itm = reader.GetString("Item");
                        comboBoxSelectProduct.Items.Add(itm);
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                //if (comboBoxSearch.SelectedItem.ToString() == "soda")
                //{
                //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";



                //    string query = "select* from soda";
                //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                //    DataTable tab = new DataTable();
                //    ExtractData.Fill(tab);

                //    dataGridViewItemEdit.DataSource = tab;

                //}
            }

            if (comboBoxSelectCategory.Text == null)
            {

                MessageBox.Show("Category cannot be empty");

            }
            else
            {
                
            }
            //if (comboBoxSearch.SelectedItem.ToString() == "soda")
            //{
            //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";



            //    string query = "select* from soda";
            //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            //    DataTable tab = new DataTable();
            //    ExtractData.Fill(tab);

            //    dataGridViewItemEdit.DataSource = tab;

            //}
            //else if (comboBoxSearch.SelectedItem.ToString() == "icecream")
            //{
            //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

            //    string query = "select* from iceream";
            //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            //    DataTable tab = new DataTable();

            //    ExtractData.Fill(tab);

            //    dataGridViewItemEdit.DataSource = tab;


            //    //connect.Open();
            //    //save.ExecuteNonQuery();
            //    //MessageBox.Show("Item Added Successfully!");
            //    //connect.Close();


            //}
            //else if (comboBoxSearch.SelectedItem.ToString() == "coffee")
            //{
            //    //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

            //    string query = "select* from coffee";
            //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            //    DataTable tab = new DataTable();

            //    ExtractData.Fill(tab);

            //    dataGridViewItemEdit.DataSource = tab;
            //}
            //else if (comboBoxSearch.SelectedItem.ToString() == "snacks")
            //{
            //    string query = "select* from snacks";
            //    MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            //    DataTable tab = new DataTable();

            //    ExtractData.Fill(tab);

            //    dataGridViewItemEdit.DataSource = tab;
            //}
        }

        private void comboBoxSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            string current = comboBoxSelectCategory.SelectedItem.ToString();
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select Category, Amount from itemorder where Category = '" + current + "' && (Date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd h:mm tt") + "' And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd h:mm tt") + "' )";
            MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            DataTable tab = new DataTable();
            ExtractData.Fill(tab);

            dataGridView1.DataSource = tab;
        }

        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {


            string current = comboBoxSelectProduct.SelectedItem.ToString();
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select Item, Amount from itemorder where Item = '" + current + "' && (Date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd h:mm tt") + "' And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd h:mm tt") + "' )";
            MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            DataTable tab = new DataTable();
            ExtractData.Fill(tab);
            dataGridView1.DataSource = tab;


        }

        private void comboBoxAttendantName_SelectedIndexChanged(object sender, EventArgs e)
        {

            string current = comboBoxAttendantName.SelectedItem.ToString();
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
            string query = "select Clark, Amount from itemorder where Clark = '" + current + "' && (Date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd h:mm tt") + "' And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd h:mm tt") + "' )";
            MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            DataTable tab = new DataTable();
            ExtractData.Fill(tab);


        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesTotal_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int n = 0; n < dataGridView1.Rows.Count; ++n)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[n].Cells["Amount"].Value);
            }

            //decimal sumOriginal = sum;

            textBoxTotalSales.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to close report?";
            const string caption = "Exit Report System";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
