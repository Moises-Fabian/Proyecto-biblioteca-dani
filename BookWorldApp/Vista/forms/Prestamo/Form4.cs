using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Presentador;
using BookWorldApp.Servicio;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista.forms.Libro;
using BookWorldApp.Vista.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorldApp.Vista.forms.Prestamo
{
    public partial class Form4 : Form, IPrestamoVista
    {
        private readonly ILibroServicio _libroServicio;
        private readonly IUsuarioServicio _usuarioServicio;
        public Form4(ILibroServicio libroServicio, IUsuarioServicio usuarioServicio)
        {
            InitializeComponent();
            _libroServicio = libroServicio;
            _usuarioServicio = usuarioServicio;
        }

        public string Rut { get => campo_rut.Text; set => campo_rut.Text = value; }
        public string Id { get => campo_id_libro.Text; set => campo_id_libro.Text = value; }
        public DateTime FechaPrestamo { get => campo_fecha_prestamo.Value; set => campo_fecha_prestamo.Value = value; }
        public DateTime FechaDevolucion { get => campo_fecha_devolucion.Value; set => campo_fecha_devolucion.Value = value; }
        public string PrestamoId { get => campo_id_prestamo.Text; set => campo_id_prestamo.Text = value; }

        public event EventHandler RealizarPrestamo;
        public event EventHandler RegistrarDevolucion;
        public event EventHandler RealizarPrestamoEnProceso;

        public void MostrarPrestamosEnProceso(List<Modelo.Entidades.Prestamo> prestamosEnProceso)
        {
            prestamoEnProcesodataGridView.DataSource = null;
            prestamoEnProcesodataGridView.DataSource = prestamosEnProceso;
        }

        public void MostrarPrestamos(List<Modelo.Entidades.Prestamo> prestamos)
        {
            prestamosDataGridView.DataSource = null;
            prestamosDataGridView.DataSource = prestamos;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //ObtenerPrestamos?.Invoke(this, EventArgs.Empty);
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            RealizarPrestamo?.Invoke(this, EventArgs.Empty);
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            RegistrarDevolucion?.Invoke(this, EventArgs.Empty);
        }

        private void btn_existencias_Click(object sender, EventArgs e)
        {
            ILibroVista vista = new Form3();
            LibroPresentador presentador = new LibroPresentador(vista, _libroServicio);
            ((Form)vista).ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            RealizarPrestamoEnProceso?.Invoke(this, EventArgs.Empty);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            IUsuarioVista vista = new Form2();
            UsuarioPresentador presentador = new UsuarioPresentador(vista, _usuarioServicio);
            ((Form)vista).ShowDialog();
        }
    }
}
