using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Servicio.Interface;

namespace BookWorldApp.Servicio
{
    public class PrestamoServicio : IPrestamoServicio
    {
        private readonly List<Prestamo> _prestamos = new List<Prestamo>();
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly ILibroServicio _libroServicio;

        public PrestamoServicio(IUsuarioServicio usuarioServicio, ILibroServicio libroServicio)
        {
            _usuarioServicio = usuarioServicio;
            _libroServicio = libroServicio;
        }

        public List<Prestamo> ObtenerTodos()
        {
            return _prestamos;
        }

        public void RealizarPrestamo(string rutUsuario, int idLibro)
        {
            var usuario = _usuarioServicio.ObtenerUsuarios().FirstOrDefault(u => u.Rut == rutUsuario);
            var libro = _libroServicio.ObtenerLibros().FirstOrDefault(l => l.Id == idLibro);

            if (usuario == null) throw new Exception("El usuario no existe.");
            if (libro == null) throw new Exception("El libro no existe.");
            if (libro.Existencias <= 0) throw new Exception("No hay existencias disponibles de este libro.");

            libro.Existencias--;

            var nuevoPrestamo = new Prestamo
            {
                Id = _prestamos.Count > 0 ? _prestamos.Max(p => p.Id) + 1 : 1,
                Rut = rutUsuario,
                IdLibro = idLibro,
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = null,
                NombreUsuario = usuario.Nombre,
                TituloLibro = libro.Titulo,
                EstadoPrestamo = "En Préstamo"
            };
            _prestamos.Add(nuevoPrestamo);
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == idPrestamo);
            if (prestamo == null) throw new Exception("El préstamo no existe.");
            if (prestamo.FechaDevolucion != null) throw new Exception("Este libro ya fue devuelto.");

            var libro = _libroServicio.ObtenerLibros().FirstOrDefault(l => l.Id == prestamo.IdLibro);
            if (libro != null)
            {
                libro.Existencias++;

                prestamo.EstadoPrestamo = "Devuelto";
            }

            prestamo.FechaDevolucion = DateTime.Now;
        }
    }
}
