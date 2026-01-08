using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo += 200; 
        }

        //METODO SOBREESCRITO
        
        public override int GetDiasVacaciones()
        {
            //LLAMAMOS AL METODO DEL EMPLEADO
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacasEmpleado + 8;
        }

    }
}
