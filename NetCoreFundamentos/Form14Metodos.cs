using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }
        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero = numero * 2;

        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.FromArgb(255, 0, 0);
        }
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }
        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //CON REF, LAS DOS VARIABLES APUNTAN AL MISMO ESPACIO DE MEMORIA
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TENEMOS UNA ENUMERACION LLAMADA keys QUE NOS PERMITE 
            //ACCEDER A LOS CODIGOS DEL TECLADO
            //DEBEMOS SABER EL CODIGO ASCII DE LA TECLA BORRAR
            char teclaborrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO??
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=teclaborrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
            
            


        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaborrar = (char)Keys.Back;
            //EXISTE ALGUNA FORMA DE SABER SI UN CHAR ES UN NUMERO??
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaborrar)
            {
                //INDICA SI NOS HACEMOS CARGO DEL EVENTO DE KEY
                e.Handled = true;
            }
        }
    }
}
