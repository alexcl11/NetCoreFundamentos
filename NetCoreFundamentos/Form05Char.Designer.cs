namespace NetCoreFundamentos
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            txtSimbolos = new TextBox();
            txtPuntuacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRunASCII = new Button();
            SuspendLayout();
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(237, 105);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 71);
            txtLetras.TabIndex = 0;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(420, 105);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 71);
            txtNumeros.TabIndex = 1;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(237, 206);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(100, 73);
            txtSimbolos.TabIndex = 2;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(420, 206);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(100, 73);
            txtPuntuacion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 87);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 179);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Símbolos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 179);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Puntuación";
            // 
            // btnRunASCII
            // 
            btnRunASCII.Location = new Point(340, 313);
            btnRunASCII.Name = "btnRunASCII";
            btnRunASCII.Size = new Size(75, 23);
            btnRunASCII.TabIndex = 8;
            btnRunASCII.Text = "Run ASCII";
            btnRunASCII.UseVisualStyleBackColor = true;
            btnRunASCII.Click += btnRunASCII_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(btnRunASCII);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(txtNumeros);
            Controls.Add(txtLetras);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLetras;
        private TextBox txtNumeros;
        private TextBox txtSimbolos;
        private TextBox txtPuntuacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRunASCII;
    }
}