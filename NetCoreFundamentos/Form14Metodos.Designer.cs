namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            lblRaton = new Label();
            label2 = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(139, 260);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(75, 23);
            btnDobleValor.TabIndex = 0;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(139, 316);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(129, 23);
            btnDobleReferencia.TabIndex = 1;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(139, 371);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(129, 23);
            btnObjetoReferencia.TabIndex = 2;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(139, 96);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(139, 162);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 5;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.MenuHighlight;
            lblRaton.Location = new Point(407, 274);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(216, 120);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "label2";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 203);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(513, 203);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 8;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(513, 174);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 10;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 174);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 9;
            label3.Text = "Sólo Números";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeros);
            Controls.Add(label3);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Label lblRaton;
        private Label label2;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label3;
    }
}