using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class triangulo
    {
        public void area()
        {
            Console.Write("\nIngrese base: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese altura: ");
            int h= int.Parse(Console.ReadLine());
            Console.WriteLine("\nArea: " + (b * h) / 2);
        }
        public void perimetro() 
        {
            Console.Write("\nIngrese lado 1: ");
            int l1= int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPerimetro: " + (l1 + l2 + l3));
        }
    }
}
