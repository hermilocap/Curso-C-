﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClaseAbstracta
{
    class clsArchivos:inSalida
    {
        public void imprimirCliente(clsAbsCliente cliente) {
            try
            {
                StreamWriter ar = new StreamWriter(@"C:\archivo.log", true);

                ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
                ar.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void imprimirDireccion(clsClientesDireccion direccion) {
            StreamWriter ar = new StreamWriter(@"C:\Users\hermilocap\Desktop\archivo.log", true);
            ar.Close();
        }
    }
}
