using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------EX 1 ------------------------
            /*
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write ("enter element "+(i+1)+" = ");
                arr[i] =int.Parse( Console.ReadLine());
            }
            Console.WriteLine("array befor operation");
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i]+"  "); }
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] * 5;
            }
            Console.WriteLine();
            Console.WriteLine("array after operation");
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + "  "); }
             
            */

            //-----------------------Ex 2 -----------------------------
            /*
            int[] arr1 = new int[] { 5, 1, 7, 8, 6, 2 };
            int[] arr2 = new int[] { 8, 9, 3, 8, 7, 9 };
            //to compare
            Console.WriteLine("arr1 | arr2"); 
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i]) { Console.WriteLine("   "+arr1[i]+" > " +arr2[i]); }
                if (arr1[i] < arr2[i]) { Console.WriteLine("   " + arr1[i] + " < " + arr2[i]); }
                if (arr1[i] == arr2[i]) { Console.WriteLine("   " + arr1[i] + " = " + arr2[i]); }
            }
             */

            //----------------------EX 3 -------------------------------------------------------
            
            char[] arr1 = new char[] { 'a','p','d','m','e'};
            char[] arr2 = new char[] {'l','a','y','m','t' };
            //to compare
            Console.WriteLine("by index in ascode");
            Console.WriteLine("arr1 | arr2");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >  arr2[i]) { Console.WriteLine("   " + arr1[i] + " > " + arr2[i]); }
                if (arr1[i] < arr2[i]) { Console.WriteLine("   " + arr1[i] + " < " + arr2[i]); }
                if (arr1[i] == arr2[i]) { Console.WriteLine("   " + arr1[i] + " = " + arr2[i]); }
            }
             

            //-------------------------------------EX 4 -----------------------------------------
            /*
            int[] arr = new int[] { 2, 1,1, 2, 3, 3, 3, 2, 1 };
            int[] numbersOfCounter = new int[10];
            int target=arr[0];
            int count = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                    //to save last equ
                    numbersOfCounter[j] = count;
                }
                    
                else
                {
                    numbersOfCounter[j] = count;
                    j++;
                    target = arr[i];
                    count = 1;
                }
            }
            int max = numbersOfCounter[0];
            int indexNumber = -1;
            int sum=0;
            for (int i = 1; i < numbersOfCounter.Length; i++)
            {
                if (numbersOfCounter[i]>max)
                {
                    max = numbersOfCounter[i];
                    indexNumber = i;
                }
            }
            for (int i = 0; i < indexNumber; i++){ sum+=numbersOfCounter[i];}
            int Fr_step = sum;
            int La_step = Fr_step + max;
            Console.WriteLine("array befor operation ");
            for (int i = 0; i < arr.Length; i++) { Console.Write("  " + arr[i]);}
            Console.WriteLine();
            Console.WriteLine("array after operation ");
            for (int i = Fr_step; i < La_step; i++){  Console.Write("  "+arr[i]); }
            Console.ReadKey();
             */ 
             
            

        }
    }
}
