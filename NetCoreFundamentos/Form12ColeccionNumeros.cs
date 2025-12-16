using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
            this.lstNumeros.SelectionMode = SelectionMode.MultiExtended;
        }


        private void btnGenerarNumeros_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                int num = new Random().Next(1, 100);
                this.lstNumeros.Items.Add(num);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            foreach(int num in this.lstNumeros.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    pares+=num;
                }else
                {
                    impares += num;
                }
            }
            this.txtImpares.Text = impares.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtSuma.Text = suma.ToString();
        }
    }
}
