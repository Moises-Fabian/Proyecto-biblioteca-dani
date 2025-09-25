using BookWorldApp.Presentador;
using BookWorldApp.Servicio;
using BookWorldApp.Servicio.Interface;
using BookWorldApp.Vista;
using BookWorldApp.Vista.Interface;

namespace BookWorldApp
{
    public partial class Form1 : Form
    {
        private readonly IUsuarioServicio _usuarioServicio;
        public Form1()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            IUsuarioVista vista = new Form2();
            UsuarioPresentador presentador = new UsuarioPresentador(vista, _usuarioServicio);

            ((Form)vista).ShowDialog();
        }

        private void btn_biblioteca_Click(object sender, EventArgs e)
        {

        }
    }
}
