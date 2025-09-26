using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio
{
    public class LibroServicio : ILibroServicio
    {
        private readonly List<Libro> _libros = new List<Libro>();

        public LibroServicio()
        {
            _libros.AddRange(new Libro[]
            {
                new Libro
                {
                    Id = 1,
                    Titulo = "Cien años de lucha",
                    Autor = "Gabriel García Márquez",
                    AnioPublicacion = "1967",
                    Genero = "Realismo mágico"
                },
                new Libro
                {
                    Id = 2,
                    Titulo = "1984",
                    Autor = "George Orwell",
                    AnioPublicacion = "1949",
                    Genero = "Ciencia ficción distópica"
                },
                new Libro
                {
                    Id = 3,
                    Titulo = "El señor de los anillos",
                    Autor = "J.R.R. Tolkien",
                    AnioPublicacion = "1954",
                    Genero = "Fantasía épica"
                }
            });
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
                libroExistente.Autor = libro.Autor;
                libroExistente.AnioPublicacion = libro.AnioPublicacion;
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
        public bool ExisteLibro(string titulo, string autor)
        {
            return _libros.Any(x => x.Titulo == titulo && x.Autor == autor);
        }
    }
}
