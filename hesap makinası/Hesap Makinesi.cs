using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsApp4
{
    public partial class Form1 : Form
    {
        double birinciSayi = 0;
        string islem = "";
        bool yeniSayiMi = false;

        private void IslemYap(string yeniIslem)
        {
            try
            {
                birinciSayi = Convert.ToDouble(textBox1.Text);
                islem = yeniIslem;
                yeniSayiMi = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }
        private void RakamEkle(string rakam)
        {
            if (textBox1.Text == "0" || yeniSayiMi)
            {
                textBox1.Text = "";
                yeniSayiMi = false;
            }

            textBox1.Text += rakam;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

                if (textBox1.Text == "" || textBox1.Text == "-")
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IslemYap("%");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IslemYap("/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RakamEkle("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RakamEkle("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RakamEkle("9");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IslemYap("*");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IslemYap("+");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RakamEkle("6");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RakamEkle("5");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RakamEkle("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IslemYap("-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RakamEkle("3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RakamEkle("2");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            RakamEkle("1");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double ikinciSayi = 0;
            double sonuc = 0;

            try
            {
                ikinciSayi = Convert.ToDouble(textBox1.Text);

                switch (islem)
                {
                    case "+":
                        sonuc = birinciSayi + ikinciSayi;
                        break;
                    case "-":
                        sonuc = birinciSayi - ikinciSayi;
                        break;
                    case "*":
                        sonuc = birinciSayi * ikinciSayi;
                        break;
                    case "/":
                        if (ikinciSayi != 0)
                            sonuc = birinciSayi / ikinciSayi;
                        else
                        {
                            MessageBox.Show("Bir sayı sıfıra bölünemez!");
                            return;
                        }
                        break;
                    case "%":
                        sonuc = birinciSayi % ikinciSayi;
                        break;
                    default:
                        sonuc = ikinciSayi;
                        break;
                }

                textBox1.Text = sonuc.ToString();
                birinciSayi = sonuc;
                yeniSayiMi = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RakamEkle("0");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0";

                textBox1.Text += ",";
            }
        }
    }
}
