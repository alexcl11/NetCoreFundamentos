using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }




        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int ejeX = 0;
            int ejeY = 0;

            if (this.txtEjeX.Text == "" || this.txtEjeY.Text == "")
            {
                ejeX = new Random().Next(1, 500);
                ejeY = new Random().Next(1, 500);
            } else
            {
                ejeX = int.Parse(this.txtEjeX.Text);
                ejeY = int.Parse(this.txtEjeY.Text);
            }


                this.lblCambiarPosicion.Location = new Point(ejeX, ejeY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = 0;
            int azul = 0;
            int verde = 0;

            if(this.txtRojo.Text == "" || this.txtVerde.Text == "" || this.txtAzul.Text == "")
            {
                rojo = new Random().Next(1, 255);
                azul = new Random().Next(1, 255);
                verde = new Random().Next(1, 255);

            }
            else
            {
                rojo = int.Parse(this.txtRojo.Text);
                azul = int.Parse(this.txtAzul.Text);
                verde = int.Parse(this.txtVerde.Text);
            }

                this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
