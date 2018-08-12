using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   public class clsClientes
    {
        private int _IdCliente;
        private string _Nombre;
        private string _Apellido;

        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }

            set
            {
                _IdCliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }
    }
}
