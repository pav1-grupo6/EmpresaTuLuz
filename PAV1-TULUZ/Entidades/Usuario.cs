using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_TULUZ.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string Pass;

        public Usuario(string nombreUsuario, string pass)
        {
            NombreUsuario = nombreUsuario;
            Pass = pass;
        }

        public string Nombre
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }

        public string Password
        {
            get { return Pass; }
            set { Pass = value; }
        }
    }
}
