using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.txtDia.Text);
            int month = int.Parse(this.txtMes.Text);
            int year = int.Parse(this.txtAnio.Text);

            if(month == 1)
            {
                month = 13;
                year = year - 1;
            } else if (month == 2)
            {
                month = 14;
                year = year - 1;
            }

                int mesMasUnoPor3EntreCinco = (month + 1) * 3 / 5;
            int yearEntreCuatro = year / 4;
            int yearEntreCien = year / 100;
            int yearEntreCuatrocientos = year / 400;
            int sumaTotal = day + month * 2 + year + mesMasUnoPor3EntreCinco + yearEntreCuatro - yearEntreCien + yearEntreCuatrocientos + 2;
            int sumaTotalEntreSiete = sumaTotal / 7;
            int numeroDiaSemana = sumaTotal - (sumaTotalEntreSiete * 7);

            string diaSemana = "";

            switch (numeroDiaSemana)
            {
                case 0:
                    diaSemana = "Sábado";
                    break;
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Lunes";
                    break;
                case 3:
                    diaSemana = "Martes";
                    break;
                case 4:
                    diaSemana = "Miércoles";
                    break;
                case 5:
                    diaSemana = "Jueves";
                    break;
                case 6:
                    diaSemana = "Viernes";
                    break;
                default:
                    diaSemana = "NONE";
                    break;
            }

            this.lblMostrar.Text = "El día de la semana es: "+diaSemana;


        }
    }
}
