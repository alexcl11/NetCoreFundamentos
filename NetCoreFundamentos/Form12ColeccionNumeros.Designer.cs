namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            label1 = new Label();
            btnGenerarNumeros = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            txtImpares = new TextBox();
            txtPares = new TextBox();
            label4 = new Label();
            txtSuma = new TextBox();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(116, 94);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(130, 154);
            lstNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Números";
            // 
            // btnGenerarNumeros
            // 
            btnGenerarNumeros.Location = new Point(320, 77);
            btnGenerarNumeros.Name = "btnGenerarNumeros";
            btnGenerarNumeros.Size = new Size(113, 23);
            btnGenerarNumeros.TabIndex = 2;
            btnGenerarNumeros.Text = "Generar Números";
            btnGenerarNumeros.UseVisualStyleBackColor = true;
            btnGenerarNumeros.Click += btnGenerarNumeros_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(320, 114);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(113, 23);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 155);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 238);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Impares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(366, 230);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 6;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(366, 191);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 199);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Pares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(366, 155);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 9;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSuma);
            Controls.Add(txtPares);
            Controls.Add(label4);
            Controls.Add(txtImpares);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarNumeros);
            Controls.Add(label1);
            Controls.Add(lstNumeros);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Label label1;
        private Button btnGenerarNumeros;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private TextBox txtImpares;
        private TextBox txtPares;
        private Label label4;
        private TextBox txtSuma;
    }
}