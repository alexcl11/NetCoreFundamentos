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
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
                
            }
            if (index == this.lstAlmacen.Items.Count-1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;

        }
    }
}
