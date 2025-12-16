namespace NetCoreFundamentos
{
    partial class Form06Email
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
            txtEmail = new TextBox();
            btnValidar = new Button();
            lblValidacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 59);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(164, 136);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.Location = new Point(167, 172);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(0, 15);
            lblValidacion.TabIndex = 3;
            // 
            // FormPracticaEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidacion);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "FormPracticaEmail";
            Text = "FormPracticaEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidar;
        private Label lblValidacion;
    }
}