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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
                this.Hide(  ); 
                using (Frm_select frm_Select = new Frm_select())
                {
                    if (frm_Select.ShowDialog() == DialogResult.OK)
                    {
                       
                    }
                   
                }
                this.Show();
            

        }
    }
}
