using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miane_araye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[50];
            for (int i = 0; i < 50; i++)
            {
             Console.Write("element {0} = ", i + 1);

              array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Calc(array);
        }
        private static void Calc(double[] array)
        {
            for (int i = 1; i <= 48; i++)
            {
                array[i] = (array[i - 1] + array[i] + array[i + 1]) / 3;
            }
            for (int i = 0; i <= 49; i++)
            {
                Console.WriteLine("new element {0} = {1}", i + 1, array[i]);
            }
        }
    }
}
