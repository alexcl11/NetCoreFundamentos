namespace NetCoreFundamentos
{
    partial class Form17SumarBotones
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
            btnIniciarApp = new Button();
            label1 = new Label();
            txtSuma = new TextBox();
            divBotones = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            divBotones.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciarApp
            // 
            btnIniciarApp.Location = new Point(313, 48);
            btnIniciarApp.Name = "btnIniciarApp";
            btnIniciarApp.Size = new Size(75, 23);
            btnIniciarApp.TabIndex = 0;
            btnIniciarApp.Text = "Iniciar APP";
            btnIniciarApp.UseVisualStyleBackColor = true;
            btnIniciarApp.Click += btnIniciarApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 48);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(171, 48);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 2;
            txtSuma.Text = "0";
            // 
            // divBotones
            // 
            divBotones.Controls.Add(button1);
            divBotones.Controls.Add(button2);
            divBotones.Controls.Add(button3);
            divBotones.Controls.Add(button4);
            divBotones.Controls.Add(button5);
            divBotones.Controls.Add(button6);
            divBotones.Location = new Point(110, 104);
            divBotones.Name = "divBotones";
            divBotones.Size = new Size(200, 100);
            divBotones.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(84, 32);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 61);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(84, 61);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form17SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(divBotones);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Controls.Add(btnIniciarApp);
            Name = "Form17SumarBotones";
            Text = "Form17SumarBotones";
            divBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarApp;
        private Label label1;
        private TextBox txtSuma;
        private FlowLayoutPanel divBotones;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}