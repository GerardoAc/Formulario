using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class DashboardForm : Form
    {
        LoginForm login = new LoginForm();
        Usuario usuario = new Usuario();
        List<Usuario> listaUsuarios = new List<Usuario>();

        public DashboardForm()
        {
            InitializeComponent();
            CrearUsuario();

           
           
            
           
           

        }
        public void CrearUsuario()
        {
            usuario.Nombre = "x";
            usuario.Contrasenna = "1";
            listaUsuarios.Add(usuario);
            login.ListaUsuarios = listaUsuarios;

        }
        public void DefenirUsuario()
        {
            usuario = (Usuario)login.RetornarUsuarioLogueado();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.Show();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                DefenirUsuario();
                tsNombreUsurio.Text = usuario.Nombre;
            }
            else
            {
                this.Close();
            }
        }
    }
}
