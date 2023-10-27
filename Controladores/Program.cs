using Bucle1.Servicios;

namespace Bucle1.Controladores
{
    class Program
    {

        static void Main(string[] args)
        {
            int numero1;
            int suma;
            int operacion;

            MenuInterfaz alpha = new MenuImplementacion();
            numero1 = alpha.pedirNumero();

            SumaInterfaz omega = new SumaImplementacion();
            suma = omega.sumaDigitos();

            for (int i = numero1 ; i >= 0; i--)
            {
               suma = suma + i;

                Console.WriteLine("Todas sumas : " + suma);
            }

            Console.WriteLine("El resultado es : " + suma);
        }
    }
}
