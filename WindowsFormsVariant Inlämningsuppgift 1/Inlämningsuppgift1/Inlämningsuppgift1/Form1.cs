using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift1
{
    public partial class Växel : Form
    {
        public Växel()
        {
            InitializeComponent();
        }

        private void Beräkna_Click(object sender, EventArgs e)
        {
            //INPUT
            //Här skriver användaren priset på varan, vad den betalar, sedan räknas växeln ut. 
            int pris = int.Parse(txbPris.Text);
            int betalt = int.Parse(txbBetalt.Text);
            int växel = betalt - pris;


            //UTRÄKNINGEN AV VÄXEL
            //Växeln delas på 500. Denna siffra sparas och skrivs sedan ut i textboxen Utdata. Pengarna dras sedan från växeln, och en ny int skapas med det som är kvar av växeln. 
            int femhundraLappar = växel / 500;
            int växelTvåhundraLappar = växel - (femhundraLappar * 500);

            //Ovan upprepas, men nu med hundralappar. Samt med den kvarvarande växeln, efter att femhundralapparna plockats bort. Detta upprepas i samtliga valörer. 
            int tvåhundraLappar = växelTvåhundraLappar / 200;
            int växelHundraLappar = växelTvåhundraLappar - (tvåhundraLappar * 200);

            int hundraLappar = växelHundraLappar / 100;
            int växelFemtioLappar = växelHundraLappar - (hundraLappar * 100);

            int femtioLappar = växelFemtioLappar / 50;
            int växelTjugoLappar = växelFemtioLappar - (femtioLappar * 50);

            int tjugoLappar = växelTjugoLappar / 20;
            int växelTioKronor = växelTjugoLappar - (tjugoLappar * 20);

            int tioKronor = växelTioKronor / 10;
            int växelFemKronor = växelTioKronor - (tioKronor * 10);

            int femKronor = växelFemKronor / 5;
            int växelEnKronor = växelFemKronor - (femKronor * 5);

            int enKronor = växelEnKronor / 1;

            //OUTPUT
            //Samtliga sparade valörer skrivs ut i varsin textbox. 
            
            if (femhundraLappar != 0)
            {
                tbxFemhundra.Text = "Femhundralappar: " + femhundraLappar.ToString();
            }
            if (tvåhundraLappar != 0)
            {
                tbxTvåhundra.Text = "Tvåhundralappar: " + tvåhundraLappar.ToString();
            }
            if (hundraLappar != 0)
            {
                tbxHundra.Text = "Hundralappar: " + hundraLappar.ToString();
            }
            if (femtioLappar != 0)
            {
                tbxFemtio.Text = "Femtilappar: " + femtioLappar.ToString();
            }
            if (tjugoLappar != 0)
            {
                tbxTjugo.Text = "Tjugolappar: " + tjugoLappar.ToString();
            }
            if (tioKronor != 0)
            {
                tbxTio.Text = "Tiokronor: " + tioKronor.ToString();
            }
            if (femKronor != 0)
            {
                tbxFem.Text = "Femkronor: " + femKronor.ToString();
            }
            if (enKronor != 0)
            {
                tbxEn.Text = "Enkronor: " + enKronor.ToString();
            }

        }

        private void txbFemhundra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPris_TextChanged(object sender, EventArgs e)
        {

            //Tömmar alla boxar.
            tbxFemhundra.Text = "";
            tbxTvåhundra.Text = "";
            tbxHundra.Text = "";
            tbxFemtio.Text = "";
            tbxTjugo.Text = "";
            tbxTio.Text = "";
            tbxFem.Text = "";
            tbxEn.Text = "";

        }

        private void txbBetalt_TextChanged(object sender, EventArgs e)
        {

            //Tömmar alla boxar.
            tbxFemhundra.Text = "";
            tbxTvåhundra.Text = "";
            tbxHundra.Text = "";
            tbxFemtio.Text = "";
            tbxTjugo.Text = "";
            tbxTio.Text = "";
            tbxFem.Text = "";
            tbxEn.Text = "";

        }
    }
}
