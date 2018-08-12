using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
  public  class clsClienteContactos:clsClientesBase
    {

        public clsClienteContactos() {
            _Direccion = new clsClientesDireccion();
        }
        public clsClienteContactos(int pId, string pNombre, string pClave, string pRFC,int pTipoRegimen, string pNombreContacto, string pTelefono1, string pTelefono2, string pEmail, string pCalle, string pNumeroExterior, string pNumeroInterior, string pColonia, string pMunicipio, string pEstado, string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            _Direccion = new clsClientesDireccion();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.Estado = pEstado;
            Direccion.CP = pCP;
        }

       
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Emal { get; set; }

        internal clsClientesDireccion Direccion
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

        private clsClientesDireccion _Direccion;

    }
}
