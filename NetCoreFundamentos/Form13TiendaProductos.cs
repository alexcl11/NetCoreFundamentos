using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.lstAlmacen.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtNuevoProducto.Text;
            this.lstTienda.Items.Add(producto);
            this.txtNuevoProducto.Focus();
            this.txtNuevoProducto.SelectAll();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.SelectedItems[i]);
                this.lstTienda.Items.Remove(this.lstTienda.Items[i]);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.Items.Count - 1; i >= 0; i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);
                this.lstTienda.Items.Remove(this.lstTienda.Items[i]);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            string aux = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.SelectedItem = this.lstAlmacen.Items[this.lstAlmacen.SelectedIndex - 1];
            this.lstAlmacen.Items[this.lstAlmacen.SelectedIndex - 1] = aux;
        }
    }
}
