using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio.Interface
{
    public interface IUsuarioServicio
    {
        List<Usuario> ObtenerTodos();
        void Agregar(Usuario usuario);
        void Editar(Usuario usuarioActualizado);
        void Eliminar(string rut);
        bool Existe(string rut);
    }
}
