using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }
        Persona persona = new Persona();
        private void CrearPersona_Click(object sender, EventArgs e)
        {

            persona.Nombre = "Reyes";
            persona.Apellidos = "Majos";
            persona.Edad = 23;
            persona[0] = "Vamos 1";
            persona[1] = "Vamos 2";
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.España;
            persona.Domicilio = new Direccion("Calle 1", "Madrid", 12345);
            persona.DomicilioVacaciones = new Direccion("Calle 2", "Alicante");


            this.lstClases.Items.Add("Nombre: "
                + persona.Nombre
                + " || Apellidos: "
                + persona.Apellidos
                + " || Edad: "
                + persona.Edad
                + " || Género: "
                + persona.Genero
                + " || Nacionalidad: "
                + persona.Nacionalidad);

        }

       

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Albert";
            emp.Apellidos = "Barbas";
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + " €");
            Director dir = new Director();
            dir.Nombre = "Alejandro";
            dir.Apellidos = "Cánovas";
            this.lstClases.Items.Add("Vacas Director: " + dir.GetDiasVacaciones());
            this.lstClases.Items.Add("Director: " + dir.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dir.GetSalarioMinimo() + " €");
        }
    }
}
