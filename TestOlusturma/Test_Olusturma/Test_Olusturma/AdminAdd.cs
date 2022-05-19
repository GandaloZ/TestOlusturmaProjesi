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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=GANDALOZ;Initial Catalog=Test_OlusturmaDB;Integrated Security=True");
        int cellNo;
        private void AdminAdd_Load(object sender, EventArgs e)
        {
            lv_Sorular.View = View.Details;
            lv_Cevaplar.View = View.Details;
            lv_Sorular.Items.Clear();
            lv_Cevaplar.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_SorulariGosterme", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lv_Sorular.Items.Add(rdr["SoruNumarasi"].ToString());
                lv_Sorular.Items[lv_Sorular.Items.Count - 1].SubItems.Add(rdr["Soru"].ToString());
                lv_Cevaplar.Items.Add(rdr["SoruNumarasi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["aCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["bCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["cCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["dCevabi"].ToString());
            }
            connect.Close();
        }

        private void bt_SoruEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_Soru.Text) && !string.IsNullOrEmpty(txt_aCevabi.Text) && !string.IsNullOrEmpty(txt_bCevabi.Text) && !string.IsNullOrEmpty(txt_cCevabi.Text) && !string.IsNullOrEmpty(txt_dCevabi.Text))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("sp_SoruEkleme", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("pSoru", SqlDbType.VarChar, 100).Value = txt_Soru.Text;
                    cmd.Parameters.Add("aCevabi", SqlDbType.VarChar, 50).Value = txt_aCevabi.Text;
                    cmd.Parameters.Add("bCevabi", SqlDbType.VarChar, 50).Value = txt_bCevabi.Text;
                    cmd.Parameters.Add("cCevabi", SqlDbType.VarChar, 50).Value = txt_cCevabi.Text;
                    cmd.Parameters.Add("dCevabi", SqlDbType.VarChar, 50).Value = txt_dCevabi.Text;
                    cmd.ExecuteNonQuery();

                    //SORU VE CEVAPLARI YENILEME:
                    lv_Sorular.View = View.Details;
                    lv_Cevaplar.View = View.Details;
                    lv_Sorular.Items.Clear();
                    lv_Cevaplar.Items.Clear();
                    SqlCommand cmd2 = new SqlCommand("sp_SorulariGosterme", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd2.ExecuteReader();
                    while (rdr.Read())
                    {
                        lv_Sorular.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Sorular.Items[lv_Sorular.Items.Count - 1].SubItems.Add(rdr["Soru"].ToString());
                        lv_Cevaplar.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["aCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["bCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["cCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["dCevabi"].ToString());
                    }
                    connect.Close();
                    txt_Soru.Text = string.Empty;
                    txt_aCevabi.Text = string.Empty;
                    txt_bCevabi.Text = string.Empty;
                    txt_cCevabi.Text = string.Empty;
                    txt_dCevabi.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Soru girebilmek için TÜM hücreleri lütfen doldurunuz.");
                }
            }
            catch
            {
                MessageBox.Show("Zaten içeride bulunan bir soruyu giremezsiniz!");
            }
            

        }

        private void bt_SoruListesiniGuncelle_Click(object sender, EventArgs e)
        {
            lv_Sorular.View = View.Details;
            lv_Cevaplar.View = View.Details;
            lv_Sorular.Items.Clear();
            lv_Cevaplar.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_SorulariGosterme", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lv_Sorular.Items.Add(rdr["SoruNumarasi"].ToString());
                lv_Sorular.Items[lv_Sorular.Items.Count - 1].SubItems.Add(rdr["Soru"].ToString());
                lv_Cevaplar.Items.Add(rdr["SoruNumarasi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["aCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["bCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["cCevabi"].ToString());
                lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["dCevabi"].ToString());
            }
            connect.Close();
        }

        private void lv_Sorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Sorular.SelectedItems.Count > 0)
            {
                ListViewItem soru = lv_Sorular.SelectedItems[0];
                cellNo = Convert.ToInt32(soru.Text);
                cellNo = (lv_Sorular.Items.IndexOf(lv_Sorular.SelectedItems[0]))+1;
                lv_Cevaplar.SelectedItems.Clear();
                lv_Cevaplar.Items[cellNo-1].Selected = true;

                txt_Soru.Text = soru.SubItems[1].Text;
                ListViewItem cevap = lv_Cevaplar.SelectedItems[0];
                txt_aCevabi.Text = cevap.SubItems[1].Text;
                txt_bCevabi.Text = cevap.SubItems[2].Text;
                txt_cCevabi.Text = cevap.SubItems[3].Text;
                txt_dCevabi.Text = cevap.SubItems[4].Text;
            }
        }

        private void bt_SoruSil_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Silmek isteğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (!string.IsNullOrEmpty(txt_Soru.Text) && !string.IsNullOrEmpty(txt_aCevabi.Text) && !string.IsNullOrEmpty(txt_bCevabi.Text) && !string.IsNullOrEmpty(txt_cCevabi.Text) && !string.IsNullOrEmpty(txt_dCevabi.Text))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("sp_SoruSilme", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("pSoruNumarasi", SqlDbType.Int).Value = cellNo;
                    cmd.ExecuteNonQuery();

                    //SORU VE CEVAPLARI YENILEME:
                    lv_Sorular.View = View.Details;
                    lv_Cevaplar.View = View.Details;
                    lv_Sorular.Items.Clear();
                    lv_Cevaplar.Items.Clear();
                    SqlCommand cmd2 = new SqlCommand("sp_SorulariGosterme", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd2.ExecuteReader();
                    while (rdr.Read())
                    {
                        lv_Sorular.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Sorular.Items[lv_Sorular.Items.Count - 1].SubItems.Add(rdr["Soru"].ToString());
                        lv_Cevaplar.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["aCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["bCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["cCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["dCevabi"].ToString());
                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Soru silebilmek için TÜM hücreleri lütfen doldurunuz.");
                }
            }
        }

        private void bt_SoruGuncelle_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Soruyu güncellemek istediğinize emin misiniz?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (!string.IsNullOrEmpty(txt_Soru.Text) && !string.IsNullOrEmpty(txt_aCevabi.Text) && !string.IsNullOrEmpty(txt_bCevabi.Text) && !string.IsNullOrEmpty(txt_cCevabi.Text) && !string.IsNullOrEmpty(txt_dCevabi.Text))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("sp_SoruGuncelleme", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("pSoruNumarasi", SqlDbType.Int).Value = cellNo;
                    cmd.Parameters.Add("pSoru", SqlDbType.VarChar, 100).Value = txt_Soru.Text;
                    cmd.Parameters.Add("aCevabi", SqlDbType.VarChar, 50).Value = txt_aCevabi.Text;
                    cmd.Parameters.Add("bCevabi", SqlDbType.VarChar, 50).Value = txt_bCevabi.Text;
                    cmd.Parameters.Add("cCevabi", SqlDbType.VarChar, 50).Value = txt_cCevabi.Text;
                    cmd.Parameters.Add("dCevabi", SqlDbType.VarChar, 50).Value = txt_dCevabi.Text;
                    cmd.ExecuteNonQuery();

                    //SORU VE CEVAPLARI YENILEME:
                    lv_Sorular.View = View.Details;
                    lv_Cevaplar.View = View.Details;
                    lv_Sorular.Items.Clear();
                    lv_Cevaplar.Items.Clear();
                    SqlCommand cmd2 = new SqlCommand("sp_SorulariGosterme", connect);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd2.ExecuteReader();
                    while (rdr.Read())
                    {
                        lv_Sorular.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Sorular.Items[lv_Sorular.Items.Count - 1].SubItems.Add(rdr["Soru"].ToString());
                        lv_Cevaplar.Items.Add(rdr["SoruNumarasi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["aCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["bCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["cCevabi"].ToString());
                        lv_Cevaplar.Items[lv_Cevaplar.Items.Count - 1].SubItems.Add(rdr["dCevabi"].ToString());
                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Soruyu güncellemek için TÜM hücreleri lütfen doldurunuz.");
                }
            }
        }
    }
}
