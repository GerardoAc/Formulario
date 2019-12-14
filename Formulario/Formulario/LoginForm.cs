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
    public partial class LoginForm : Form
    {

        Usuario usuario=new Usuario();
        private List<Usuario> listaUsuarios;

        internal List<Usuario> ListaUsuarios
        { get => listaUsuarios; set => listaUsuarios = value; }

        public LoginForm()
        {
            InitializeComponent();

        }

        void ValidarUsuario()
        {
            foreach (Usuario s in listaUsuarios)
            {
                if (UsuarioTxt.Text == s.Nombre)
                {
                    usuario = s;
                }
            }

        }
               

        
        public Object RetornarUsuarioLogueado()
        {
            return usuario;
        }
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            
            if (UsuarioTxt.TextLength == 0)
            {
                LoginErrorProvider.SetError(UsuarioTxt, "Falta Nombre Usuario");
            }
            else
            {

                if (ContraseñaTxt.TextLength == 0)
                {

                    LoginErrorProvider.SetError(ContraseñaTxt, "Falta Contraseña Usuario");
                }
                else
                {
                    ValidarUsuario();
                    
                    if (UsuarioTxt.Text== usuario.Nombre)
                    {
                       
                        if (ContraseñaTxt.Text == usuario.Contrasenna)
                        {
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else { MessageBox.Show("Contraseña incorrecta"); }

                    }
                    else { MessageBox.Show("Usuario incorrecto"); }
                }
                
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Salir");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
