using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Frm_juegoV : Form
    {
        public Frm_juegoV()
        {
            InitializeComponent();
        }

        private void btn_start_v_Click(object sender, EventArgs e)
        {
            StartProgress();
        
            }

        private void progressBar1_Click(object sender, EventArgs e)
        {

         }
        private async void StartProgress() 
        {
            Barra_V.Value = 0;
            lbl_v.Text = "Veemon!";
            while (Barra_V.Value < 100)
            {
                Barra_V.Value++;
                if (Barra_V.Value < 45)
                {
                    Personaje.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_29_32_PM;
                }
                else if (Barra_V.Value < 75)
                {
                    Personaje.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_31_02_PM;
                }
                else
                {
                    Personaje.Image = Properties.Resources.WhatsApp_Image_2024_09_23_at_10_35_21_PM;
                }
                if (Barra_V.Value == 45) 
                {
                    lbl_v.Text = "eXVeemon!!!";
                }
                else if (Barra_V.Value == 75) 
                {
                    lbl_v.Text = "Paildramon!!!";
                }

                await Task.Delay(500);

            }
        
        
        
        }

        private void Frm_juegoV_Load(object sender, EventArgs e)
        {

        }
    }


        
    }

