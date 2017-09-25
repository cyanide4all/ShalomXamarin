using System;
using System.Collections.Generic;
using System.Text;

namespace Shalom.modelo
{
    public class Curso
    {
        public String BDKey { get; private set; }
        public String Titulo { get; private set; }
        public String Descripcion { get; private set; }
        public String ImagenURL { get; private set; }

        public Curso(string bDKey, string title, string desc, string img_url)
        {
            BDKey = bDKey;
            Titulo = title;
            Descripcion = desc;
            ImagenURL = img_url;
        }
    }
}
