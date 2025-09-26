using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.Interface;
using System;

namespace BookWorldApp.Presentador
{
    public class PrestamoPresentador
    {
        private readonly IPrestamoVista _vista;
        private readonly IPrestamoServicio _prestamoServicio;

        public PrestamoPresentador(IPrestamoVista vista, IPrestamoServicio prestamoServicio, ILibroServicio libroServicio)
        {
            _vista = vista;
            _prestamoServicio = prestamoServicio;

            _vista.RealizarPrestamo += OnRealizarPrestamo;
            _vista.RegistrarDevolucion += OnRegistrarDevolucion;

            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            _vista.MostrarPrestamos(_prestamoServicio.ObtenerTodos());
        }

        void OnRealizarPrestamo(object sender, EventArgs e)
        {
            try
            {
                _prestamoServicio.RealizarPrestamo(_vista.Rut, int.Parse(_vista.Id));
                _vista.MostrarPrestamos(_prestamoServicio.ObtenerTodos());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        void OnRegistrarDevolucion(object sender, EventArgs e)
        {
            _prestamoServicio.RegistrarDevolucion(int.Parse(_vista.Id));
            _vista.MostrarPrestamos(_prestamoServicio.ObtenerTodos());
        }
    }
}