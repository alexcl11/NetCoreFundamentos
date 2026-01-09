namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtEdad = new TextBox();
            label3 = new Label();
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 97);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(49, 115);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(49, 170);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 152);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(219, 100);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(92, 23);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(219, 133);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(92, 23);
            btnGuardarClase.TabIndex = 8;
            btnGuardarClase.Text = "Guardar Clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(219, 165);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(92, 28);
            btnExaminar.TabIndex = 23;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(379, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 263);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private Label label3;
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}