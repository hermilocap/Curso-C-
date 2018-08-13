using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosBidimensionales
{
    class clsMatrices
    {
        private int[,] Matriz;
        public clsMatrices() {
            Matriz = new int[4, 2];

        }
        public void InicializarMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matriz[i, j] = 1;

                }
            }

        }
        public void ImprimirMatriz()
        {
            //filas
            for (int i = 0; i < 4; i++)
            {
                //columnas
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}", Matriz[i,j]);
                    

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
