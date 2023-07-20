using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        public static void Main()
        {
            int[] ar = new int[100];
            int i, n, sum = 0;


            Console.Write(" total number of elemnts in the array list is :");
            n = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Input elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine("sum of the array is : " + sum);

        }



      
        }
    }


