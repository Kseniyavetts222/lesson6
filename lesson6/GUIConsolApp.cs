using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6
{
    internal class GUIConsolApp
    {
        public double[] GetArray(double[] array)
        {
            Console.Write($"Введите количество чисел:");
            array = new double[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите число{i}:");
                array[i] = double.Parse(Console.ReadLine());

            }
            return array;


        }
    }
}
   
