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
    
    public partial class Options : Form
    {
        string myName;


        public Options(string bannerName)
        {

           
            InitializeComponent();
            UserBanner.Text = bannerName;
            myName = giveName(bannerName);


            //string SelectAdmin = "Admin";

            myLogin lgn = new myLogin();

            string OptionsUserName = lgn.Get_login_username();

            MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");

            string query = "select* from LoginPage where username = '" + UserBanner.Text + "' ";


            MySqlDataAdapter data = new MySqlDataAdapter(query, connect);

            DataTable DT = new DataTable();

            data.Fill(DT);


            if (DT.Rows[0][3].ToString().Trim() == "Admin")

            {
                ManagePicture.Show();
                ManageLabel.Show();
            }
            else
            {

                ManagePicture.Hide();
                ManageLabel.Hide();

            }


        }

        private void Options_Load(object sender, EventArgs e)
        {

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            order ordr = new order(myName);
            ordr.Show();

            myLogin lgnref = new myLogin();
            string name = lgnref.Get_login_username();
            //Console.WriteLine(name); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            manage mng = new manage();
            mng.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            supply spl = new supply();
            spl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void OptionsCloseBtn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit";
            const string caption = "Close System";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            supply sply = new supply();
            sply.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            //manage mng = new manage();
            //mng.Show();

      
        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }

        public string giveName(string name)
        {
            return name;
        }
    }
}
