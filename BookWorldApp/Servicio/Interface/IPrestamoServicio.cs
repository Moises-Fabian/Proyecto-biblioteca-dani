using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Servicio.Interface
{
    public interface IPrestamoServicio
    {
        List<Prestamo> ObtenerPrestamosEnProceso();
        List<Prestamo> ObtenerPrestamos();
        void AgregarPrestamoEnProceso(string rutUsuario, int idLibro);
        void AgregarPrestamo();
        void RegistrarDevolucion(int idPrestamo);

        bool ExisteUsuario(string rutUsuario);
        bool ExisteLibro(int idLibro);
        bool ExistenciasDisponibles(int idLibro);
        bool ExistePrestamo(int idPrestamo);
        bool LibroDevuelto(int idPrestamo);
    }
}
