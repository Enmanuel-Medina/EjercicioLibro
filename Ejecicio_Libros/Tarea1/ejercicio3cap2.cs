using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicio_Libros.Tarea1
{
    class ejercicio3cap2
    {
        public void perimetro (){

            const int Valor = 180;
            float Pi = 0.0f;
            float grado = 0;
            string Resultado = "";
            float Cambio = 0.0f;

            Console.WriteLine("Digite el Grado:");
            Resultado = Console.ReadLine();
            grado = Convert.ToSingle(Resultado);

            Console.WriteLine("Digite el valor del Pi:");
            Resultado = Console.ReadLine();
            Pi = Convert.ToSingle(Resultado);

            Cambio = grado * Pi / Valor;

            Console.WriteLine("El cambia a Radianes es:" + Cambio);






        }
    }
}
