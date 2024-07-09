using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//Yemek icin
namespace DilOgrenmeUygulamasi
{
    public partial class Form5 : Form
    {
        private int currentSoundIndex = 0;
        private readonly SoundPlayer[] soundPlayers;
        public Form5()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;

            soundPlayers = new SoundPlayer[]
       {
                new SoundPlayer(Resource2.Food),
                new SoundPlayer(Resource2.Bread),
                new SoundPlayer(Resource2.Water),
                new SoundPlayer(Resource2.Chocolate),
                new SoundPlayer(Resource2.Soup),
                new SoundPlayer(Resource2.Juice),
                new SoundPlayer(Resource2.Coffee),
                new SoundPlayer(Resource2.apple),
                new SoundPlayer(Resource2.Strawberry),
                new SoundPlayer(Resource2.Carrot),


       };
        }
        
        int sayac = 0;

        void sorular()
        {
            if (sayac == 1)
            {
                label1.Text = " Food ";
                label2.Text = " Yemek ";
            }

            if (sayac == 2)
            {
                label1.Text = " Bread ";
                label2.Text = " Ekmek ";
            }

            if (sayac == 3)
            {
                label1.Text = " Water ";
                label2.Text = " Su ";
            }

            if (sayac == 4)
            {
                label1.Text = " Chocolate ";
                label2.Text = " Çikolata ";
            }

            if (sayac == 5)
            {
                label1.Text = " Soup ";
                label2.Text = " Çorba ";
            }

            if (sayac == 6)
            {
                label1.Text = " Juice ";
                label2.Text = "Meyve suyu";
            }

            if (sayac == 7)
            {
                label1.Text = " Coffee ";
                label2.Text = " Kahve ";
            }

            if (sayac == 8)
            {
                label1.Text = " Apple ";
                label2.Text = " Elma ";
            }

            if (sayac == 9)
            {
                label1.Text = " Strawberry ";
                label2.Text = "Çilek";
            }

            if (sayac == 10)
            {
                label1.Text = " Carrot ";
                label2.Text = "Havuç";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            
            button1.Text = "Sonraki Soru";
            sayac++;
            sorular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer currentPlayer = soundPlayers[currentSoundIndex];

            // Sesi çal
            currentPlayer.Play();

            // Sonraki sese geçmek için indeksi artır
            currentSoundIndex++;

            // Eğer indeks son dosyanın ötesine geçtiyse, başa dön
            if (currentSoundIndex >= soundPlayers.Length)
            {
                currentSoundIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
