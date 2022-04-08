using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos20
{
    public class Validador
    {
        public static decimal PedirNumeroDecimal(string mensaje)
        {

            decimal valor;

            bool valido = false;

            /*string opcion = mensaje.Replace('.', ',');*/

            string mensajeDos = "\n Si va a ingresar un número decimal ingrese una " + "*,*" + " en vez de " + "*.*"
                                 + " \n Recuerde que de no hacerlo el sistema lo tomará como un número ENTERO";
            string mensajeError = "\n El valor no puede ser vacio y tiene que estar entre el rango del Menu solicitado. ";

            do
            {
               
                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeDos);

                if (!decimal.TryParse(Console.ReadLine(), out valor))
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);

            return valor;
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
