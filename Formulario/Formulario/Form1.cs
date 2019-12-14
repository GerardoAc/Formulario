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
        public LoginForm()
        {
            InitializeComponent();
    
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
         
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton acceptar");
            if (UsuarioTxt.TextLength == 0)
            {
                LoginErrorProvider.SetError(UsuarioTxt, "Falta Nombre Usuario");
            }
            if (ContraseñaTxt.TextLength == 0) {

                LoginErrorProvider.SetError(ContraseñaTxt, "Falta Contraseña Usuario");
            }
            
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Salir");
        }
    }
}
