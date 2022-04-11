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

namespace öğrenc_otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server =.;Initial Catalog = öğrenciOtomasyonu ; Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql3 = "SELECT * FROM memurlar where Ad =@adi AND Sifre=@sifresi";
                SqlParameter prm5 = new SqlParameter("adi", txtAd.Text.Trim());
                SqlParameter prm6 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand komut3 = new SqlCommand(sql3, baglanti);
                komut3.Parameters.Add(prm5);
                komut3.Parameters.Add(prm6);
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                da3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    Form7 fr = new Form7();
                    fr.Show();

                }


            }
            catch (Exception)
            {


                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
