using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Test_Olusturma
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=GANDALOZ;Initial Catalog=Test_OlusturmaDB;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            txt_pswrd.PasswordChar = chcb_showpswrd.Checked ? '\0' : '*';
        }

        private void bt_admin_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand getusername = new SqlCommand("SELECT AdminName FROM AdminInfos", connect);
            SqlDataReader nameRdr = getusername.ExecuteReader();
            string adminName = "a";
            string adminPswrd = "b";

            while (nameRdr.Read())
            {
                adminName = nameRdr["AdminName"].ToString();
            }
            nameRdr.Close();

            SqlCommand getpswrd = new SqlCommand("SELECT AdminPswrd FROM AdminInfos", connect);
            SqlDataReader pswrdRdr = getpswrd.ExecuteReader();

            while (pswrdRdr.Read())
            {
                adminPswrd = pswrdRdr["AdminPswrd"].ToString();
            }

            connect.Close();
            if (txt_name.Text == adminName && txt_pswrd.Text == adminPswrd)
            {
                AdminAdd adminpage = new AdminAdd();
                adminpage.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre hatalı!");
            }
            
        }

        private void bt_guest_Click(object sender, EventArgs e)
        {
            GuestPage guestpage = new GuestPage();
            guestpage.Show();
        }
    }
}
