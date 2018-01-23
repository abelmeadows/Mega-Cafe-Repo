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
    
    public partial class myLogin : Form
    {
       

        public myLogin()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server = localhost; database = mega; username = root; password=;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit";
            const string caption = "Close System";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textUser.Text;
            password = textPass.Text;

            string query = "select* from LoginPage where username = '" + username + "' && password = '" + password + "' ";

            MySqlDataAdapter data = new MySqlDataAdapter(query, connect);

            DataTable DT = new DataTable();

            data.Fill(DT);

           
            if (DT.Rows.Count == 1)
            {

                //string name = username;
                Banner.Text = String.Format("Welcome {0}", username);
                
                Options opt = new Options(username);
                opt.Show();
                this.Close();
                //Get_login_username();
            }

            //else if (username == "" && password == "")
            //{
               // Banner.Text = "Credentials cannot be blank!";
         
           // }

            // else if (DT.Rows.Contains(username) == false)
            //{

            //Banner.Text = "You are no a registered user!";
            //}



            else
            {
                Banner.Text = "oops! Try Again";

                textUser.Clear();

                textPass.Clear();

                textUser.Focus();
               

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
        public  string Get_login_username()
        {
            string name = textUser.Text;
            //Console.WriteLine(name);
            return name;
            //get { return textUser.Text; }
            //set { textUser.Text = value; }

        }

    }
}
