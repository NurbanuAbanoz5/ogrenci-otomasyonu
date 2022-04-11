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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server =.;Initial Catalog = öğrenciOtomasyonu ; Integrated Security=SSPI");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "SELECT * FROM ögretmen where Ad =@adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txtAd.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Form5 fr = new Form5();
                    fr.Show();

                }


            }
            catch (Exception)
            {


                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
