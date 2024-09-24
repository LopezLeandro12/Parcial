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
    public partial class Frm_juegoA : Form
    {
        public Frm_juegoA()
        {
            InitializeComponent();
        }




        private void lbl_evos_agu_Click(object sender, EventArgs e)
        {

        }
        private async void StartProgress()
        {
            Barra_A.Value = 0;
            lbl_evos_agu.Text = "Agumon!";
            while (Barra_A.Value < 100)
            {
                Barra_A.Value++;
                if (Barra_A.Value < 45)
                {
                    Personaje.Image = Properties.Resources.descarga__1_;
                }
                else if (Barra_A.Value < 75)
                {
                    Personaje.Image = Properties.Resources.descarga__3_;
                }
                else
                {
                    Personaje.Image = Properties.Resources.descarga__2_;
                }
                if (Barra_A.Value == 45)
                {
                    lbl_evos_agu.Text = "Greymon!!!";
                }
                else if (Barra_A.Value == 75)
                {
                    lbl_evos_agu.Text = "Metal Greymon!!!";
                }

                await Task.Delay(500);

            }
        }

        private void Barra_A_Click(object sender, EventArgs e)
        {

        }

        private void Btn_start_agu_Click(object sender, EventArgs e)
        {
            StartProgress();
        }
        }
}

