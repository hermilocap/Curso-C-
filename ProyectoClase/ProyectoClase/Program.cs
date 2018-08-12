using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Hermilo";
            empleado.SueldoDiario = 12.5m;
            //modulidad: deifinicar elemento basico es decir un objeto
            //
            //interface-establece los elementos basico de un objeto   para presentarlos  a otro y poder utilizarlo

            decimal total;
            total = empleado.CalculaSalario(30);

            Console.WriteLine("El mensual del empleado "+empleado.Nombre);
            Console.WriteLine("es "+total.ToString("C"));
            Console.ReadKey();

        }

    }
}
