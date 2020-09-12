using System;
using System.Collections.Generic;
using System.Text;

namespace Ejecicio_Libros.Tarea1
{
    class ejercicio4capitulo3
    {
        public void Dias()
        {
            string valor = "";
            int opcion = 0;

            Console.WriteLine("Escoja un numero del 1 al 7");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Marte");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
    }
}
