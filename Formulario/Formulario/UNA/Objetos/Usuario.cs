using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nombre,string contrasenna)
        {
            this.Nombre = nombre;
            this.Contrasenna = contrasenna;
        }
        public string Nombre
        {
            get;
            set;
        }
        public string Contrasenna
        {
            get;
            set;
        }
        public string Validacion
        {
            get;
            set;
        }
    }
}
