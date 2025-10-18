using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class trapecio//cada que se cree la clase cambiar el internal que aparece de default a public
    {
        public int trapecioarea(int base_mayor, int base_menor, int altura) 
        {
            int resul = ((base_mayor + base_menor) * altura) / 2;
            return resul;
        }
        public int trapecioperimetro(int lado1, int lado2, int base_mayor, int base_menor)
        {
            int resul = lado1+lado2+base_mayor+base_menor;
            return resul;
        }  
    }
}
