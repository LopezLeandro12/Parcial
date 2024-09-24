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
    public partial class Frm_select : Form
    {
        public Frm_select()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Vmon_Click(object sender, EventArgs e)
        {

            this.Hide();
            using (Frm_juegoV frm_JuegoV = new Frm_juegoV())
            {
                if (frm_JuegoV.ShowDialog() == DialogResult.OK)
                {

                }

            }
            this.Show();
        }

        private void Btn_Agumon_Click(object sender, EventArgs e)
        {

            this.Hide();
            using (Frm_juegoA frm_JuegoA = new Frm_juegoA())
            {
                if (frm_JuegoA.ShowDialog() == DialogResult.OK)
                {

                }

            }
            this.Show();
        }
    }
}
