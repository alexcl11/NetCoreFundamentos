namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            btnCambiarPosicion = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEjeX = new TextBox();
            txtEjeY = new TextBox();
            lblCambiarPosicion = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtAzul = new TextBox();
            txtVerde = new TextBox();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(77, 256);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(90, 48);
            btnCambiarPosicion.TabIndex = 0;
            btnCambiarPosicion.Text = "Cambiar posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 85);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Eje X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 167);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Eje Y";
            // 
            // txtEjeX
            // 
            txtEjeX.Location = new Point(77, 118);
            txtEjeX.Name = "txtEjeX";
            txtEjeX.Size = new Size(100, 23);
            txtEjeX.TabIndex = 3;
            // 
            // txtEjeY
            // 
            txtEjeY.Location = new Point(77, 212);
            txtEjeY.Name = "txtEjeY";
            txtEjeY.Size = new Size(100, 23);
            txtEjeY.TabIndex = 4;
            // 
            // lblCambiarPosicion
            // 
            lblCambiarPosicion.AutoSize = true;
            lblCambiarPosicion.Location = new Point(402, 167);
            lblCambiarPosicion.Name = "lblCambiarPosicion";
            lblCambiarPosicion.Size = new Size(129, 15);
            lblCambiarPosicion.TabIndex = 8;
            lblCambiarPosicion.Text = "Cambiame de posicion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 32);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 32);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "Azul";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 32);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Verde";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(203, 29);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 12;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(387, 29);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 13;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(559, 29);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 14;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(704, 32);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(75, 23);
            btnCambiarColor.TabIndex = 15;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(txtVerde);
            Controls.Add(txtAzul);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCambiarPosicion);
            Controls.Add(txtEjeY);
            Controls.Add(txtEjeX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiarPosicion);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiarPosicion;
        private Label label1;
        private Label label2;
        private TextBox txtEjeX;
        private TextBox txtEjeY;
        private Label lblCambiarPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtAzul;
        private TextBox txtVerde;
        private Button btnCambiarColor;
    }
}