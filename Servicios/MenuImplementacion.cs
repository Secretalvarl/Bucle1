using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle1.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero()
        {

            int numero1;

            Console.WriteLine("Escriba un numero <0.");

            numero1 = Convert.ToInt32(Console.ReadLine());

            return numero1;


        }

    }
}
