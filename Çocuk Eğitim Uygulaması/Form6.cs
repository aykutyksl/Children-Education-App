using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int sonuc;
        private void butonTopla_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            label5.Visible = false;
            Random random = new Random();
            int sayi1 = random.Next(1, 30);
            int sayi2 = random.Next(1, 30);
            label1.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();
            sonuc = sayi1 + sayi2;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            bunifuImageButton1.Visible = true;
            bunifuMetroTextbox1.Visible = true;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(label2.Text=="+")
            {
              
                if (bunifuMetroTextbox1.Text == sonuc.ToString())
                {
                    label4.Text = "Doğru";
                    label4.ForeColor=Color.Blue;

                }
                else
                {
                    label4.Text = "Yanlış";
                    label4.ForeColor = Color.Red;
                }
                bunifuMetroTextbox1.Text = "";
                Random random = new Random();

                int sayi1 = random.Next(1, 30);
                int sayi2 = random.Next(1, 30);
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                sonuc = sayi1 + sayi2;
            }
            else if(label2.Text=="-")
            {
                if (bunifuMetroTextbox1.Text == sonuc.ToString())
                {
                    label4.Text = "Doğru";
                    label4.ForeColor = Color.Blue;
                }
                else
                {
                    label4.Text = "Yanlış";
                    label4.ForeColor = Color.Red;
                }
                bunifuMetroTextbox1.Text = "";
                Random random = new Random();
                int sayi1 = random.Next(1, 30);
                int sayi2 = random.Next(1, 30);
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                if (sayi1 > sayi2)
                {
                    label1.Text = sayi1.ToString();
                    label3.Text = sayi2.ToString();
                    sonuc = sayi1 - sayi2;
                }
                else if (sayi1 < sayi2)
                {
                    label1.Text = sayi2.ToString();
                    label3.Text = sayi1.ToString();
                    sonuc = sayi2 - sayi1;
                }
                else
                {
                    label1.Text = sayi1.ToString();
                    label3.Text = sayi2.ToString();
                    sonuc = sayi1 - sayi2;
                } 
            }
            else if(label2.Text == "/")
            {
                if (bunifuMetroTextbox1.Text == sonuc.ToString())
                {
                    label4.Text = "Doğru";
                    label4.ForeColor = Color.Blue;
                    
                }
                else
                {
                    label4.Text = "Yanlış";
                    label4.ForeColor = Color.Red;
                }
                bunifuMetroTextbox1.Text = "";
                Random random = new Random();
                int sayi1 = random.Next(1, 30);
                int sayi2 = random.Next(1, 30);
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                if (sayi1 > sayi2)
                {
                    label1.Text = sayi1.ToString();
                    label3.Text = sayi2.ToString();
                    sonuc = sayi1 / sayi2;
                }
                else if (sayi1 < sayi2)
                {
                    label1.Text = sayi2.ToString();
                    label3.Text = sayi1.ToString();
                    sonuc = sayi2 / sayi1;
                }
                else
                {
                    label1.Text = sayi1.ToString();
                    label3.Text = sayi2.ToString();
                    sonuc = sayi1 / sayi2;
                }
            }
            else if(label2.Text=="*")
            {
                    if (bunifuMetroTextbox1.Text == sonuc.ToString())
                    {
                        label4.Text = "Doğru";
                        label4.ForeColor = Color.Blue;
                    }
                    else
                    {
                        label4.Text = "Yanlış";
                        label4.ForeColor = Color.Red;
                    }
                    bunifuMetroTextbox1.Text = "";
                    Random random = new Random();

                    int sayi1 = random.Next(1, 10);
                    int sayi2 = random.Next(1, 10);
                    label1.Text = sayi1.ToString();
                    label3.Text = sayi2.ToString();
                    sonuc = sayi1 * sayi2;
                
            }

        }

        private void butonCikar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            bunifuImageButton1.Visible = true;
            bunifuMetroTextbox1.Visible = true;

            label2.Text = "-";
            label5.Visible = false;
            Random random = new Random();
            int sayi1 = random.Next(1, 30);
            int sayi2 = random.Next(1, 30);

            if (sayi1>sayi2)
            {
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                sonuc = sayi1 - sayi2;
            }
            else if (sayi1<sayi2)
            {
                label1.Text = sayi2.ToString();
                label3.Text = sayi1.ToString();
                sonuc = sayi2 - sayi1;
            }
            else
            {
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                sonuc = sayi1 - sayi2;
            }


             
        }

        private void butonBöl_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            bunifuImageButton1.Visible = true;
            bunifuMetroTextbox1.Visible = true;

            label2.Text = "/";
            label5.Visible = true;

            Random random = new Random();
            int sayi1 = random.Next(1, 30);
            int sayi2 = random.Next(1, 30);

            if (sayi1 > sayi2)
            {
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                sonuc = sayi1 / sayi2;
            }
            else if (sayi1 < sayi2)
            {
                label1.Text = sayi2.ToString();
                label3.Text = sayi1.ToString();
                sonuc = sayi2 / sayi1;
            }
            else
            {
                label1.Text = sayi1.ToString();
                label3.Text = sayi2.ToString();
                sonuc = sayi1 / sayi2;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuImageButton1.Visible = false;
            bunifuMetroTextbox1.Visible = false;
        }

        private void butonCarp_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            bunifuImageButton1.Visible = true;
            bunifuMetroTextbox1.Visible = true;

            label2.Text = "*";
            label5.Visible = false;
            Random random = new Random();
            int sayi1 = random.Next(1, 10);
            int sayi2 = random.Next(1, 10);
            label1.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();
            sonuc = sayi1 * sayi2;
        }

        private void bunifuMetroTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // windowsun "ding" sesini kaldırmak için (alt satırla birlikte)
                e.SuppressKeyPress = true; 
                bunifuImageButton1_Click(sender, e);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
