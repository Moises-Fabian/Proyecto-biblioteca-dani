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
            if (string.IsNullOrEmpty(_vistaPrestamo.Rut))
            {
                _vistaPrestamo.MostrarMensaje("Debe ingresar rut del usuario.");
                return;
            }

            if (_prestamoServicio.ObtenerPrestamosEnProceso().Where(x => x.Rut == _vistaPrestamo.Rut).ToList().Count >= 3)
            {
                _vistaPrestamo.MostrarMensaje($"El cliente con rut {_vistaPrestamo.Rut} sólo puede retirar 3 libros simultáneamente.");
                return;
            }

            if (validarId(_vistaPrestamo.Id) == false)
            {
                _vistaPrestamo.MostrarMensaje("Debe ingresar un Id libro válido.");
                return;
            }

            if (_vistaPrestamo.FechaPrestamo == null || _vistaPrestamo.FechaDevolucion == null)
            {
                _vistaPrestamo.MostrarMensaje("Debe ingresar fecha de préstamo y devolución para el préstamo.");
                return;
            }

            var existeUsuario = _prestamoServicio.ExisteUsuario(_vistaPrestamo.Rut);
            if (existeUsuario == false)
            {
                _vistaPrestamo.MostrarMensaje("El usuario ingresado no existe.");
                return;
            }

            var existeLibro = _prestamoServicio.ExisteLibro(int.Parse(_vistaPrestamo.Id));
            if (existeLibro == false)
            {
                _vistaPrestamo.MostrarMensaje("El id libro ingresado no existe.");
                return;
            }

            var libroDisponible = _prestamoServicio.ExistenciasDisponibles(int.Parse(_vistaPrestamo.Id));

            if (libroDisponible == false)
            {
                _vistaPrestamo.MostrarMensaje("El libro no tiene existencias disponibles.");
                return;
            }

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
                LimpiarCamposPrestamo();
            }
            catch (Exception ex)
            {
                _vistaPrestamo.MostrarMensaje(ex.Message);
            }
        }

        void OnRegistrarDevolucion(object sender, EventArgs e)
        {
            if (validarId(_vistaPrestamo.PrestamoId) == false)
            {
                _vistaPrestamo.MostrarMensaje("Debe ingresar un Id préstamo válido.");
                return;
            }

            var existePrestamo = _prestamoServicio.ExistePrestamo(int.Parse(_vistaPrestamo.PrestamoId));
            if(existePrestamo == false)
            {
                _vistaPrestamo.MostrarMensaje("El préstamo no existe.");
                return;
            }

            var libroDevuelto = _prestamoServicio.LibroDevuelto(int.Parse(_vistaPrestamo.PrestamoId));

            if (libroDevuelto == true)
            {
                _vistaPrestamo.MostrarMensaje("El libro fue devuelto. Intente nuevamente.");
                return;
            }

            _prestamoServicio.RegistrarDevolucion(int.Parse(_vistaPrestamo.PrestamoId));
            _vistaPrestamo.MostrarPrestamos(_prestamoServicio.ObtenerPrestamos());
            LimpiarCamposDevolucion();
        }

        private bool validarId(string id)
        {
            var esIdValido = int.TryParse(id, out int idRegistro);
            if (esIdValido && idRegistro > 0)
            {
                return true;
            }

            return false;
        }

        private void LimpiarCamposPrestamo()
        {
            _vistaPrestamo.Id = "";
            _vistaPrestamo.Rut = "";
        }

        private void LimpiarCamposDevolucion()
        {
            _vistaPrestamo.PrestamoId = "";

        }
    }
}