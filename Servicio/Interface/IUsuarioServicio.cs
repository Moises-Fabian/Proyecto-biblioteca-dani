using BookWorldApp.Modelo.Entidades;

namespace BookWorldApp.Servicio.Interface
{
    public interface IUsuarioServicio
    {
        List<Usuario> ObtenerTodos();
        void AgregarUsuario(Usuario usuario);
        void EditarUsuario(Usuario usuarioActualizado);
        void EliminarUsuario(string rut);
        bool ExisteUsuario(string rut);
    }
}
