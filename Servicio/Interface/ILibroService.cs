using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio.Interface
{
    public interface ILibroService
    {
        public List<Libro> ObtenerLibros();
        public void AgregarLibro(Libro libro);
        public void EditarLibro(Libro libro);
        public void EliminarLibro(int id);
    }
}
