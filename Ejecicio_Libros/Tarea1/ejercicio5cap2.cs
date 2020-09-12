using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicio_Libros.Tarea1
{
    class ejercicio5cap2
    {
      public void Cambio()
        {

            float Dolar = 0.0f;
            float Euro = 0.0f;
            float Pesos = 0.0f;
            float Cambio = 0.0f;
            float diaCambio = 0.0f;
            string valor = "";

            Console.WriteLine("Digite el precio del dolar:");
            valor = Console.ReadLine();
            Dolar = Convert.ToSingle(valor);

            Console.WriteLine("Digite el precio del euro:");
            valor = Console.ReadLine();
            Euro = Convert.ToSingle(valor);

            Console.WriteLine("Digite la cantidad de dinero a cambia:");
            valor = Console.ReadLine();
            Pesos = Convert.ToSingle(valor);

            Cambio = Dolar * Pesos;
            Console.WriteLine("El cambio de dolar a pesos es:" + Cambio);

            Cambio = Euro * Pesos;
            Console.WriteLine("El cambio de dolar a pesos es:" + Cambio);

            Console.WriteLine("Digite el cambio del dia");
            valor = Console.ReadLine();
            diaCambio = Convert.ToSingle(valor);

            Console.WriteLine("El cambio del dia es:" + diaCambio);

        }
    }
}
