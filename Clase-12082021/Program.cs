using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12082021
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamado al metodo loops 
            loops();

            Console.ReadLine();
        }

        //Bucles
        public static void loops()
        {
            
            //Escribir un cilo que permita capturar los elementos a
            //almacenar  en el arreglo de numbers con un tamaño de 10 
            //calcular el promedio de los numeros almacenados en el array
            int[] numbers = new int[10];
            int suma = 0;
            /* numbers[0] = n;
             numbers[1] = n;
             numbers[2] = n;*/
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valor para el elemento {0}: ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());

             
               
            }
            //ciclo while 
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i+1;
            }
            Console.WriteLine("Imprime Elementos con DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (10 < numbers.Length);

            Console.WriteLine("Imprime elementos con FOR - Arreglo Ordenado");
            Array.Sort(numbers);
            for (int j = 0; j< numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

                suma = suma + numbers[j];
                Console.WriteLine(suma);

            }

            Console.WriteLine("Imprime Elementos con FOREACH");
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("El valor promedio es de: {0}", suma/(numbers.Length));
        }


    }
}
