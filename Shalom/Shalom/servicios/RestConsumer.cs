using Shalom.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shalom.servicios
{
    public static class RestConsumer
    {
        public static List<Curso> GetCursos()
        {
            var toret = new List<Curso>
            {
                new Curso("1", "titulo1", "Descripcion", "http://www.centro-shalom.com/fotos//299_1343728282_ByNh.jpg"),
                new Curso("2", "titulo2", "Descripcion", "http://www.centro-shalom.com/fotos//299_1343728282_ByNh.jpg"),
                new Curso("3", "titulo3", "Descripcion", "http://www.centro-shalom.com/fotos//299_1343728282_ByNh.jpg"),
                new Curso("4", "titulo4", "Descripcion", "http://www.centro-shalom.com/fotos//299_1343728282_ByNh.jpg"),
                new Curso("5", "titulo5", "Descripcion", "http://www.centro-shalom.com/fotos//299_1343728282_ByNh.jpg")
            };
            return toret;
        }

    }
}
