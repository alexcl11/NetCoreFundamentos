using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones = new List<Button>();
        List<TextBox> textBoxes = new List<TextBox>();
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            botones = new List<Button>();
            foreach(Control btn in this.Controls)
            {
                if(btn is Button)
                {
                    botones.Add((Button)btn);
                    btn.Click += MultiplicarBotones;
                }
            }
            textBoxes = new List<TextBox>();
            foreach (Control txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    textBoxes.Add((TextBox)txtBox);
                }
            }
            this.textBoxes.Reverse();
        }

        private void MultiplicarBotones(object? sender, EventArgs e)
        {
            Button btnPulsado = (Button)sender;
            int numero = int.Parse(btnPulsado.Text);
            
            foreach(TextBox txtBox in this.textBoxes)
            {
                txtBox.Text = (numero*(this.textBoxes.IndexOf(txtBox)+1)).ToString();
            }
        }
    }
}
