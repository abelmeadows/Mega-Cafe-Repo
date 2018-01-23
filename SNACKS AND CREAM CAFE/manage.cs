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
    public partial class manage : Form

        
    {
        public manage()
        {
            InitializeComponent();
        }


        MySqlConnection connect = new MySqlConnection("server =localhost; database = mega; username = root; password=;");


        private void tabPage1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserPhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPassword_Click(object sender, EventArgs e)
        {

        }

        private void ManageSavebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void ClarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Close current window?";
            const string caption = "Close windows";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void ManageCancelbtn_Click(object sender, EventArgs e)
        {
            ManageUserNameText.Clear();
            ManagePhoneNumText.Clear();
            ManageEmailText.Clear();
            ManagePhoneNumText.Clear();
            ManagePasswordText.Clear();
        }

        private void ManageSavebtn_Click_1(object sender, EventArgs e)
        {
            MySqlCommand save = new MySqlCommand();
            save.Connection = connect;

            save.CommandText = ("Insert into loginpage(username, password, Privilege, PhoneNumber, Email)values(@username, @password,@Privilege, @PhoneNumber, @Email);");

            if (ManageUserNameText.Text == "" || ManagePasswordText.Text == "" ||
                    ManagePhoneNumText.Text == "" || ManageEmailText.Text == "")
            {

                MessageBox.Show("All field must be filled");

            }
                    else if (AdminCheckBox.Checked == true)
                    { 
                    save.Parameters.AddWithValue("@username", ManageUserNameText.Text);
                    save.Parameters.AddWithValue("@password", ManagePasswordText.Text);
                    save.Parameters.AddWithValue("@PhoneNumber", ManagePhoneNumText.Text);
                    save.Parameters.AddWithValue("@Email", ManageEmailText.Text);
                    save.Parameters.AddWithValue("@privilege", "Admin");

                    connect.Open();
                    save.ExecuteNonQuery();
                    MessageBox.Show("User Created successfully!");
                    connect.Close();
                    this.Close();

                    }


                    else if (ClarkCheckBox.Checked == true)
                    {


                    save.Parameters.AddWithValue("@username", ManageUserNameText.Text);
                    save.Parameters.AddWithValue("@password", ManagePasswordText.Text);
                    save.Parameters.AddWithValue("@PhoneNumber", ManagePhoneNumText.Text);
                    save.Parameters.AddWithValue("@Email", ManageEmailText.Text);
                    save.Parameters.AddWithValue("@privilege", "Clark");

                    connect.Open();
                    save.ExecuteNonQuery();
                    MessageBox.Show("User Created successfully!");
                    connect.Close();
                    this.Close();

                    }




                     else
                    {
                    MessageBox.Show("please select a valid user prililege");
                    }



            
                

                    


        }

        private void AdminCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            ClarkCheckBox.Checked = !AdminCheckBox.Checked;

            
                   // MySqlCommand AddClark = new MySqlCommand(AddAdmin);


                    //MySqlCommand AddAdmin = new MySqlCommand();


                    //AddAdmin.Connection = connect;
                    //AddAdmin.Parameters.AddWithValue("@Privilege", "Admin");
                }

        private void ClarkCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            AdminCheckBox.Checked = !ClarkCheckBox.Checked;


                   


            //AddClark.Connection = connect;
            //AddClark.Parameters.AddWithValue("@Privilege", "Clark");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        { 


        }

        private void manage_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand save = new MySqlCommand();
            save.Connection = connect;

            //string category = comboBoxItemAdd.SelectedItem.ToString();


            

            if (textBoxItemName.Text == "" || textBoxItemPrice.Text == "" ||
                    comboBoxItemAdd.Items == null )
            {

                MessageBox.Show("All field must be filled");

            }
            else if (comboBoxItemAdd.Text == "soda")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                save.CommandText = ("Insert into soda (Item,Prices)values(@Item,@Prices);");

                save.Parameters.AddWithValue("@Item", textBoxItemName.Text);
                save.Parameters.AddWithValue("@Prices", textBoxItemPrice.Text);
                

                connect.Open();
                save.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
                connect.Close();

                textBoxItemName.Clear();
                textBoxItemPrice.Clear();
                comboBoxItemAdd.Text = null;
            }
            else if (comboBoxItemAdd.Text == "icecream")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                save.CommandText = ("Insert into icecream (Item,Prices)values(@Item,@Prices);");

                save.Parameters.AddWithValue("@Item", textBoxItemName.Text);
                save.Parameters.AddWithValue("@Prices", textBoxItemPrice.Text);


                connect.Open();
                save.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
                connect.Close();

                textBoxItemName.Clear();
                textBoxItemPrice.Clear();
                comboBoxItemAdd.Text = null;
            }
            else if (comboBoxItemAdd.Text == "coffee")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                save.CommandText = ("Insert into coffee (Item,Prices)values(@Item,@Prices);");

                save.Parameters.AddWithValue("@Item", textBoxItemName.Text);
                save.Parameters.AddWithValue("@Prices", textBoxItemPrice.Text);


                connect.Open();
                save.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
                connect.Close();

                textBoxItemName.Clear();
                textBoxItemPrice.Clear();
                comboBoxItemAdd.Text = null;
            }
            else if (comboBoxItemAdd.Text == "snacks")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                save.CommandText = ("Insert into snacks (Item,Prices)values(@Item,@Prices);");

                save.Parameters.AddWithValue("@Item", textBoxItemName.Text);
                save.Parameters.AddWithValue("@Prices", textBoxItemPrice.Text);


                connect.Open();
                save.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
                connect.Close();

                textBoxItemName.Clear();
                textBoxItemPrice.Clear();
                comboBoxItemAdd.Text = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");

            //string query = "select* from LoginPage where username = '" + username + "' && password = '" + password + "' ";

            if (comboBoxSearch.SelectedItem.ToString() == "soda")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";


                
                string query = "select* from soda";
                MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                DataTable tab = new DataTable();
                ExtractData.Fill(tab);

                dataGridViewItemEdit.DataSource = tab;

            }
            else if (comboBoxSearch.SelectedItem.ToString() == "icecream")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                string query = "select* from icecream";
                MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                DataTable tab = new DataTable();

                ExtractData.Fill(tab);

                dataGridViewItemEdit.DataSource = tab;


                //connect.Open();
                //save.ExecuteNonQuery();
                //MessageBox.Show("Item Added Successfully!");
                //connect.Close();

                
            }
            else if (comboBoxSearch.SelectedItem.ToString() == "coffee")
            {
                //string query = " Select * From " + table + " Where CityId = '" + cityId + "'";

                string query = "select* from coffee";
                MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                DataTable tab = new DataTable();

                ExtractData.Fill(tab);

                dataGridViewItemEdit.DataSource = tab;
            }
            else if (comboBoxSearch.SelectedItem.ToString() == "snacks")
            {
                string query = "select* from snacks";
                MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                DataTable tab = new DataTable();

                ExtractData.Fill(tab);

                dataGridViewItemEdit.DataSource = tab;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            const string message = "Are you sure you want to delete item from database?";
            const string caption = "Delete Item?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int rowIndex = dataGridViewItemEdit.CurrentCell.RowIndex;


                MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
                string query = "delete from soda where Item = '" + dataGridViewItemEdit.Rows[rowIndex].Cells[1].Value + "'; ";
                MySqlCommand DeleteData = new MySqlCommand(query, connect);
                MySqlDataReader TheReader;

                try
                {

                    connect.Open();
                    TheReader = DeleteData.ExecuteReader();
                    MessageBox.Show("Item Deleted");

                    RefreshMyTable();

                    while (TheReader.Read())
                    {


                    }
                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ManageDeleteBtn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to delete?";
            const string caption = "Delete User?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int rowIndex = dataGridViewUser.CurrentCell.RowIndex;


                MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");
                string query = "delete from loginpage where username = '" + dataGridViewUser.Rows[rowIndex].Cells[1].Value + "'; ";
                MySqlCommand DeleteData = new MySqlCommand(query, connect);
                MySqlDataReader TheReader;

                try
                {

                    connect.Open();
                    TheReader = DeleteData.ExecuteReader();
                    MessageBox.Show("Item Deleted");

                    RefreshMyTable();

                    while (TheReader.Read())
                    {


                    }
                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void RefreshMyTable()
   
        { MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");

            //string query = "select* from LoginPage where username = '" + username + "' && password = '" + password + "' ";


            string query = "select* from loginpage";
            MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
            DataTable tab = new DataTable();
            ExtractData.Fill(tab);

            dataGridViewUser.DataSource = tab;
        }

        private void SearchUserBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");

            //string query = "select* from LoginPage where username = '" + username + "' && password = '" + password + "' ";


                string query = "select* from loginpage";
                MySqlDataAdapter ExtractData = new MySqlDataAdapter(query, connect);
                DataTable tab = new DataTable();
                ExtractData.Fill(tab);

                dataGridViewUser.DataSource = tab;

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SalesReport Sls = new SalesReport();
            Sls.Show();
        }

        private void comboBoxItemAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
