using BookWorldApp.Presentador;
using BookWorldApp.Servicio;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista;
using BookWorldApp.Vista.forms.Libro;
using BookWorldApp.Vista.forms.Prestamo;
using BookWorldApp.Vista.Interface;
using System.Collections.Generic;

namespace BookWorldApp
{
    public partial class Form1 : Form
    {
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly IPrestamoServicio _prestamoServicio;
        private readonly ILibroServicio _libroServicio;
        public Form1()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
            _prestamoServicio = new PrestamoServicio(_usuarioServicio, _libroServicio);
            _libroServicio = new LibroServicio();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            IUsuarioVista vista = new Form2();
            UsuarioPresentador presentador = new UsuarioPresentador(vista, _usuarioServicio);

            ((Form)vista).ShowDialog();
        }

        private void btn_libro_Click(object sender, EventArgs e)
        {
            ILibroVista vista = new Form3();
            LibroPresentador presentador = new LibroPresentador(vista, _libroServicio);

            ((Form)vista).ShowDialog();
        }

        private void btn_prestamos_Click(object sender, EventArgs e)
        {
            IPrestamoVista vista = new Form4();
            var presentador = new PrestamoPresentador(vista, _prestamoServicio, _libroServicio);
            ((Form)vista).ShowDialog();
        }
    }
}
