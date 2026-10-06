using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lesson6
{
    public class calculator
    {
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public double minus(double num1 , double num2) 
        {
            return num1 - num2;
        }
        public double Multply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double div(double num1, double num2)
        {
            return (num1 / num2);
        }
        public double Exdiv(double num1, double num2)
        {
            return num1 % num2;
        }
        public double percent(double Total, float precnt)
        {
            return Total * precnt / 100;
        }
        public double deprcent(double Total, float value)
        {
            return Total / value * 100;
        }
        public double Count(double[]numbers)
        {
            return numbers.Length;                                                                                                                 
        }
        public double Max(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                if (result < number)
                {
                    result = number;
                }
            }
            return result; //hi kcosha
        }
        public double Min(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                if (result > number)
                {
                    result = number;
                }
            }
            return result;

        }
        public double Factorial(double n)
        {
            double result = 1;
            for (int i=2;i<n;i++)
            {
                result *= i;
            }
            return result;
        }
        public double[] SortAscending(double[] numbers)
        {
            double[] result = (double[])numbers.Clone();
            Array.Sort(result);
            return result;
        }
        public double[] SortDescending(double[] numbers)
        {
            double[] result = (double[])numbers.Clone();
            Array.Sort(result);
            Array.Reverse(result);
            return result;
        }
      
    }
}
