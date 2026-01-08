using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    //LAS ENUMERACIONES ESTAN DENTRO DEL NAMESPACE
    public enum TipoGenero { Masculino, Femenino};
    public enum Paises { España, Francia, Alemania, Portugal};
    public class Persona
    {
        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA Vacío");
        }
        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parámetros");
        }

        #endregion
        #region PROPIEDADES
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                //DEVOLVEMOS UNA DESCRIPCION ALEATORIA DE NUESTRO NUMERO
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero 
        {
            get { return this._Genero; }
            set
            {
                if(value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                else
                {
                    this._Genero = value;
                }
            } 
        }
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //CAMPO DE PROPIEDAD
        private int _Edad;
        public int Edad
        {
            ////DEVOLVEMOS EL VALOR
            //get { return this._Edad; }
            ////ESTABLECEMOS UN VALOR
            //set 
            //{
            //    if(value < 0)
            //    {
            //        this._Edad = 0;
            //    }
            //    else
            //    {
            //        this._Edad = value;
            //    }
            //}
            //DEVOLVEMOS EL VALOR
            get { return this._Edad; }
            //ESTABLECEMOS UN VALOR
            set
            {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }


        #endregion
        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }
        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }
        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }
        #endregion
    }
}
