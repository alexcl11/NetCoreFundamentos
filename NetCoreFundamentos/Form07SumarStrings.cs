using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarStrings : Form
    {
        public Form07SumarStrings()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            //Recorreremos todo el contenido de textonumeros
            for(int i = 0; i< textoNumeros.Length; i++)
            {
                //recuperamos cada caracter del texto 
                char character = textoNumeros[i];
                //convertimos cada caracter a numero
                //int numero = character;
                int numero = Convert.ToInt32(character.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma de " + textoNumeros + " es " + suma;
        }
    }
}
