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
    public partial class Form8 : Form
    {
        SqlDataAdapter da;
        SqlCommand komut5;
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server =.;Initial Catalog = öğrenciOtomasyonu ; Integrated Security=SSPI");
        void OgrenciGetir()
        {
         
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM notgiriş", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
     


        private void button1_Click(object sender, EventArgs e)
        {

            string sorgu2 = "INSERT INTO notgiriş(ogrno,ad,soyad,aldigiders,VizeNotu,FinalNotu,yıl) VALUES (@ogrno,@ad,@soyad,@aldigiders,@VizeNotu,@FinalNotu,@yıl)";
            komut5 = new SqlCommand(sorgu2, baglanti);
            komut5.Parameters.AddWithValue("@ogrno", Convert.ToInt32(txtno.Text));
            komut5.Parameters.AddWithValue("@ad", txtad.Text);
            komut5.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut5.Parameters.AddWithValue("@aldigiders", txtders.Text);
            komut5.Parameters.AddWithValue("@VizeNotu", Convert.ToInt32(txtvizenot.Text));
            komut5.Parameters.AddWithValue("@FinalNotu", Convert.ToInt32(txtfinalnot.Text));
            komut5.Parameters.AddWithValue("@yıl", Convert.ToInt32(txtyıl.Text));
            baglanti.Open();
            komut5.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();

            label5.Text = "NOT GİRİŞİ BAŞARILI";
            txtno.Clear();
            txtad.Clear();
            txtsoyad.Clear();
            txtders.Clear();
            txtvizenot.Clear();
            txtfinalnot.Clear();
            txtyıl.Clear();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtders.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtvizenot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtfinalnot.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtyıl.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

     

     
    }
}
