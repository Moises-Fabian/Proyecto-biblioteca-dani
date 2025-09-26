using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Vista.Interface
{
    public interface ILibroVista
    {
        string Id { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
        string AnioPublicacion { get; set; }
        string Genero { get; set; }
        string Existencias { get; set; }

        event EventHandler ObtenerLibros;
        event EventHandler AgregarLibro;
        event EventHandler EditarLibro;
        event EventHandler EliminarLibro;
        void MostrarLibros(List<Libro> libros);
        void MostrarMensaje(string mensaje);
    }
}
