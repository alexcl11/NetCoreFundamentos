using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnComprobarIsbn_Click(object sender, EventArgs e)
        {
            string cadena = txtIsbn.Text;
            if (cadena.Length != 10)
            {
                this.lblValidar.Text = "Inválido";
                return;
            }
            int suma = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[i];
                int num = int.Parse(letra.ToString());
                suma += num * (i + 1);
            }
            if (suma % 11 == 0)
            {
                this.lblValidar.Text = "Válido";

            }
            else
            {
                this.lblValidar.Text = "Inválido";
                
            }

        }
    }
}
