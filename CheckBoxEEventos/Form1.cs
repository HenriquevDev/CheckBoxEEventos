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
        List <CheckBox> frutas = new List <CheckBox> ();
        public Form1()
        {
            InitializeComponent();
            frutas.Add(checkBoxAbacaxi);
            frutas.Add(checkBoxBanana);
            frutas.Add(checkBoxMaca);
            frutas.Add(checkBoxMamao);
            frutas.Add(checkBoxMorango);
            frutas.Add(checkBoxPera);
            frutas.Add(checkBoxUva);
        }

         private void buttonfruta_Click(object sender, EventArgs e)
        {
            String txt = ""; 

            foreach(CheckBox t in frutas)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }


        //    if (checkBoxMaca.Checked )
        //    {
        //        txt += checkBoxMaca.Text + ", ";
        //    }
        //    if (checkBoxAbacaxi.Checked )
        //    {
        //        txt += checkBoxAbacaxi.Text + ", ";
        //    }
        //    if (checkBoxBanana.Checked )
        //    {
        //        txt += checkBoxBanana.Text + ", ";
        //    }
        //    if (checkBoxMamao.Checked )
        //    {
        //        txt += checkBoxMamao.Text + ", ";
        //    }
        //    if (checkBoxMorango.Checked )
        //    {
        //        txt += checkBoxMorango.Text + ", ";
        //    }
        //    if (checkBoxPera.Checked ) {
        //        txt += checkBoxPera.Text + ", ";
        //    }
        //    if (checkBoxUva.Checked)
        //    {
        //        txt += checkBoxUva.Text + ", ";
        //    }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "Sua escolha foi :  ");
        }

        private void checkBoxMaca_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxMaca.Checked )
            //{
            //    MessageBox.Show("O Item Maçã marcado!");
            //}
        }

        private void checkBoxPera_CheckedChanged(object sender, EventArgs e)
        {
        //    if (checkBoxPera.Checked)
        //    {
        //        MessageBox.Show("O item Pêra marcado!");
        //    }
        }

        private void checkBoxUva_CheckedChanged(object sender, EventArgs e)
        {
           //if (checkBoxUva.Checked)
           // {
           //     MessageBox.Show("O item Uva marcado!"); 
           // }
        }

        private void checkBoxAbacaxi_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxAbacaxi.Checked)
            //{
            //    MessageBox.Show("O item Abacaxi marcado!");
            //}
        }

        private void checkBoxMorango_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxMorango.Checked)
            //{
            //    MessageBox.Show("O Item Morango marcado!");
            //}
        }

        private void checkBoxBanana_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxBanana.Checked)
            //{
            //    MessageBox.Show("O item Banana marcado!");
            //}
        }

        private void checkBoxMamao_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxMamao.Checked)
            //{
            //    MessageBox.Show("O Item Mamão marcado!");
            //}
        }
    }
}
