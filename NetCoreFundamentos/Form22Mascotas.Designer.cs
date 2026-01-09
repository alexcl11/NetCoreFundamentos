namespace NetCoreFundamentos
{
    partial class Form22Mascotas
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            btnNuevaMascota = new Button();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 115);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(36, 142);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(126, 23);
            txtRaza.TabIndex = 3;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(32, 192);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(130, 29);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(32, 236);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(130, 30);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(36, 284);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(130, 30);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 42);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(266, 71);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(205, 244);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form22Mascotas";
            Text = "Form22Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnNuevaMascota;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Label label3;
        private ListBox lstMascotas;
    }
}