namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTexto = new Label();
            lblTiempo = new Label();
            btnInvertirStringBuilder = new Button();
            btnInvertirString = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(91, 82);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(141, 96);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(89, 54);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(143, 15);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Copie texto para trabajar: ";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(92, 202);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(273, 84);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(172, 23);
            btnInvertirStringBuilder.TabIndex = 3;
            btnInvertirStringBuilder.Text = "Invertir String Builder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(273, 130);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(172, 23);
            btnInvertirString.TabIndex = 4;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvertirString);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(lblTiempo);
            Controls.Add(lblTexto);
            Controls.Add(txtTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label lblTexto;
        private Label lblTiempo;
        private Button btnInvertirStringBuilder;
        private Button btnInvertirString;
    }
}