using Bucle1.Servicios;

namespace Bucle1.Controladores
{
    class Program
    {

        static void Main(string[] args)
        {
            int numero1;
            int suma = 0;

            MenuInterfaz alpha = new MenuImplementacion();
            numero1 = alpha.pedirNumero();

            SumaInterfaz omega = new SumaImplementacion();
            suma = omega.sumaDigitos();

            for (int i = numero1 ; numero1 >= 0; numero1--)
            {
               suma = suma + numero1;

                Console.WriteLine( "El resultado es : " + suma );

            }

        }
    }
}
