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
    public partial class Form6 : Form
    {


        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server =.;Initial Catalog = öğrenciOtomasyonu ; Integrated Security=SSPI");

        private void notgörüntüle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From notgiriş where ogrno like'" + txt1.Text + "'", baglanti);

            SqlDataReader read = komut5.ExecuteReader();

            while (read.Read())
            {
                listBox1.Items.Add(read[0] + "  " + read[1] + "   " + read[2] + "   " + read[4] + "   " + read[5] + "   " + read[6]);



            }

            baglanti.Close();
        }
    }
    }
