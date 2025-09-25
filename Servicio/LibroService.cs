using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio
{
    public class LibroService : ILibroService
    {
        public List<Libro> _libros = new List<Libro>();

        public LibroService()
        {
            
        }

        public List<Libro> ObtenerLibros()
        {
            return _libros;
        }

        public void AgregarLibro(Libro libro)
        {
            _libros.Add(libro);
        }

        public void EditarLibro(Libro libro)
        {
            var libroExistente = _libros.FirstOrDefault(x => x.Id == libro.Id);

            if (libroExistente != null) {
                libroExistente.Titulo = libro.Titulo;
                libroExistente.autor = libro.autor;
                libroExistente.Aniopublicacion = libro.Aniopublicacion;
                libroExistente.Genero = libro.Genero;
            }
        }

        public void EliminarLibro(int id)
        {
            var libro = _libros.FirstOrDefault(x => x.Id == id);
            if (libro != null)
            {
                _libros.Remove(libro);
            }
        }
    }
}
