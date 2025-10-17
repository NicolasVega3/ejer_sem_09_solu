using System;
using Biblioteca1;

namespace SEMANA9_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo t=new triangulo();
            cuadrado c=new cuadrado();           //estas son instancias para aceder a los metodos que hemos creado en la biblioteca
            int opc1,opc2;
            string conti;

            do
            {
                Console.Clear();
                menu1();
                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc1 = int.Parse(Console.ReadLine());
                    if (opc1 < 0 | opc1 > 4)
                        Console.WriteLine("Error. Ingrese la opcion correcta\n");
                    else 
                        break;
                } while (true);

                switch (opc1) 
                {
                    case 0:return;
                    case 1:

                        opc2 = menu2();

                        switch (opc2) 
                        {
                            case 1:t.area(); break;
                            case 2:t.perimetro(); break;
                            default: Console.WriteLine("\nOpcion no valida"); break;
                        }

                        break;
                    case 2:

                        opc2 = menu2();

                        Console.Write("\nIngrese lado: ");
                        int l = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1: c.area(l); break;
                            case 2: c.perimetro(l); break;
                            default: Console.WriteLine("\nOpcion no valida"); break;
                        }

                        break;
                    case 3: break;
                    case 4: break;
                }
                do 
                {
                    Console.Write("Desea continuar? (s/n): ");
                    conti=Console.ReadLine().ToLower();
                    if (conti != "s" & conti != "n")
                        Console.WriteLine("Error. Ingrese nuevamente 's' o 'n'\n");
                    else break;
                }while (true);
            } while (conti == "s");
        }

        static void menu1() 
        {
            Console.WriteLine("Bienvenidos al calculo de areas y perimetros\n");
            Console.WriteLine("*************** Menú de opcines **************");
            Console.WriteLine("  *              1. Triangulo              *");
            Console.WriteLine("  *              2. Cuadrado               *");
            Console.WriteLine("  *              3. Rectangulo             *");
            Console.WriteLine("  *              4. Trapecio               *");
            Console.WriteLine("  *              0. Salir                  *");
            Console.WriteLine("********************************************\n");
        }
        static int menu2() 
        {
            Console.WriteLine("\n****** Seleccione cálculo *****");
            Console.WriteLine("*         1. Area             *");
            Console.WriteLine("*       2. Perimetro          *");
            Console.WriteLine("*******************************\n");

            Console.Write("Ingrese opcion: ");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }
}
