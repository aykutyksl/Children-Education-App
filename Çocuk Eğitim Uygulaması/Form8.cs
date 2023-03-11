using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form8 : Form
    {
        string renk = "";

        
        
        public Form8()
        {
            InitializeComponent();
        }
        
        
        private void Form8_Load(object sender, EventArgs e)
        {
            grupBoxRenk.Visible = false;
            grupBoxBoya.Visible = false;
            
            flatbutBitir.Visible = false;   
            lbl2.Visible = false;
            lblSaniye.Visible = false;  

            renkKirmizi.Visible = false;
            renkSari.Visible = false;
            renkMavi.Visible = false;
            renkYesil.Visible = false;
            pbİsaret.Visible = false;

        }

        

        private void renkKirmizi_Click(object sender, EventArgs e)
        {
            renk = "Kırmızı";
        }        

        private void renkMavi_Click(object sender, EventArgs e)
        {
            renk = "Mavi";
        }

        private void pbRenk1_Click(object sender, EventArgs e)
        {    

            pbRenk1.BackColor = renkAta();
           
        }

       public Color renkAta()
        {
            if (renk == "Kırmızı")
                return  Color.Red;
            else if (renk == "Mavi")
                return Color.Blue;
            else if (renk == "Yeşil")
                return Color.Green;
            else
                return Color.Yellow;
            
        }

        private void renkSari_Click(object sender, EventArgs e)
        {
            renk = "Sarı";
        }

        private void renkYesil_Click(object sender, EventArgs e)
        {
            renk = "Yeşil";
        }

        private void pbRenk2_Click(object sender, EventArgs e)
        {
            pbRenk2.BackColor = renkAta();
           
        }

        private void pbRenk3_Click(object sender, EventArgs e)
        {
            pbRenk3.BackColor = renkAta();
        }

        private void pbRenk4_Click(object sender, EventArgs e)
        {
            pbRenk4.BackColor = renkAta();
        }

        private void pbRenk5_Click(object sender, EventArgs e)
        {
            pbRenk5.BackColor = renkAta();
        }

        private void pbRenk6_Click(object sender, EventArgs e)
        {
            pbRenk6.BackColor = renkAta();
        }

        private void pbRenk7_Click(object sender, EventArgs e)
        {
            pbRenk7.BackColor = renkAta();
        }

        private void pbRenk8_Click(object sender, EventArgs e)
        {
            pbRenk8.BackColor = renkAta();
        }

        private void pbRenk9_Click(object sender, EventArgs e)
        {
            pbRenk9.BackColor = renkAta();
        }

        private void pbRenk10_Click(object sender, EventArgs e)
        {
            pbRenk10.BackColor = renkAta();
        }

        private void pbRenk11_Click(object sender, EventArgs e)
        {
            pbRenk11.BackColor = renkAta();
        }

        private void pbRenk12_Click(object sender, EventArgs e)
        {
            pbRenk12.BackColor = renkAta();
        }

        private void pbRenk13_Click(object sender, EventArgs e)
        {
            pbRenk13.BackColor = renkAta();
        }

        private void pbRenk14_Click(object sender, EventArgs e)
        {
            pbRenk14.BackColor = renkAta();
        }

        private void pbRenk15_Click(object sender, EventArgs e)
        {
            pbRenk15.BackColor = renkAta();
        }

        private void pbRenk16_Click(object sender, EventArgs e)
        {
            pbRenk16.BackColor = renkAta();
        }

        
        int salise = 0;
        int saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                saniye = 0;
                saniye++;
            }

            lblSaniye.Text=salise.ToString();
            
        }

        private void flatbutBaslat_Click(object sender, EventArgs e)
        {
            salise = 0;
            grupBoxRenk.Visible = true;
            grupBoxBoya.Visible = true;

            flatbutBitir.Visible = true;
            lbl2.Visible = true;
            lblSaniye.Visible = true;

            renkKirmizi.Visible = true;
            renkSari.Visible = true;
            renkMavi.Visible = true;
            renkYesil.Visible = true;
            pbİsaret.Visible = true;

            flatbutBaslat.Enabled = false;

            timer1.Start();
            Random rastgelesayi = new Random();
            int no = rastgelesayi.Next(0, 4);


            if (no == 0)
            {
                //Sarı boya
                pbRenksiz3.BackColor = Color.Yellow;
                pbRenksiz4.BackColor = Color.Yellow;
                pbRenksiz7.BackColor = Color.Yellow;
                pbRenksiz8.BackColor = Color.Yellow;
                pbRenksiz12.BackColor = Color.Yellow;
                pbRenksiz16.BackColor = Color.Yellow;

                //Mavi boya
                pbRenksiz1.BackColor = Color.Blue;
                pbRenksiz2.BackColor = Color.Blue;
                pbRenksiz5.BackColor = Color.Blue;
                pbRenksiz6.BackColor = Color.Blue;
                pbRenksiz9.BackColor = Color.Blue;
                pbRenksiz13.BackColor = Color.Blue;

                //Kırmızı boya
                pbRenksiz10.BackColor = Color.Red;
                pbRenksiz11.BackColor = Color.Red;
                pbRenksiz14.BackColor = Color.Red;
                pbRenksiz15.BackColor = Color.Red;
            }
            else if (no == 1)
            {
                //Sarı boya
                pbRenksiz6.BackColor = Color.Yellow;
                pbRenksiz7.BackColor = Color.Yellow;
                pbRenksiz10.BackColor = Color.Yellow;
                pbRenksiz11.BackColor = Color.Yellow;


                //Mavi boya
                pbRenksiz1.BackColor = Color.Blue;
                pbRenksiz2.BackColor = Color.Blue;
                pbRenksiz3.BackColor = Color.Blue;
                pbRenksiz4.BackColor = Color.Blue;
                pbRenksiz5.BackColor = Color.Blue;
                pbRenksiz8.BackColor = Color.Blue;

                //Kırmızı boya
                pbRenksiz9.BackColor = Color.Red;
                pbRenksiz12.BackColor = Color.Red;
                pbRenksiz13.BackColor = Color.Red;
                pbRenksiz14.BackColor = Color.Red;
                pbRenksiz15.BackColor = Color.Red;
                pbRenksiz16.BackColor = Color.Red;
            }
            else if (no == 2)
            {
                //Boyaların orada değişiklik ypaılacak yeiş gelecek
                //Sarı boya
                pbRenksiz3.BackColor = Color.Yellow;
                pbRenksiz6.BackColor = Color.Yellow;
                pbRenksiz8.BackColor = Color.Yellow;
                pbRenksiz9.BackColor = Color.Yellow;
                pbRenksiz11.BackColor = Color.Yellow;
                pbRenksiz14.BackColor = Color.Yellow;


                //Mavi boya
                pbRenksiz2.BackColor = Color.Blue;
                pbRenksiz5.BackColor = Color.Blue;
                pbRenksiz12.BackColor = Color.Blue;
                pbRenksiz15.BackColor = Color.Blue;


                //Kırmızı boya
                pbRenksiz1.BackColor = Color.Red;
                pbRenksiz4.BackColor = Color.Red;
                pbRenksiz7.BackColor = Color.Red;
                pbRenksiz10.BackColor = Color.Red;
                pbRenksiz13.BackColor = Color.Red;
                pbRenksiz16.BackColor = Color.Red;
            }
            else if (no == 3)
            {
                //sarı
                pbRenksiz1.BackColor = Color.Yellow;



                //Mavi boya
                pbRenksiz2.BackColor = Color.Blue;
                pbRenksiz5.BackColor = Color.Blue;
                pbRenksiz6.BackColor = Color.Blue;



                //Kırmızı boya
                pbRenksiz4.BackColor = Color.Red;
                pbRenksiz8.BackColor = Color.Red;
                pbRenksiz12.BackColor = Color.Red;
                pbRenksiz13.BackColor = Color.Red;
                pbRenksiz14.BackColor = Color.Red;
                pbRenksiz15.BackColor = Color.Red;
                pbRenksiz16.BackColor = Color.Red;

                //Yeşil boya
                pbRenksiz3.BackColor = Color.Green;
                pbRenksiz7.BackColor = Color.Green;
                pbRenksiz9.BackColor = Color.Green;
                pbRenksiz10.BackColor = Color.Green;
                pbRenksiz11.BackColor = Color.Green;

            }
            else if (no == 4)
            {
                //sarı
                pbRenksiz1.BackColor = Color.Yellow;
                pbRenksiz2.BackColor = Color.Yellow;
                pbRenksiz3.BackColor = Color.Yellow;
                pbRenksiz4.BackColor = Color.Yellow;
                //Mavi boya
                pbRenksiz5.BackColor = Color.Blue;
                pbRenksiz8.BackColor = Color.Blue;
                pbRenksiz12.BackColor = Color.Blue;
                pbRenksiz14.BackColor = Color.Blue;
                pbRenksiz15.BackColor = Color.Blue;
                pbRenksiz16.BackColor = Color.Blue;
                //Kırmızı boya
                pbRenksiz6.BackColor = Color.Red;
                pbRenksiz7.BackColor = Color.Red;
                pbRenksiz10.BackColor = Color.Red;
                pbRenksiz11.BackColor = Color.Red;
                //yeşil
                pbRenksiz9.BackColor = Color.Green;
                pbRenksiz13.BackColor = Color.Green;


            }

            label1.Text = no.ToString();
        }

        private void flatbutBitir_Click(object sender, EventArgs e)
        {
            if (pbRenk1.BackColor == pbRenksiz1.BackColor && pbRenk2.BackColor == pbRenksiz2.BackColor && pbRenk3.BackColor == pbRenksiz3.BackColor && pbRenk4.BackColor == pbRenksiz4.BackColor && pbRenk5.BackColor == pbRenksiz5.BackColor && pbRenk6.BackColor == pbRenksiz6.BackColor && pbRenk7.BackColor == pbRenksiz7.BackColor && pbRenk8.BackColor == pbRenksiz8.BackColor && pbRenk9.BackColor == pbRenksiz9.BackColor && pbRenk10.BackColor == pbRenksiz10.BackColor && pbRenk11.BackColor == pbRenksiz11.BackColor && pbRenk12.BackColor == pbRenksiz12.BackColor && pbRenk13.BackColor == pbRenksiz13.BackColor && pbRenk14.BackColor == pbRenksiz14.BackColor && pbRenk15.BackColor == pbRenksiz15.BackColor && pbRenk16.BackColor == pbRenksiz16.BackColor)
            {
                timer1.Stop();
                
                MessageBox.Show("Tebrikler ! " + lblSaniye.Text + " saniye içinde tamamladınız");
                flatbutBaslat.Enabled = true;
                pbRenk1.BackColor = Color.Black;
                pbRenk2.BackColor = Color.Black;
                pbRenk3.BackColor = Color.Black;
                pbRenk4.BackColor = Color.Black;
                pbRenk5.BackColor = Color.Black;
                pbRenk6.BackColor = Color.Black;
                pbRenk7.BackColor = Color.Black;
                pbRenk8.BackColor = Color.Black;
                pbRenk9.BackColor = Color.Black;
                pbRenk10.BackColor = Color.Black;
                pbRenk11.BackColor = Color.Black;
                pbRenk12.BackColor = Color.Black;
                pbRenk13.BackColor = Color.Black;
                pbRenk14.BackColor = Color.Black;
                pbRenk15.BackColor = Color.Black;
                pbRenk16.BackColor = Color.Black;
                flatbutBaslat.Text = "Tekrar Oyna";
               
            }
            else
            {
                MessageBox.Show("Yanlış renk var, dikkat etmelisin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblSaniye.Text = "0";
            saniye = 0;
            
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
