using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon
{
    public partial class anasayfa : Form
    {
        yenimusteri yenimusteri;
        mevcutmusteri mevcutmusteri;
        arama musteriarama;
        doluodalar doluodalar;
        bosodalar bosodalar;
        kullanicigirisi giris;
        odaislemleri odalar;
     

        public anasayfa()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapacaksınız Eminmisiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }

           }

        private void yeniMüşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (yenimusteri == null || yenimusteri.IsDisposed)
            {
               yenimusteri = new yenimusteri();
                yenimusteri.MdiParent = this;
                yenimusteri.Show();
            }
            else
            {
                yenimusteri.Focus();
            }
            
        }

        private void mevcutOlanMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mevcutmusteri == null || mevcutmusteri.IsDisposed)
            {
            mevcutmusteri = new mevcutmusteri();
            mevcutmusteri.MdiParent = this;
            mevcutmusteri.Show();
            }
            else
            {
                mevcutmusteri.Focus();
            }
        
        }

        private void müşteriAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteriarama == null || musteriarama.IsDisposed)
            {
                musteriarama = new arama();
                musteriarama.MdiParent = this;
                musteriarama.Show();
            }
            else
            {
                musteriarama.Focus();

            }
                    }

              private void doluOdalarToolStripMenuItem_Click(object sender, EventArgs e)
                     {
              if (doluodalar == null || doluodalar.IsDisposed)
             {
                doluodalar = new doluodalar();
                doluodalar.MdiParent = this;
                doluodalar.Show();
            }
            else
	        {
                doluodalar.Focus();
	         }
             }

               private void boşOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if (bosodalar == null || bosodalar.IsDisposed)
	    {
		 bosodalar = new bosodalar();
         bosodalar.MdiParent = this;
         bosodalar.Show();
        }
        else
	    {
            bosodalar.Focus();
	    }
        }
                private void anasayfa_Load(object sender, EventArgs e)
        {
           
            giris = new kullanicigirisi();
       //     giris.Show();
          //  giris.Focus();
         //   giris.MdiParent = this;

                 
                }

                private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (odalar == null || odalar.IsDisposed)
                    {
                        odalar = new odaislemleri();
                        odalar.MdiParent = this;
                        odalar.Show();
                    }
                    else
                    {
                        odalar.Focus();
                    }
                }
             
        }
             
    }

