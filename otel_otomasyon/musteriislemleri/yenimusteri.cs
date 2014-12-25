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
        string  gtarih, ctarih;
        
        public yenimusteri()
        {
            InitializeComponent();
        }
  
        
        public void yenimusterikaydi()
       {                   
               try
            {      
           baglantiayarlari.baglan();    
                  gtarih=giristarihikutu.Value.ToShortDateString();
                  ctarih=cikistarihikutu.Value.ToShortDateString();
                  
                  SqlCommand musterikomut = new SqlCommand("INSERT INTO musteriler (TCKimlik,Ad,Soyad,Telefon,Cinsiyet,Medenihal) values (@TCKimlik,@Ad,@Soyad,@Telefon,@Cinsiyet,@Medenihal)", baglantiayarlari.bagla);

                    musterikomut.Parameters.AddWithValue("@TCKimlik", tckimliknokutu.Text);
                    musterikomut.Parameters.AddWithValue("@Ad", adkutu.Text);
                    musterikomut.Parameters.AddWithValue("@Soyad", soyadkutu.Text);
                    musterikomut.Parameters.AddWithValue("@Telefon", telefonnokutu.Text);
                    musterikomut.Parameters.AddWithValue("@Cinsiyet", cinsiyetkutu.Text);
                    musterikomut.Parameters.AddWithValue("@Medenihal", medenihal.Text);
                  
                 SqlCommand odakomut = new SqlCommand("INSERT INTO PuanDurumu (isim,limit,) values (@isim,@limit,)", baglantiayarlari.bagla);
             
                  odakomut.Parameters.AddWithValue("@isim", odanokutu.Text);
                  odakomut.Parameters.AddWithValue("@limit", odaturukutu.Text);
           
              
             
                  SqlCommand odadurumkomut = new SqlCommand("INSERT INTO PuanDurumu (GirisTarihi,CikisTarihi,) values (@giristarihi,@cikistarihi)", baglantiayarlari.bagla);

                  odadurumkomut.Parameters.AddWithValue("@giristarihi", gtarih);
                  odadurumkomut.Parameters.AddWithValue("@cikistarihi", ctarih);

                  
            
                   musterikomut.ExecuteNonQuery(); 
                   odakomut.ExecuteNonQuery();
                   odadurumkomut.ExecuteNonQuery();
              
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

        private void yenimusterikayit_Click(object sender, EventArgs e)
        {
            yenimusterikaydi();
        }

       
    }
}
