using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            string email = this.txtEmail.Text;
            if (email.Contains('@') && email.Contains('.'))
            {
                string sinArrova = email.Remove(email.IndexOf('@'), 1);
                bool tieneOtraArrova = sinArrova.Contains('@');
                if (tieneOtraArrova)
                {
                    MessageBox.Show("Tiene más de una arrova", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.lblValidacion.Text = "Email Inválido";
                    return;
                }

                string postArrova = email.Substring(email.IndexOf('@'));
                if (!postArrova.Contains('.'))
                {
                    MessageBox.Show("Falta un punto después de la arrova", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.lblValidacion.Text = "Email Inválido";
                    return;
                }
                string dominio = postArrova.Substring(postArrova.IndexOf('.'));
                if (dominio.Length <= 2 || dominio.Length > 3)
                {
                    MessageBox.Show("el dominio debe tener entre 2 y 3 caracteres", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.lblValidacion.Text = "Email Inválido";
                    return;
                }

                this.lblValidacion.Text = "Email válido";

            } else
            {
                MessageBox.Show("El email introducido tiene un formato inválido", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lblValidacion.Text = "Email Inválido";
            }
        }

        
    }
}
