namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtElemento = new TextBox();
            btnInsertarElemento = new Button();
            btnEliminarElemento = new Button();
            btnBorrarTodo = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(164, 125);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 94);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(417, 127);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(113, 23);
            txtElemento.TabIndex = 3;
            // 
            // btnInsertarElemento
            // 
            btnInsertarElemento.Location = new Point(417, 156);
            btnInsertarElemento.Name = "btnInsertarElemento";
            btnInsertarElemento.Size = new Size(113, 23);
            btnInsertarElemento.TabIndex = 4;
            btnInsertarElemento.Text = "Insertar Elemento";
            btnInsertarElemento.UseVisualStyleBackColor = true;
            btnInsertarElemento.Click += btnInsertarElemento_Click;
            // 
            // btnEliminarElemento
            // 
            btnEliminarElemento.Location = new Point(417, 185);
            btnEliminarElemento.Name = "btnEliminarElemento";
            btnEliminarElemento.Size = new Size(113, 23);
            btnEliminarElemento.TabIndex = 5;
            btnEliminarElemento.Text = "Eliminar Elemento";
            btnEliminarElemento.UseVisualStyleBackColor = true;
            btnEliminarElemento.Click += btnEliminarElemento_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(417, 214);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(113, 23);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(168, 242);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 7;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(164, 278);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 8;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminarElemento);
            Controls.Add(btnInsertarElemento);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label label2;
        private TextBox txtElemento;
        private Button btnInsertarElemento;
        private Button btnEliminarElemento;
        private Button btnBorrarTodo;
        private Label lblItem;
        private Label lblIndex;
    }
}