using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos20
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            decimal numeroUno;
            decimal numeroDos;

            Validador.Bienvenida();

            numeroUno = Validador.PedirNumeroDecimal("\n Ingrese el primer valor numérico.");
            Console.Clear();
            numeroDos = Validador.PedirNumeroDecimal("\n Ingrese el segundo valor numérico.");
            Console.Clear();


            decimal numeroFinal = Math.Max(numeroUno,numeroDos); 

            Console.Clear();
            Console.WriteLine(" \n Usted Ingreso como primer número el : *" + numeroUno + "*. " +
                              " \n Usted Ingreso como segundo número el : *" + numeroDos + "*. " +
                              " \n\n El mayor de esos 2 números es el: " + numeroFinal);

            Console.WriteLine(" \n Si el resultado no fue el esperado es porque ignoró la recomendación e ingreso" +
                              " un punto en vez de una coma");


            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
