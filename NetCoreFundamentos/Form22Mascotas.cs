using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace NetCoreFundamentos
{
    public partial class Form22Mascotas : Form
    {
        HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }
        public void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre + " - " + mascota.Raza);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string raza = txtRaza.Text;
            Mascota mascota = new Mascota(nombre, raza);
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if(index != -1)
            {
                Mascota mascota = this.helper.Mascotas[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
