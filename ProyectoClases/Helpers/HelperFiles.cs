using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS DOS METODOS: LEER Y ESCRIBIR
        // LOS METODOS DEBEN SER ASINCRONOS
        // EN LOS METODOS DE CLASE, NO GRÁFICOS, DEBEMOS UTILIZAR
        // LA CLASE PARA METODOS ASÍNCRONOS
        // NO SE UTILIZA VOID
        // 1) si es un void, se utiliza Task
        // 2) si es un return utilizamos Task<ClaseReturn>
        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }
        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using(TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
