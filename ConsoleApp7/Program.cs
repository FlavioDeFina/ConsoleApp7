using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantalla.menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantalla.menuPrincipal();
                        break;
                    case 1:
                        opcion = Pantalla.sumar();
                        break;
                    case 2:
                        opcion = Pantalla.restar();
                        break;
                    case 3:
                        opcion = Pantalla.multiplicar();
                        break;
                    case 4:
                        opcion = Pantalla.dividir();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
