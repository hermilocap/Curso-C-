using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   public class clsClientesVentas:clsClientes
    {
        private string _RFC;
        private string _Direccion;
        private string _Colonia;
        private string _Municipio;
        private bool _EsCredito;

        public string RFC
        {
            get
            {
                return _RFC;
            }

            set
            {
                _RFC = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Colonia
        {
            get
            {
                return _Colonia;
            }

            set
            {
                _Colonia = value;
            }
        }

        public string Municipio
        {
            get
            {
                return _Municipio;
            }

            set
            {
                _Municipio = value;
            }
        }

        public bool EsCredito
        {
            get
            {
                return _EsCredito;
            }

            set
            {
                _EsCredito = value;
            }
        }
    }
}
