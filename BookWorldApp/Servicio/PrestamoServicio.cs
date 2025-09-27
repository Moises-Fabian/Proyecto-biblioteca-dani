using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;

namespace BookWorldApp.Servicio
{
    public class PrestamoServicio : IPrestamoServicio
    {
        private readonly List<Prestamo> _prestamos = new List<Prestamo>();
        private readonly List<Prestamo> _prestamosEnProceso = new List<Prestamo>();
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly ILibroServicio _libroServicio;

        public PrestamoServicio(IUsuarioServicio usuarioServicio, ILibroServicio libroServicio)
        {
            _usuarioServicio = usuarioServicio;
            _libroServicio = libroServicio;
        }

        public List<Prestamo> ObtenerPrestamosEnProceso()
        {
            return _prestamosEnProceso;
        }
        public List<Prestamo> ObtenerPrestamos()
        {
            return _prestamos;
        }

        public void AgregarPrestamoEnProceso(string rutUsuario, int idLibro)
        {
            var usuario = _usuarioServicio.ObtenerUsuarios().FirstOrDefault(u => u.Rut == rutUsuario);
            if (usuario == null) return;

            var libro = _libroServicio.ObtenerLibros().FirstOrDefault(l => l.Id == idLibro);
            if (libro == null) return;

            libro.Existencias--;

            var nuevoPrestamo = new Prestamo
            {
                Id = _prestamos.Count > 0 ? _prestamos.Count + 1 :  _prestamosEnProceso.Count + 1,
                Rut = rutUsuario,
                IdLibro = idLibro,
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = null,
                NombreUsuario = usuario.Nombre,
                TituloLibro = libro.Titulo,
                EstadoPrestamo = "En Préstamo"
            };
            _prestamosEnProceso.Add(nuevoPrestamo);
        }

        public void AgregarPrestamo()
        {
            _prestamos.AddRange(_prestamosEnProceso);
            _prestamosEnProceso.Clear();
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == idPrestamo);

            if (prestamo != null) 
            {
                var libro = _libroServicio.ObtenerLibros().FirstOrDefault(l => l.Id == prestamo.IdLibro);
                if (libro != null)
                {
                    libro.Existencias++;

                    prestamo.EstadoPrestamo = "Devuelto";
                }

                prestamo.FechaDevolucion = DateTime.Now;
            }
        }

        public bool ExisteUsuario(string rutUsuario)
        {
            return _usuarioServicio.ObtenerUsuarios().Any(x => x.Rut == rutUsuario);
        }

        public bool ExisteLibro(int idLibro)
        {
            return _libroServicio.ObtenerLibros().Any(x => x.Id == idLibro);
        }

        public bool ExistenciasDisponibles(int idLibro)
        {
            return _libroServicio.ObtenerLibros().Any(x => x.Id == idLibro && x.Existencias > 0);
        }

        public bool ExistePrestamo(int idPrestamo)
        {
            return _prestamos.Any(p => p.Id == idPrestamo);
        }

        public bool LibroDevuelto(int idPrestamo)
        {
            var libro = _prestamos.FirstOrDefault(p => p.Id == idPrestamo);

            if(libro != null)
            {
                if(libro.FechaDevolucion != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
