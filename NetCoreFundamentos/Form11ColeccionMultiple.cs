using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //LA LISTA TENDRA SELECCION MULTIPLE
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnVisualizarSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            //VISUALIZAMOS LOS INDICES SELECCIONADOS
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblItem.Text = items.Trim(',');
            this.lblIndex.Text = indices.Trim(',');
        }

        private void btnInsertarElemento_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            //QUIERO ELIMINAR LOS ELEMENTOS SELECCIONADOS
            //PARA LAS ACCIONES SOBRE LAS COLECCIONES SIEMPRE 
            //CON BUCLES CONTADOR
            //VOY A UTILIZAR EL METODO RemoveAt POR LO QUE RECORREMOS
            //LA COLECCION SelectedIndices
            //DEBEMOS DE ELIMINAR DE FORMA INVERSA PARA QUE LOS INDICES NO 
            //AFECTEN A CADA ELEMENTO ELIMINADO. DEL ULTIMO AL PRIMER ELEMENTO
            for (int i = this.lstElementos.SelectedIndices.Count-1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                //ELIMINAMOS DE LA COLECCION
                this.lstElementos.Items.RemoveAt(index);               
            }
        }
    }
}
