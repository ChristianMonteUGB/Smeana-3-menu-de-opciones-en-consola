using System;

namespace Smeana_3_menu_de_opciones_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("menu de opciones tarea semana 3");
            System.Console.WriteLine("estructuras de control basicas");

            System.Console.ReadKey();

            int repetir;

            
            do
            {
                Console.Clear();
                menu_primero();

                System.Console.WriteLine("Escriba 1 para repetir");
                System.Console.WriteLine("escriba 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);
        }

        static void menu_primero()
        {
            string opc;
            int opcionint;


            Console.WriteLine("Elige una opcion\n" +
                "\n1-Opcion para If" +
                "\n2-Opcion para For" +
                "\n3-Opcion para While" +
                "\n4-Opcion para Dowhile" +
                "\n5-Salir\n");

            System.Console.WriteLine("elige un numero");
            opc = Console.ReadLine();
            opcionint = Int32.Parse(opc);



            switch (opcionint)
            {
                case 1:
                    variable_if();

                    break;

                case 2:
                    variable_for();

                    break;

                case 3:
                    variable_while();

                    break;

                case 4:
                    variable_dowhile();

                    break;
                case 5:
                    salir();
                    
                    break;
                default:
                    Console.WriteLine("Elija una opcion");
                    break;
            }
            Console.ReadKey();
        }


        static void variable_if()
        {
            System.Console.WriteLine("ejemplo if");
        }

        static void variable_for()
        {
            System.Console.WriteLine("ejemplo for");
        }

        static void variable_while()
        {
            System.Console.WriteLine("ejemplo while");
        }

        static void variable_dowhile()
        {
            System.Console.WriteLine("ejemplo Do While");
        }

        static void salir()
        {
            System.Console.WriteLine("Cerrando consola");
            Environment.Exit(0);
        }

    }
}
