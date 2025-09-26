using BookWorldApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldApp.Vista.Interface
{
    public interface IPrestamoVista
    {
        string Rut { get; set; }
        string Id { get; set; }
        DateTime FechaPrestamo { get; set; }
        DateTime FechaDevolucion { get; set; }

        event EventHandler RealizarPrestamo;
        event EventHandler RegistrarDevolucion;
        void MostrarPrestamos(List<Prestamo> prestamos);
        void MostrarMensaje(string mensaje);
    }
}
