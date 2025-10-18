using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class rectangulo
    {
        public int rectanguloarea() 
        {
            int ladomayor;
            int ladomenor;
            int result;

            Console.Write("\nLado Mayor: ");
            ladomayor = int.Parse(Console.ReadLine());
            Console.Write("Lado menor: ");
            ladomenor = int.Parse(Console.ReadLine());

            result = ladomayor * ladomenor;

            return result;
        }

        public int rectanguloperimetro()
        {
            int ladomayor;
            int ladomenor;
            int result;

            Console.Write("\nLado Mayor: ");
            ladomayor = int.Parse(Console.ReadLine());
            Console.Write("Lado menor: ");
            ladomenor = int.Parse(Console.ReadLine());

            result = 2 * (ladomayor + ladomenor);

            return result;

        }
    }
}
