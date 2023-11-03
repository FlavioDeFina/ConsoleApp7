using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Pantalla
    {
        public static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "======================\n" +
                            "Las cuatro operaciones\n" +
                            "======================\n" +
                            "1: Suma\n" +
                            "2: Resta\n" +
                            "3: Multiplicación\n" +
                            "4: División\n" +
                            "5: Salir\n" +
                            "======================\n" +
                            "Ingresa una opción: ");
            return getOpcion();
        }


        public static int sumar()
        {
            Console.Clear();
            cabeceraDePantalla("Sumando ...\n");
            int suma = getsuma();

            Console.Write("============\n" +
                        "Resultado " + suma + "\n");

            pieDePantalla();

            int opcion = getOpcion();
            if (opcion == 2) return 0;
            return opcion;
        }



        public static int restar()
        {
            Console.Clear();
            cabeceraDePantalla("Restando ...\n");
            int resta = getResta();
            Console.Write("============\n" +
                        "Resultado " + resta + "\n");

            pieDePantalla();

            int opcion = getOpcion();
            if (opcion == 1) return 2;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int multiplicar()
        {
            Console.Clear();
            cabeceraDePantalla("Multiplicando ...\n");

            int producto = getMultiplicacion();

            Console.Write("============\n" +
                        "Resultado " + producto + "\n");

            pieDePantalla();

            int opcion = getOpcion();
            if (opcion == 1) return 3;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int dividir()
        {

            Console.Clear();
            cabeceraDePantalla("Dividiendo ...\n");
            int cociente = getDivision();
            Console.Write("============\n" +
                        "Resultado " + cociente + "\n");
            pieDePantalla();

            int opcion = getOpcion();
            if (opcion == 1) return 4;
            if (opcion == 2) return 0;
            return opcion;
        }

        private static int getsuma()
        {
            int numero1 = operaciones.getEntero("Numero 1: ");
            int numero2 = operaciones.getEntero("Numero 2: ");
            return operaciones.sumar(numero1, numero2);
        }
        private static int getResta()
        {
            int numero1 = operaciones.getEntero("Numero 1: ");
            int numero2 = operaciones.getEntero("Numero 2: ");
            return operaciones.restar(numero1, numero2);
        }

        private static int getMultiplicacion()
        {
            int numero1 = operaciones.getEntero("Numero 1: ");
            int numero2 = operaciones.getEntero("Numero 2: ");
            return operaciones.multiplicar(numero1, numero2);
        }

        private static int getDivision()
        {
            int numero1 = operaciones.getEntero("Numero 1: ");
            int numero2 = operaciones.getEntero("Numero 2: ");
            return operaciones.dividir(numero1, numero2);
        }

        private static void cabeceraDePantalla(string texto)
        {
            Console.Write("" +
                                    "===========================================\n" +
                                    texto +
                                    "===========================================\n");
        }

        private static void pieDePantalla()
        {
            Console.Write("============================================\n" +
                                    "1: Limpiar | 2: Regresar Menú |\n" +
                                    "============================================\n" +
                                    "Ingresa una opción: ");
        }

        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
