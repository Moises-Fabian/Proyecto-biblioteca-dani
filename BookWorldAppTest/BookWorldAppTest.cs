using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio;
using NUnit.Framework;
using System.Linq;

namespace BookWorldAppTest
{
    [TestFixture]
    public class LibroServicioTests
    {
        private LibroServicio _libroServicio;

        [SetUp]
        public void Setup()
        {
            _libroServicio = new LibroServicio();
        }

        [Test]
        public void AgregarLibro_CuandoLibroEsValido_AnadirloALaLista()
        {
            var nuevoLibro = new Libro { Id = 4, Titulo = "Nuevo Libro", Autor = "Nuevo Autor", Existencias = 10, AnioPublicacion = 2025 };

            _libroServicio.AgregarLibro(nuevoLibro);

            var libros = _libroServicio.ObtenerLibros();
            Assert.That(libros.Count, Is.EqualTo(4));
            Assert.That(libros.Any(l => l.Id == 4), Is.True);
        }

        [Test]
        public void EditarLibro_CuandoLibroExiste_DeberiaActualizarSusDatos()
        {
            var libroActualizado = new Libro { Id = 2, Titulo = "Título Editado", Autor = "Autor Editado", Existencias = 99 };

            _libroServicio.EditarLibro(libroActualizado);

            var libro = _libroServicio.ObtenerLibros().First(l => l.Id == 2);
            Assert.That(libro.Titulo, Is.EqualTo("Título Editado"));
            Assert.That(libro.Existencias, Is.EqualTo(99));
        }

        [Test]
        public void EliminarLibro_CuandoLibroExiste_DeberiaQuitarloDeLaLista()
        {
            var idAEliminar = 3;
            var totalInicial = _libroServicio.ObtenerLibros().Count;

            _libroServicio.EliminarLibro(idAEliminar);

            var libros = _libroServicio.ObtenerLibros();
            Assert.That(libros.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(libros.Any(l => l.Id == idAEliminar), Is.False);
        }
    }
}