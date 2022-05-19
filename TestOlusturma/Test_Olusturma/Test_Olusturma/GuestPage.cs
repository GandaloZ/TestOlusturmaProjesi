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
    public partial class GuestPage : Form
    {
        public GuestPage()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=GANDALOZ;Initial Catalog=Test_OlusturmaDB;Integrated Security=True");
        int minSoruNum;
        int maxSoruNum;
        private void GuestPage_Load(object sender, EventArgs e)
        {
            List<string> Sorular = new List<string>();
            List<string> aCevabi = new List<string>();
            List<string> bCevabi = new List<string>();
            List<string> cCevabi = new List<string>();
            List<string> dCevabi = new List<string>();
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT Soru, aCevabi, bCevabi, cCevabi, dCevabi FROM SorularVeCevaplari", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sorular.Add(dr[0].ToString());
                aCevabi.Add(dr[1].ToString());
                bCevabi.Add(dr[2].ToString());
                cCevabi.Add(dr[3].ToString());
                dCevabi.Add(dr[4].ToString());
            }
            dr.Close();
            SqlCommand cmd2 = new SqlCommand("SELECT MIN(SoruNumarasi), MAX(SoruNumarasi) FROM SorularVeCevaplari", connect);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                minSoruNum = Convert.ToInt32(dr2[0]);
                maxSoruNum = Convert.ToInt32(dr2[1]);
            }
            connect.Close();
            Random rnd = new Random();
            int[] randoms = new int[10];
            List<int> randomList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                randoms[i] = rnd.Next(minSoruNum, maxSoruNum);
                if (!randomList.Contains(randoms[i]))
                {
                    randomList.Add(randoms[i]);
                }
                else
                {
                    randoms[i] = rnd.Next(minSoruNum, maxSoruNum);
                }                   
            }

            //SORULARI YERLESTIRME:
            lb_soru1.Text = Sorular[randoms[0]].ToString();
            radioButton1.Text = aCevabi[randoms[0]].ToString();
            radioButton2.Text = bCevabi[randoms[0]].ToString();
            radioButton3.Text = cCevabi[randoms[0]].ToString();
            radioButton4.Text = dCevabi[randoms[0]].ToString();
            lb_soru2.Text = Sorular[randoms[1]].ToString();
            radioButton6.Text = aCevabi[randoms[1]].ToString();
            radioButton7.Text = bCevabi[randoms[1]].ToString();
            radioButton8.Text = cCevabi[randoms[1]].ToString();
            radioButton5.Text = dCevabi[randoms[1]].ToString();
            lb_soru3.Text = Sorular[randoms[2]].ToString();
            radioButton10.Text = aCevabi[randoms[2]].ToString();
            radioButton11.Text = bCevabi[randoms[2]].ToString();
            radioButton12.Text = cCevabi[randoms[2]].ToString();
            radioButton9.Text = dCevabi[randoms[2]].ToString();
            lb_soru4.Text = Sorular[randoms[3]].ToString();
            radioButton14.Text = aCevabi[randoms[3]].ToString();
            radioButton15.Text = bCevabi[randoms[3]].ToString();
            radioButton16.Text = cCevabi[randoms[3]].ToString();
            radioButton13.Text = dCevabi[randoms[3]].ToString();
            lb_soru5.Text = Sorular[randoms[4]].ToString();
            radioButton18.Text = aCevabi[randoms[4]].ToString();
            radioButton19.Text = bCevabi[randoms[4]].ToString();
            radioButton20.Text = cCevabi[randoms[4]].ToString();
            radioButton17.Text = dCevabi[randoms[4]].ToString();
            lb_soru6.Text = Sorular[randoms[5]].ToString();
            radioButton22.Text = aCevabi[randoms[5]].ToString();
            radioButton23.Text = bCevabi[randoms[5]].ToString();
            radioButton24.Text = cCevabi[randoms[5]].ToString();
            radioButton21.Text = dCevabi[randoms[5]].ToString();
            lb_soru7.Text = Sorular[randoms[6]].ToString();
            radioButton26.Text = aCevabi[randoms[6]].ToString();
            radioButton27.Text = bCevabi[randoms[6]].ToString();
            radioButton28.Text = cCevabi[randoms[6]].ToString();
            radioButton25.Text = dCevabi[randoms[6]].ToString();
            lb_soru8.Text = Sorular[randoms[7]].ToString();
            radioButton30.Text = aCevabi[randoms[7]].ToString();
            radioButton31.Text = bCevabi[randoms[7]].ToString();
            radioButton32.Text = cCevabi[randoms[7]].ToString();
            radioButton29.Text = dCevabi[randoms[7]].ToString();
            lb_soru9.Text = Sorular[randoms[8]].ToString();
            radioButton34.Text = aCevabi[randoms[8]].ToString();
            radioButton35.Text = bCevabi[randoms[8]].ToString();
            radioButton36.Text = cCevabi[randoms[8]].ToString();
            radioButton33.Text = dCevabi[randoms[8]].ToString();
            lb_soru10.Text = Sorular[randoms[9]].ToString();
            radioButton38.Text = aCevabi[randoms[9]].ToString();
            radioButton39.Text = bCevabi[randoms[9]].ToString();
            radioButton40.Text = cCevabi[randoms[9]].ToString();
            radioButton37.Text = dCevabi[randoms[9]].ToString();

        }
    }
}
