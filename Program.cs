using System;

namespace Producto_de_elementos_adyacentes
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.WriteLine("Producto de elementos adyacentes");
            int[] inputArray = newArray();
            Console.WriteLine("Producto de elementos adyacentes máximo: " + maxAdjacentProd(inputArray));
            Console.ReadKey();
            Console.Clear();
            goto a;
        }

        public static int maxAdjacentProd(int[] InputArray)
        {
            int max = 0;

            for (int i = 1; i < InputArray.Length - 1; i++) 
            {
               int temp = InputArray[i - 1] * InputArray[i]; // Se multiplica el número actual del arreglo con el anterior

                // Si la multiplicación actual es superior o es la primera que se realiza se guarda el resultado
               if (temp > max || i == 1) 
               {
                   max = temp;
               }

               temp = InputArray[i + 1] * InputArray[i]; // Se multiplica el número actual del arreglo con el posterior

               if (temp > max)
               {
                   max = temp;
               }        
            }
            return max;
        }


        public static int[] newArray()
        {
            int ArrayElem = 0;
            Console.Write("Cantidad de elementos en el vector: ");
            ArrayElem = Convert.ToInt32(Console.ReadLine()); // Se asigna el tamaño del arreglo
            int[]tempArray = new int[ArrayElem];
            for (int i = 0; i < tempArray.Length; i++)  // Se ingresan los valores del arreglo
            {
                Console.Write("Valor en la posición {0} del arreglo: ", i);
               tempArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return tempArray;
        }
    }
}
