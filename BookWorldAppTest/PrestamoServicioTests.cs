using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio;
using BookWorldApp.Servicio.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldAppTest
{
    [TestFixture]
    public class PrestamoServicioTests
    {
        [Test]
        public void RealizarPrestamo_ConStockSuficiente_CrearPrestamo()
        {
            var libroConStock = new Libro { Id = 1, Titulo = "Libro de Prueba", Existencias = 5 };
            var usuarioExistente = new Usuario { Rut = "1-9", Nombre = "Usuario de Prueba" };

            var mockUsuarioServicio = new Mock<IUsuarioServicio>();
            var mockLibroServicio = new Mock<ILibroServicio>();

            mockUsuarioServicio.Setup(s => s.ObtenerUsuarios()).Returns(new List<Usuario> { usuarioExistente });
            mockLibroServicio.Setup(s => s.ObtenerLibros()).Returns(new List<Libro> { libroConStock });

            var prestamoServicio = new PrestamoServicio(mockUsuarioServicio.Object, mockLibroServicio.Object);

            prestamoServicio.RealizarPrestamo(usuarioExistente.Rut, libroConStock.Id);

            var prestamos = prestamoServicio.ObtenerTodos();
            Assert.That(prestamos.Count, Is.EqualTo(1));
            Assert.That(libroConStock.Existencias, Is.EqualTo(4));
            Assert.That(prestamos[0].EstadoPrestamo, Is.EqualTo("En Préstamo"));
        }

        [Test] 
        public void RealizarPrestamo_SinStock()
        {
            var libroSinStock = new Libro { Id = 2, Titulo = "Libro Agotado", Existencias = 0 };
            var usuario = new Usuario { Rut = "2-7" };

            var mockUsuarioServicio = new Mock<IUsuarioServicio>();
            var mockLibroServicio = new Mock<ILibroServicio>();
            mockUsuarioServicio.Setup(s => s.ObtenerUsuarios()).Returns(new List<Usuario> { usuario });
            mockLibroServicio.Setup(s => s.ObtenerLibros()).Returns(new List<Libro> { libroSinStock });

            var prestamoServicio = new PrestamoServicio(mockUsuarioServicio.Object, mockLibroServicio.Object);

            var ex = Assert.Throws<Exception>(() => prestamoServicio.RealizarPrestamo(usuario.Rut, libroSinStock.Id));
            Assert.That(ex.Message, Is.EqualTo("No hay existencias disponibles de este libro."));
        }
    }
}
