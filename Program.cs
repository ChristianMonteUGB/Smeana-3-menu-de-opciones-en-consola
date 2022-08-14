using System;

namespace Smeana_3_menu_de_opciones_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una opcion\n" +
                "\n1-Opcion para If"+
                "\n2-Opcion para For"+
                "\n3-Opcion para While"+
                "\n4-Opcion para Dowhile"+
                "\n5-Salir\n");

            int p1 = 0;

            p1 = Convert.ToInt16 (Console.ReadLine());

            switch (p1){
                case 1:
                    Console.WriteLine("la opcion If ha sido seleccionada");
                    break;
                case 2:
                    Console.WriteLine("la opcion For ha sido seleccionada");
                    break;
                case 3:
                    Console.WriteLine("la opcion While ha sido seleccionada");
                    break;
                case 4:
                    Console.WriteLine("la opcion Do while  ha sido seleccionada");
                    break;
                case 5:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.WriteLine("Elija una opcion");
                    break;
            }
            Console.ReadKey();
        }
    
    }

}
