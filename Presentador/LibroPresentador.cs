using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Presentador
{
    public class LibroPresentador
    {
        private readonly ILibroVista _libroVista;
        private readonly ILibroService _libroService;
        public LibroPresentador(ILibroVista libroVista, ILibroService libroService)
        {
            _libroService = libroService;
            _libroVista = libroVista;

            _libroVista.AgregarLibro += AgregarLibros;
            _libroVista.EditarLibro += OnEditarLibro;
            _libroVista.EliminarLibro += OnEliminarLibro;
            _libroVista.ObtenerLibros += OnObtenerLibros;
        }

        public void OnObtenerLibros(object sender, EventArgs e)
        {
            _libroVista.MostrarLibros(_libroService.ObtenerLibros());
        }

        public void AgregarLibros(object sender, EventArgs e)
        {

            bool libroRepetido = _libroService.ExisteLibro(_libroVista.Titulo, _libroVista.Autor);

            if (libroRepetido == true)
            {
                _libroVista.MostrarMensaje("El libro ya existe en el sistema.");
                return;
            }
            var nuevoLibro = new Libro()
            {
                Id = _libroService.ObtenerLibros().Count + 1,
                Titulo = _libroVista.Titulo,
                Autor = _libroVista.Autor,
                Aniopublicacion = _libroVista.AnioPublicacion,
                Genero = _libroVista.Genero
            };

            if (string.IsNullOrWhiteSpace(_libroVista.Titulo))
            {
                _libroVista.MostrarMensaje("El Titulo no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_libroVista.Autor))
            {
                _libroVista.MostrarMensaje("El Autor no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_libroVista.AnioPublicacion))
            {
                _libroVista.MostrarMensaje("El año de publicación no puede estar vacío.");
                return;
            }

            _libroService.AgregarLibro(nuevoLibro);
            _libroVista.MostrarLibros(_libroService.ObtenerLibros());
            LimpiarCampos();
        }

        public void OnEditarLibro(object sender, EventArgs e)
        {
            bool libroExiste = _libroService.ObtenerLibros().Any(x => x.Id == int.Parse(_libroVista.Id));

            if (libroExiste == false)
            {
                _libroVista.MostrarMensaje("El libro a editar no existe en el sistema.");
                return;
            }

            var libroActualizado = new Libro()
            {
                Id = int.Parse(_libroVista.Id),
                Titulo = _libroVista.Titulo,
                Autor = _libroVista.Autor,
                Aniopublicacion = _libroVista.AnioPublicacion,
                Genero = _libroVista.Genero
            };

            _libroService.EditarLibro(libroActualizado);
            _libroVista.MostrarLibros(_libroService.ObtenerLibros());
            LimpiarCampos();
        }

        public void OnEliminarLibro(object sender, EventArgs e)
        {
            var libroExiste = _libroService.ObtenerLibros().Any(x => x.Id == int.Parse(_libroVista.Id));

            if (!libroExiste)
            {
                _libroVista.MostrarMensaje($"No hay libros existentes con el id {_libroVista.Id}.");
                return;
            }

            _libroService.EliminarLibro(int.Parse(_libroVista.Id));
            _libroVista.MostrarLibros(_libroService.ObtenerLibros());
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _libroVista.Id = "";
            _libroVista.Titulo = "";
            _libroVista.Autor = "";
            _libroVista.AnioPublicacion = "";
            _libroVista.Genero = "";
        }
    }
}
