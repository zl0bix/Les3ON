using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;


namespace Les3ON
{

    internal class Program
    {

        static void Main(string[] args)
        {
            if (Console.CapsLock == true)
                Console.WriteLine("Caps ON!");


            if (Console.NumberLock == true)
                Console.WriteLine("NUM LOCK ON!");


            System.Threading.Thread.Sleep(500);
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkRed;

            string str = "Enter langth of array-> ";
            Console.Write(str.ToUpper());
            int numArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numArr];
            Random rnd = new Random();

            for (int i = 0; i < numArr; i++)
            {
                arr[i] = rnd.Next(0, 101);
                Console.Write(arr[i] + " ");
                System.Threading.Thread.Sleep(175);
            }
            //Console.Clear();
            Console.WriteLine("\n--------------------");
            for (int i = 0; i < arr.Length; i++)

                for (int j = 0; j < arr.Length - 1; j++)

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }


            for (int i = 0; i < numArr; i++)
            {

                Console.Write(arr[i] + " ");
                System.Threading.Thread.Sleep(175);
            }
            int numMAX = arr[0];
            int numMIN = arr[0];
            for (int i = 0; i < numArr; i++)
            {
                if (arr[i] > numMAX)
                {
                    numMAX = arr[i];
                }
                if (arr[i] < numMAX)
                {
                    numMIN = arr[i];
                }
            }
            Console.WriteLine("\nMax is - " + numMAX + "\nMIN is - " + numMIN);
           
            Console.Write("List\n");
            List<int> list1 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(rnd.Next(0,77));
                Console.Write(list1[i]+" ");
            }
            Console.WriteLine();
            foreach (int k in list1)
                Console.Write(k + " ");
            Console.WriteLine("\n\n\n\n");
        }
    }
}
