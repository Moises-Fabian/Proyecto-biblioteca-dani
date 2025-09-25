using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Vista.Interface;

namespace BookWorldApp.Presentador
{
    public class UsuarioPresentador
    {
        private readonly IUsuarioVista _usuarioVista;
        private readonly List<Usuario> _usuarios;
        public UsuarioPresentador(IUsuarioVista usuarioVista)
        {
            _usuarios = new List<Usuario>();
            _usuarioVista = usuarioVista;
            _usuarioVista.AgregarUsuario += OnAgregarUsuario;
            _usuarioVista.EditarUsuario += OnEditarUsuario;
            _usuarioVista.EliminarUsuario += OnEliminarUsuario;
            _usuarioVista.ObtenerUsuarios += OnObtenerUsuarios;
        }

        public void OnObtenerUsuarios(object sender, EventArgs e)
        {
            _usuarios.Add(new Usuario() { Rut = "11111111-1", Nombre = "Alberto maluenda", Correo = "alberto@gmail.com", Telefono = "+56923456789" });
            _usuarios.Add(new Usuario() { Rut = "1-9", Nombre = "Loreto silva", Correo = "Loreto@gmail.com", Telefono = "+569123456789" });
            _usuarios.Add(new Usuario() { Rut = "19222256-7", Nombre = "Moisés lagos", Correo = "moises@gmail.com", Telefono = "+5691111111" });
            _usuarioVista.MostrarUsuarios(_usuarios);
        }

        public void OnAgregarUsuario(object sender, EventArgs e) 
        {
            bool usuarioExistente = _usuarios.Any(x => x.Rut == _usuarioVista.Rut);

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

            if (nuevoUsuario != null)
            {
                _usuarios.Add(nuevoUsuario);
            }

            _usuarioVista.MostrarUsuarios(_usuarios);
            LimpiarCampos();
        }

        public void OnEditarUsuario(object sender, EventArgs e)
        {
            bool usuarioExistente = _usuarios.Any(x => x.Rut == _usuarioVista.Rut);

            if(usuarioExistente == false)
            {
                _usuarioVista.MostrarMensaje("El Rut ingresado no existe. Intente nuevamente.");
                return;
            }


            if(_usuarios.Count > 0)
            {
                foreach (var item in _usuarios)
                {
                    if(_usuarioVista.Rut == item.Rut)
                    {
                        if (_usuarioVista.Nombre != "" && _usuarioVista.Nombre != null)
                        {
                            item.Nombre = _usuarioVista.Nombre;
                        }

                        if (_usuarioVista.Correo != "" && _usuarioVista.Correo != null)
                        {
                            item.Correo = _usuarioVista.Correo;
                        }

                        if (_usuarioVista.Telefono != "" && _usuarioVista.Telefono != null)
                        {
                            item.Telefono = _usuarioVista.Telefono;
                        }
                    }
                }
            }
            else
            {
                _usuarioVista.MostrarMensaje("No hay usuarios existentes en BD.");
            }

            _usuarioVista.MostrarUsuarios(_usuarios);
            LimpiarCampos();
        }

        public void OnEliminarUsuario(object sender, EventArgs e)
        {
            var usuario = _usuarios.Where(x => x.Rut == _usuarioVista.Rut).FirstOrDefault();

            if(usuario != null)
            {
                _usuarios.Remove(usuario);
                _usuarioVista.MostrarUsuarios(_usuarios);
                LimpiarCampos();
            }
            else
            {
                _usuarioVista.MostrarMensaje($"No hay usuarios existentes con el rut {_usuarioVista.Rut}.");
            }
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
