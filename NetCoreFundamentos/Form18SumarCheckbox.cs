using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();
            foreach (CheckBox checkbox in this.panelCheckbox.Controls)
            {
                this.checkboxes.Add(checkbox);
                checkbox.CheckedChanged += SumarRestarNumeros;
            }
        }

        private void SumarRestarNumeros(object? sender, EventArgs e)
        {
            CheckBox checkboxSeleccionado = (CheckBox)sender;
            if (checkboxSeleccionado.Checked)
            {
                CheckBox checkBoxPulsado = (CheckBox)sender;
                int numero = int.Parse(checkBoxPulsado.Text);
                int suma = int.Parse(this.txtSuma.Text);
                suma += numero;
                this.txtSuma.Text = suma.ToString();
            }
            else
            {
                CheckBox checkBoxPulsado = (CheckBox)sender;
                int numero = int.Parse(checkBoxPulsado.Text);
                int suma = int.Parse(this.txtSuma.Text);
                suma -= numero;
                this.txtSuma.Text = suma.ToString();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox checkBox in this.checkboxes)
            {
                int aleat = random.Next(1, 50);
                checkBox.Text = aleat.ToString();
            }
        }
    }
}
