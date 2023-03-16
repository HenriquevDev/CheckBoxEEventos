using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxEEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonfruta_Click(object sender, EventArgs e)
        {
            string txt = ""; 
            if (checkBoxMaca.Checked )
            {
                txt += checkBoxMaca.Text + ", ";
            }
            if (checkBoxAbacaxi.Checked )
            {
                txt += checkBoxAbacaxi.Text + ", ";
            }
            if (checkBoxBanana.Checked )
            {
                txt += checkBoxBanana.Text + ", ";
            }
            if (checkBoxMamao.Checked )
            {
                txt += checkBoxMamao.Text + ", ";
            }
            if (checkBoxMorango.Checked )
            {
                txt += checkBoxMorango.Text + ", ";
            }
            if (checkBoxPera.Checked ) {
                txt += checkBoxPera.Text + ", ";
            }
            if (checkBoxUva.Checked)
            {
                txt += checkBoxUva.Text + ", ";
            }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "A fruta escolhida foi . . .");
        }
    }
}
