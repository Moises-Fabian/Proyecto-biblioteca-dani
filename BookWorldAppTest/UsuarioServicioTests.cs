using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio;
using NUnit.Framework;
using System.Linq;

namespace BookWorldAppTest
{
    [TestFixture]
    public class UsuarioServicioTests
    {
        private UsuarioServicio _usuarioServicio;

        [SetUp]
        public void Setup()
        {
            _usuarioServicio = new UsuarioServicio();
        }

        [Test]
        public void AgregarUsuario_AnadirloALaLista()
        {
            var nuevoUsuario = new Usuario { Rut = "12345678-9", Nombre = "Usuario Nuevo" };

            _usuarioServicio.AgregarUsuario(nuevoUsuario);

            var usuarios = _usuarioServicio.ObtenerUsuarios();
            Assert.That(usuarios.Count, Is.EqualTo(4));
            Assert.That(usuarios.Any(u => u.Rut == "12345678-9"), Is.True);
        }

        [Test]
        public void EditarUsuariUsuarioExiste_ActualizarSusDatos()
        {
            var rutExistente = "1-9";
            var usuarioActualizado = new Usuario { Rut = rutExistente, Nombre = "Nombre Editado", Correo = "editado@correo.com", Telefono = "12345" };

            _usuarioServicio.EditarUsuario(usuarioActualizado);

            var usuario = _usuarioServicio.ObtenerUsuarios().First(u => u.Rut == rutExistente);
            Assert.That(usuario.Nombre, Is.EqualTo("Nombre Editado"));
            Assert.That(usuario.Correo, Is.EqualTo("editado@correo.com"));
        }

        [Test]
        public void EliminarUsuarioExiste_QuitarloDeLaLista()
        {
            var rutAEliminar = "11111111-1";
            var totalInicial = _usuarioServicio.ObtenerUsuarios().Count;

            _usuarioServicio.EliminarUsuario(rutAEliminar);

            var usuarios = _usuarioServicio.ObtenerUsuarios();
            Assert.That(usuarios.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(usuarios.Any(u => u.Rut == rutAEliminar), Is.False);
        }
    }
}