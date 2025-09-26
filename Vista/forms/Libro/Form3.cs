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

namespace BookWorldApp.Vista.forms.Libro
{
    public partial class Form3 : Form, ILibroVista
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string Id { get => campo_id_libro.Text; set => campo_id_libro.Text = value; }
        public string Titulo { get => campo_titulo.Text; set => campo_titulo.Text = value; }
        public string Autor { get => campo_autor.Text; set => campo_autor.Text = value; }
        public string AnioPublicacion { get => campo_anio.Text; set => campo_anio.Text = value; }
        public string Genero { get => campo_genero.Text; set => campo_genero.Text = value; }
        public string Existencias { get => campo_existencias.Text; set => campo_existencias.Text = value; }

        public event EventHandler ObtenerLibros;
        public event EventHandler AgregarLibro;
        public event EventHandler EditarLibro;
        public event EventHandler EliminarLibro;

        private void Form3_Load(object sender, EventArgs e)
        {
            ObtenerLibros?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarLibros(List<Modelo.Entidades.Libro> libros)
        {
            librosDataGridView.DataSource = null;
            librosDataGridView.DataSource = libros;
        }

        private void btn_agregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro?.Invoke(this, EventArgs.Empty);
        }

        private void btn_editarLibro_Click(object sender, EventArgs e)
        {
            EditarLibro?.Invoke(this, EventArgs.Empty);
        }

        private void btn_eliminarLibro_Click(object sender, EventArgs e)
        {
            EliminarLibro?.Invoke(this, EventArgs.Empty);
        }
        
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
