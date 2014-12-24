﻿using System;
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
       
         
       
                                  

                if(baglantiayarlari.bagla.State==ConnectionState.Closed)
                         baglantiayarlari.baglan();                
              try
            {      
          

                  SqlCommand musterikomut = new SqlCommand("INSERT INTO musteriler (TCKimlik,Ad,Soyad,Telefon,Cinsiyet,Medenihal) values (@TCKimlik,@Ad,@Soyad,@Telefon,@Cinsiyet,@Medenihal)", baglantiayarlari.bagla);

                    musterikomut.Parameters.AddWithValue("@tcno", tckimliknokutu.Text);
                    musterikomut.Parameters.AddWithValue("@ad", adkutu.Text);
                    musterikomut.Parameters.AddWithValue("@soyad", soyadkutu.Text);
                    musterikomut.Parameters.AddWithValue("@telefon", telefonnokutu.Text);
                    musterikomut.Parameters.AddWithValue("@cinsiyet", cinsiyetkutu.Text);
                    musterikomut.Parameters.AddWithValue("@medenihal", medenihal.Text);

                  
                  
                
                 SqlCommand odakomut = new SqlCommand("INSERT INTO PuanDurumu (isim,limit,durum) values (@isim,@limit,@durum)", baglantiayarlari.bagla);
             
               /*   odakomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odakomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odakomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odakomut.Parameters.AddWithValue("@tcno", txtTc.Text);
              
                
                  SqlCommand odadurumkomut = new SqlCommand("INSERT INTO PuanDurumu (GirisTarihi,CikisTarihi,Durum) values (@giristarihi,@cikistarihi,@durum)", baglantiayarlari.bagla);
                  
                  odadurumkomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odadurumkomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odadurumkomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                  odadurumkomut.Parameters.AddWithValue("@tcno", txtTc.Text);
                
            
                   musterikomut.ExecuteNonQuery(); 
                   odakomut.ExecuteNonQuery(); 
                   odadurumkomut.ExecuteNonQuery(); */
              
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
