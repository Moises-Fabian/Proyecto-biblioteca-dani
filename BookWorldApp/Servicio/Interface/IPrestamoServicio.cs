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
        List<Prestamo> ObtenerTodos();
        void RealizarPrestamo(string rutUsuario, int idLibro);
        void RegistrarDevolucion(int idPrestamo);
    }
}
