using System;
using System.Data;
using System.Runtime.InteropServices;

namespace October16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0,0,1,4,5,4,3,5
            // 0,1,2,3,4,5,6,7

            // 2,2,1,2,2,2,1,2
            // index


            int[] array = {0,0,1,2};
                           
            int[] countsArray = new int[array.Length];
            int[] indexes = new int[array.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }
            
            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = 0; j<array.Length; j++)
                {
                    if (array[i] == array[j])
                        countsArray[i] += 1;

                }
            
            }

            for(int i = 0; i < indexes.Length; i++) 
            {
                
                

                for (int j = i+1; j<array.Length; j++)
                {
                    if (array[j] == array[i])
                        indexes[i] = -1;
                }
            
            }

            foreach (var i in indexes)
            {
                if (i>0)
                {
                    Console.WriteLine(array[i]+" -> " + countsArray[i]);
                }
            }

            // 2


            do
            {
                Console.WriteLine("Enter array length: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y to add new item: ");
                string command = Console.ReadLine();
            } while (command);









        }
    }
}
