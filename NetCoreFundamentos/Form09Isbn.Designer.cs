namespace NetCoreFundamentos
{
    partial class Form09Isbn
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
            txtIsbn = new TextBox();
            btnComprobarIsbn = new Button();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(45, 83);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 23);
            txtIsbn.TabIndex = 1;
            // 
            // btnComprobarIsbn
            // 
            btnComprobarIsbn.Location = new Point(45, 126);
            btnComprobarIsbn.Name = "btnComprobarIsbn";
            btnComprobarIsbn.Size = new Size(90, 23);
            btnComprobarIsbn.TabIndex = 2;
            btnComprobarIsbn.Text = "Comprobar";
            btnComprobarIsbn.UseVisualStyleBackColor = true;
            btnComprobarIsbn.Click += btnComprobarIsbn_Click;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(48, 170);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(0, 15);
            lblValidar.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidar);
            Controls.Add(btnComprobarIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnComprobarIsbn;
        private Label lblValidar;
    }
}