using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio
{
    public class UsuarioServicio: IUsuarioServicio
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public UsuarioServicio()
        {
            _usuarios.Add(new Usuario() { Rut = "11111111-1", Nombre = "Alberto Maluenda", Correo = "alberto@gmail.com", Telefono = "+56923456789" });
            _usuarios.Add(new Usuario() { Rut = "1-9", Nombre = "Loreto Silva", Correo = "loreto@gmail.com", Telefono = "+569123456789" });
            _usuarios.Add(new Usuario() { Rut = "19222256-7", Nombre = "Moisés Lagos", Correo = "moises@gmail.com", Telefono = "+5691111111" });
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _usuarios;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void EditarUsuario(Usuario usuarioActualizado)
        {
            var usuarioExistente = _usuarios.FirstOrDefault(u => u.Rut == usuarioActualizado.Rut);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nombre = usuarioActualizado.Nombre;
                usuarioExistente.Correo = usuarioActualizado.Correo;
                usuarioExistente.Telefono = usuarioActualizado.Telefono;
            }
        }

        public void EliminarUsuario(string rut)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Rut == rut);
            if (usuario != null)
            {
                _usuarios.Remove(usuario);
            }
        }

        public bool ExisteUsuario(string rut)
        {
            return _usuarios.Any(u => u.Rut == rut);
        }
    }
}
