using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilOgrenmeUygulamasi
{
    //Yemek icin
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }
        int sayac = 0;
        double dogru = 0, yanlis = 0;

        void sorular()
        {
            if (sayac == 1)
            {
                label2.Text = " Food ";
                button1.Text = " Elma ";
                button2.Text = " Su";
                button3.Text = " Yemek ";
                button4.Text = " İçmek  ";
                dogrucevap = button3.Text;
            }

            if (sayac == 2)
            {
                label2.Text = " Bread ";
                button1.Text = " Ekmek ";
                button2.Text = " Havuç ";
                button3.Text = " Portakal ";
                button4.Text = " Çorba ";
                dogrucevap = button1.Text;
            }

            if (sayac == 3)
            {
                label2.Text = " Water ";
                button1.Text = " Çorba ";
                button2.Text = " Çilek ";
                button3.Text = " Kola ";
                button4.Text = " Su ";
                dogrucevap = button4.Text;
            }

            if (sayac == 4)
            {
                label2.Text = " Chocolate ";
                button1.Text = " Çikolata ";
                button2.Text = " Portakal ";
                button3.Text = " Cips ";
                button4.Text = " Elma ";
                dogrucevap = button1.Text;
            }

            if (sayac == 5)
            {
                label2.Text = " Soup ";
                button1.Text = " Makarna ";
                button2.Text = " Süt ";
                button3.Text = " Çorba ";
                button4.Text = " Salata ";
                dogrucevap = button3.Text;
            }

            if (sayac == 6)
            {
                label2.Text = " Juice ";
                button1.Text = " Meyve Suyu ";
                button2.Text = " Kola ";
                button3.Text = " Su ";
                button4.Text = " Kahve ";
                dogrucevap = button1.Text;
            }

            if (sayac == 7)
            {
                label2.Text = " Coffee ";
                button1.Text = " Kola ";
                button2.Text = " Su ";
                button3.Text = " Çay ";
                button4.Text = " Kahve ";
                dogrucevap = button4.Text;
            }

            if (sayac == 8)
            {
                label2.Text = " Apple ";
                button1.Text = " Armut ";
                button2.Text = " Elma ";
                button3.Text = " Peynir ";
                button4.Text = " Kabak ";
                dogrucevap = button2.Text;
            }

            if (sayac == 9)
            {
                label2.Text = " Strawberry ";
                button1.Text = " Çilek ";
                button2.Text = " Elma ";
                button3.Text = " Portakal ";
                button4.Text = " Muz ";
                dogrucevap = button1.Text;
            }

            if (sayac == 10)
            {
                label2.Text = " Carrot ";
                button1.Text = " Havuç ";
                button2.Text = " Domates ";
                button3.Text = " Elma ";
                button4.Text = " Salatalık ";
                dogrucevap = button1.Text;
            }
        }

        private void DortButon(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }
            if ((sender as Button).Text == dogrucevap)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            lblDogru.Text = "Doğru Sayısı = " + dogru;
            lblYanlis.Text = "Yanlış Sayısı = " + yanlis;

        }
        string dogrucevap = "";

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            button5.Text = "Sonraki Soru";
            sayac++;
            label1.Text = " Soru " + sayac + ":";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            sorular();
        }

        

    }
}

