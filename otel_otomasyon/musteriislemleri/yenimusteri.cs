using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Baglanti için gerekli namespace

namespace otel_otomasyon
{
    public partial class yenimusteri : Form
    {
        public yenimusteri()
        {
            InitializeComponent();
        }
        
        public void yenimusterikaydi()
        {
            baglantiayarlari.baglan();
         try
            {

                

                if(baglantiayarlari.bagla.State==ConnectionState.Closed)

               baglantiayarlari.baglan();

                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into musteriler(tcno,isim,soyisim,telefon,adres) values (@tcno,@isim,@soyisim,@telefon,@adres)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglantiayarlari.baglan);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@tcno", txtTc.Text);
                komut.Parameters.AddWithValue("@isim", txtIsim.Text);
                komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglantiayarlari.baglanma();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
 
        }
                 
 
       


        

        private void yenimusteri_Load(object sender, EventArgs e)
        {
         

        }
        
    }
}
