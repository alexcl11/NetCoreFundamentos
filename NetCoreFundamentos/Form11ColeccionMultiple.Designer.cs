namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIndex = new Label();
            lblItem = new Label();
            btnBorrarTodo = new Button();
            btnEliminarElemento = new Button();
            btnInsertarElemento = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            btnVisualizarSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(190, 269);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 17;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(194, 233);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 16;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(443, 216);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(136, 23);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminarElemento
            // 
            btnEliminarElemento.Location = new Point(443, 176);
            btnEliminarElemento.Name = "btnEliminarElemento";
            btnEliminarElemento.Size = new Size(136, 34);
            btnEliminarElemento.TabIndex = 14;
            btnEliminarElemento.Text = "Eliminar Seleccionados";
            btnEliminarElemento.UseVisualStyleBackColor = true;
            btnEliminarElemento.Click += btnEliminarElemento_Click;
            // 
            // btnInsertarElemento
            // 
            btnInsertarElemento.Location = new Point(443, 147);
            btnInsertarElemento.Name = "btnInsertarElemento";
            btnInsertarElemento.Size = new Size(136, 23);
            btnInsertarElemento.TabIndex = 13;
            btnInsertarElemento.Text = "Insertar Elemento";
            btnInsertarElemento.UseVisualStyleBackColor = true;
            btnInsertarElemento.Click += btnInsertarElemento_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(443, 118);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(136, 23);
            txtElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "Elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 85);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(190, 116);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 9;
            // 
            // btnVisualizarSeleccionados
            // 
            btnVisualizarSeleccionados.Location = new Point(443, 245);
            btnVisualizarSeleccionados.Name = "btnVisualizarSeleccionados";
            btnVisualizarSeleccionados.Size = new Size(136, 23);
            btnVisualizarSeleccionados.TabIndex = 18;
            btnVisualizarSeleccionados.Text = "Seleccionados";
            btnVisualizarSeleccionados.UseVisualStyleBackColor = true;
            btnVisualizarSeleccionados.Click += btnVisualizarSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualizarSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminarElemento);
            Controls.Add(btnInsertarElemento);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnBorrarTodo;
        private Button btnEliminarElemento;
        private Button btnInsertarElemento;
        private TextBox txtElemento;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
        private Button btnVisualizarSeleccionados;
    }
}