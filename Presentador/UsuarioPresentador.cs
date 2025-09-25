using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.Interface;

namespace BookWorldApp.Presentador
{
    public class UsuarioPresentador
    {
        private readonly IUsuarioVista _usuarioVista;
        private readonly IUsuarioServicio _usuarioServicio;
        public UsuarioPresentador(IUsuarioVista usuarioVista, IUsuarioServicio usuarioServicio)
        {
            _usuarioVista = usuarioVista;
            _usuarioServicio = usuarioServicio;
            _usuarioVista.AgregarUsuario += OnAgregarUsuario;
            _usuarioVista.EditarUsuario += OnEditarUsuario;
            _usuarioVista.EliminarUsuario += OnEliminarUsuario;
            _usuarioVista.ObtenerUsuarios += OnObtenerUsuarios;
        }

        public void OnObtenerUsuarios(object sender, EventArgs e)
        {
            _usuarioVista.MostrarUsuarios(_usuarioServicio.ObtenerTodos());
        }

        public void OnAgregarUsuario(object sender, EventArgs e) 
        {
            bool usuarioExistente = _usuarioServicio.ExisteUsuario(_usuarioVista.Rut);

            if (usuarioExistente == true)
            {
                _usuarioVista.MostrarMensaje("El rut ingresado ya existe en el sistema.");
                return;
            }

            var nuevoUsuario = new Usuario()
            {
                Rut = _usuarioVista.Rut,
                Nombre = _usuarioVista.Nombre,
                Correo = _usuarioVista.Correo,
                Telefono = _usuarioVista.Telefono
            };

            if (string.IsNullOrWhiteSpace(nuevoUsuario.Nombre))
            {
                _usuarioVista.MostrarMensaje("El nombre no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nuevoUsuario.Correo))
            {
                _usuarioVista.MostrarMensaje("El correo no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nuevoUsuario.Telefono))
            {
                _usuarioVista.MostrarMensaje("El teléfono no puede estar vacío.");
                return;
            }

            _usuarioServicio.AgregarUsuario(nuevoUsuario);
            _usuarioVista.MostrarUsuarios(_usuarioServicio.ObtenerTodos());
            LimpiarCampos();
        }

        public void OnEditarUsuario(object sender, EventArgs e)
        {
            bool usuarioExistente = _usuarioServicio.ExisteUsuario(_usuarioVista.Rut);

            if (usuarioExistente == false)
            {
                _usuarioVista.MostrarMensaje("El Rut ingresado no existe. Intente nuevamente.");
                return;
            }

            var usuarioActualizado = new Usuario
            {
                Rut = _usuarioVista.Rut,
                Nombre = _usuarioVista.Nombre,
                Correo = _usuarioVista.Correo,
                Telefono = _usuarioVista.Telefono
            };

            _usuarioServicio.EditarUsuario(usuarioActualizado);
            _usuarioVista.MostrarUsuarios(_usuarioServicio.ObtenerTodos());
            LimpiarCampos();
        }

        public void OnEliminarUsuario(object sender, EventArgs e)
        {
            var usuarioExiste = _usuarioServicio.ExisteUsuario(_usuarioVista.Rut);

            if (!usuarioExiste)
            {
                _usuarioVista.MostrarMensaje($"No hay usuarios existentes con el rut {_usuarioVista.Rut}.");
                return;
            }

            _usuarioServicio.EliminarUsuario(_usuarioVista.Rut);
            _usuarioVista.MostrarUsuarios(_usuarioServicio.ObtenerTodos());
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _usuarioVista.Rut = "";
            _usuarioVista.Nombre = "";
            _usuarioVista.Correo = "";
            _usuarioVista.Telefono = "";
        }

    }
}
