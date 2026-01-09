using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Schema;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
            // CUANDO HABLAMOS DE RUTAS O DE CARACTERES ESPECIALES 
            // DENTRO DE STRING, TENEMOS DOS FORMAS DE ESCRIBIR DICHOS CARACTERES
            // 1) C:\carpeta\1.txt ESTO NO FUNCIONA
            // UTILIZAR DOBLE BARRA
            // this.Path = "C:\\carpeta\\1.txt";
            // 2) UTILIZAR @ ANTES Y DESPUES DEL STRING
            // this.Path = @"C:\\carpeta\\1.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.Select();
            this.txtNombre.Focus();
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {

            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtFileContent.Text = content;
            string[] nombres = content.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }

            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string content = await reader.ReadToEndAsync();
            //    reader.Close();
            //    this.txtFileContent.Text = content;
            //}
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {

            string content = await this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos Almacenados");

            //// TENEMOS UNA CLASE LLAMADA FileInfo QUE NOS DEVUELVE UN FILE 
            //// Y PODEMOS GENERAR UN WRITER/READER
            //FileInfo file = new FileInfo(this.Path);
            //// CREAMOS EL FICHERO
            //using (TextWriter writer = file.CreateText()) 
            //{
            //    string content = this.GetNombresListBox();
            //    // ESCRIBIMOS EN EL FICHERO
            //    await writer.WriteAsync(content);
            //    // DESPUÉS DE ESCRIBIR EN CUALQUIER FICHERO DEBEMOS LIBERAR LA MEMORIA
            //    // PARA HACERLO FIJO
            //    await writer.FlushAsync();
            //    // CERRAMOS EL FICHERO
            //    writer.Close();
            //    MessageBox.Show("Fichero Almacenado");
            //}
        }

        public async Task<string> GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
