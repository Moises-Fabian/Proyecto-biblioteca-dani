using BookWorldApp.Modelo.Entidades;
using BookWorldApp.Presentador;
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

namespace BookWorldApp.Vista
{
    public partial class Form2 : Form, IUsuarioVista
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Rut { get => campo_rut.Text; set => campo_rut.Text = value; }
        public string Nombre { get => campo_nombre.Text; set => campo_nombre.Text = value; }
        public string Correo { get => campo_correo.Text; set => campo_correo.Text = value; }
        public string Telefono { get => campo_telefono.Text; set => campo_telefono.Text = value; }

        public event EventHandler ObtenerUsuarios;
        public event EventHandler AgregarUsuario;
        public event EventHandler EditarUsuario;
        public event EventHandler EliminarUsuario;

        private void Form2_Load(object sender, EventArgs e)
        {
            ObtenerUsuarios?.Invoke(this, EventArgs.Empty);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarUsuarios(List<Usuario> usuarios)
        {
            usuariosDataGridView.DataSource = null;
            usuariosDataGridView.DataSource = usuarios;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarUsuario?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_eliminar(object sender, EventArgs e)
        {
            EliminarUsuario?.Invoke(this, EventArgs.Empty);
        }
    }
}
