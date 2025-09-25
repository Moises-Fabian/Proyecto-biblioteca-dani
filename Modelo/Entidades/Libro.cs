using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Modelo.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string autor { get; set; }
        public int Aniopublicacion { get; set; }
        public string Genero { get; set; }
    }
}
