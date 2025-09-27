using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.Interface;
using System;

namespace BookWorldApp.Presentador
{
    public class PrestamoPresentador
    {
        private readonly IPrestamoVista _vistaPrestamo;
        private readonly IPrestamoServicio _prestamoServicio;

        public PrestamoPresentador(IPrestamoVista vista, IPrestamoServicio prestamoServicio, ILibroServicio libroServicio)
        {
            _vistaPrestamo = vista;
            _prestamoServicio = prestamoServicio;

            _vistaPrestamo.RealizarPrestamoEnProceso += OnRealizarPrestamoEnProceso;
            _vistaPrestamo.RealizarPrestamo += OnRealizarPrestamo;
            _vistaPrestamo.RegistrarDevolucion += OnRegistrarDevolucion;

            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            _vistaPrestamo.MostrarPrestamos(_prestamoServicio.ObtenerPrestamos());

        }

        void OnRealizarPrestamoEnProceso(object sender, EventArgs e)
        {
            _prestamoServicio.AgregarPrestamoEnProceso(_vistaPrestamo.Rut, int.Parse(_vistaPrestamo.Id));
            _vistaPrestamo.MostrarPrestamosEnProceso(_prestamoServicio.ObtenerPrestamosEnProceso());

        }

        void OnRealizarPrestamo(object sender, EventArgs e)
        {
            try
            {
                _prestamoServicio.AgregarPrestamo();
                _vistaPrestamo.MostrarPrestamos(_prestamoServicio.ObtenerPrestamos());
                _vistaPrestamo.MostrarPrestamosEnProceso(_prestamoServicio.ObtenerPrestamosEnProceso());
            }
            catch (Exception ex)
            {
                _vistaPrestamo.MostrarMensaje(ex.Message);
            }
        }

        void OnRegistrarDevolucion(object sender, EventArgs e)
        {
            _prestamoServicio.RegistrarDevolucion(int.Parse(_vistaPrestamo.PrestamoId));
            _vistaPrestamo.MostrarPrestamos(_prestamoServicio.ObtenerPrestamos());
        }
    }
}