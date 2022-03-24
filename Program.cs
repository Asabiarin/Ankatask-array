using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankatask_array
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;
            //numbers[6] = 7;
            //numbers[7] = 8;
            //numbers[8] = 9;
            //numbers[9] = 10;


            Console.WriteLine("Tek sayılar");
            for (int i = 1; i < 10; i++)
            {

                
                if (i % 2 == 1)
                {
                    
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("Çift sayılar ");
            for (int i = 1; i < 10; i++)
            {
                
               
                if (i % 2 == 0)
                {
                    
                    Console.WriteLine(i);
                }
            }

           
            Console.ReadLine();
        }
    }
}
