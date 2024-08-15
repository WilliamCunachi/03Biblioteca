using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Biblioteca.Models
{
    public class Libros
    {
        public int libro_id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string año_publicacion { get; set; }
        public int Correo { get; set; }
    }
}
