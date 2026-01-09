namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            label3 = new Label();
            txtEdad = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 150);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 14;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(45, 168);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 13;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(45, 113);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(45, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 41);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(213, 59);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(139, 139);
            lstMascotas.TabIndex = 16;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(417, 72);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(116, 35);
            btnLeerMascotas.TabIndex = 17;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(417, 113);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(116, 39);
            btnGuardarMascotas.TabIndex = 18;
            btnGuardarMascotas.Text = "Guardar Mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(44, 205);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(101, 30);
            btnNuevaMascota.TabIndex = 19;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(577, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(417, 168);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(116, 33);
            btnExaminar.TabIndex = 21;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 248);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtEdad;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}