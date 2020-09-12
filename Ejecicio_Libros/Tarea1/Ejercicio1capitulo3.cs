using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicio_Libros.Tarea1
{
    class Ejercicio1capitulo3
    {
        public void identifica()
        {
            Console.WriteLine("Digite un numero entero ");
            double num = double.Parse(Console.ReadLine());


            if (num % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");

            Console.ReadKey();
        }
    }
}
