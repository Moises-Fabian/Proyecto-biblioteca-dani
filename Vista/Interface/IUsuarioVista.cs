using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Vista.Interface
{
    public interface IUsuarioVista
    {
        string Rut { get; set; }
        string Nombre { get; set; }
        string Correo { get; set; }
        string Telefono { get; set; }

        event EventHandler ObtenerUsuarios;
        event EventHandler AgregarUsuario;
        event EventHandler EditarUsuario;
        event EventHandler EliminarUsuario;
        void MostrarUsuarios(List<Usuario> usuarios);
        void MostrarMensaje(string mensaje);
    }
}
