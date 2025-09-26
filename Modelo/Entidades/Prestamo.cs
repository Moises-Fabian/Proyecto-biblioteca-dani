using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Modelo.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string NombreUsuario { get; set; }
        public int IdLibro { get; set; }
        public string TituloLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string EstadoPrestamo { get; set; }
    }
}
