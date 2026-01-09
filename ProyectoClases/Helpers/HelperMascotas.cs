using System;
using System.Collections.Generic;
using System.Text;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        // QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelperFiles helper;
        private string path;
        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        //CONVERTIR LA LISTA A STRING
        public string ConvertirListaString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        //CONVERTIR String A LISTA
        public void ConvertirStringLista(string data)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            string[] datosMascotas = data.Split("@");
            foreach (string datoMascota in datosMascotas)
            {
                // SEPARAMOS LAS PROPIEDADES
                string[] propiedades = datoMascota.Split(",");
                //CONVERTIMOS EL TRISTE STRING EN OBJETOS
                Mascota mascota = new Mascota(propiedades[0], propiedades[1]);
                this.Mascotas.Add(mascota);
            }
        }

        // EL PROGRAMADOR ESCRIBE write Y GUARDAMOS LAS MASCOTAS

        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCIONA A STRING
            string data = this.ConvertirListaString();
            //ESCRIBIMOS LOS DATOS EN FILE
            await this.helper.WriteFileAsync(this.path, data);
        }

        // EL PROGRAMADOR ESCRIBE read Y LEEMOS UN STRING Y RELLENAMOS LA COLECCION

        public async Task ReadMascotasAsync()
        {
            // LEEMOS EL FICHERO DE MASCOTAS
            string data = await this.helper.ReadFileAsync(this.path);
            // CONVERTIMOS EL STRING EN LIST
            this.ConvertirStringLista(data);
        }
    }
}
