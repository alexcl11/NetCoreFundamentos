namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            CrearPersona = new Button();
            btnCrearEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 51);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(12, 79);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(681, 184);
            lstClases.TabIndex = 1;
            // 
            // CrearPersona
            // 
            CrearPersona.Location = new Point(20, 293);
            CrearPersona.Name = "CrearPersona";
            CrearPersona.Size = new Size(108, 36);
            CrearPersona.TabIndex = 2;
            CrearPersona.Text = "Crear Persona";
            CrearPersona.UseVisualStyleBackColor = true;
            CrearPersona.Click += CrearPersona_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(134, 293);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(121, 35);
            btnCrearEmpleado.TabIndex = 3;
            btnCrearEmpleado.Text = "Crear Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 360);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(CrearPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button CrearPersona;
        private Button btnCrearEmpleado;
    }
}