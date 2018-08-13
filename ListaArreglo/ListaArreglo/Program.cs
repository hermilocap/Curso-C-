using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            //clsMostrarArrayList mostrar = new clsMostrarArrayList();
            //mostrar.CapturarDatos();
            //mostrar.ImprimirDatos();

            clsMuestraHashMap muestramap;
            muestramap = new clsMuestraHashMap();
            muestramap.AgregarDatos();
            muestramap.Imprimir();

            muestramap.EliminarElementos("0001");
            muestramap.Imprimir();

        }
    }
}
