using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    class clsEmpleados
    {
        //contructor: es publico no regresa nigun tipo y tiene el mismo nombre de una clase
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.5m;
            Edad = 0;
        }

        string _Nombre;
        public decimal SueldoDiario;
        public int Edad;

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

        public decimal CalculaSalario(int numeroDias) {
            return SueldoDiario * numeroDias;
        }

    }
}
