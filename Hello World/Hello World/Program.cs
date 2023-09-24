using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 5, 1, 5 };
            Console.WriteLine("Hello World");
            int maxNum = 0;
            int partition = 0;

            Console.WriteLine("Teri maa ki chut santoshi");


            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        maxNum = array[i];
                    }
                    else
                    {
                        maxNum = array[j];
                    }
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
