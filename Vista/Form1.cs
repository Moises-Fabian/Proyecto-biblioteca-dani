using BookWorldApp.Presentador;
using BookWorldApp.Vista;
using BookWorldApp.Vista.Interface;

namespace BookWorldApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            IUsuarioVista vista = new Form2();
            UsuarioPresentador presentador = new UsuarioPresentador(vista);

            ((Form)vista).ShowDialog();
        }

        private void btn_biblioteca_Click(object sender, EventArgs e)
        {

        }
    }
}
