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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server =.;Initial Catalog = öğrenciOtomasyonu ; Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql2 = "SELECT * FROM öğrenci where No =@no1 AND Sifre=@sifresi1";
                SqlParameter prm3 = new SqlParameter("no1", txtNo.Text);
                SqlParameter prm4 = new SqlParameter("sifresi1", txtSifre.Text.Trim());
                SqlCommand komut2 = new SqlCommand(sql2, baglanti);
                komut2.Parameters.Add(prm3);
                komut2.Parameters.Add(prm4);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                da2.Fill(dt2);


                if (dt2.Rows.Count > 0)
                {
                    Form6 fr2 = new Form6();
                    fr2.Show();
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Hatalı Giriş");
            }



        }
    }
}

        

   

