using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicio_Libros.Tarea1
{
    class ejercico1_cap2
    {
        public void ejrecicio1()
        {
            float perimetro = 0.0f;
            float Apotema = 0.0f;
            float area = 0.0f;
            string valor = "";

            Console.WriteLine("Digite el valor del perimetro");
            valor = Console.ReadLine();

            perimetro = Convert.ToSingle(valor);

            Console.WriteLine("Digite el valor del apotema");
            valor = Console.ReadLine();

            Apotema = Convert.ToSingle(valor);

            area = perimetro * Apotema / 2;

            Console.WriteLine("El area es:" + area);
        }
    }
}
