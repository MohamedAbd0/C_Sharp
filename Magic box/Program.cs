using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_box
{
    class Program
    {

        public static bool Prim(int x)
        {
            for (int i = 2; i <x; i++)
            {
                if (x % i != 0)
                    return true;
                else
                    return false;
            }
            return true;
        }

        
        public static void  AddMatrix(int y)
        {
            int[,] num = new int[y, y];
            Random RNum = new Random();
            int SumNumber=0;
            bool flag = false;
            int SumD1 = 0;
            int SumD2 = 0;
            int SumRow = 0;
            int SumColum = 0;

            for (int i = 0; i < y-1; i++)
            {
                
                for (int j = 0; j < y-1 ; j++)
                {   
                   int c= RNum.Next(1,10); 
                       c = RNum.Next(1, 10);
                       num[i, j] = c;
                    if(i==0)
                       SumRow += c;
                       //Console.WriteLine(@" c : {0}  Sum : {1}", c, SumRow);
                     /*  if (y - j == 2 && i>0)
                           j++;*/
                }
                SumD1 += num[i, i];
                SumD2 += num[i, y-i-1];
                SumColum += num[i, 0];
            }
            while (!flag)
            {
                // Console.WriteLine(++kk);
                num[0, y - 1] = RNum.Next(1, 10);
               // num[y - 1, y - 1] = RNum.Next(1, 10);
                num[y - 1, 0] = RNum.Next(1, 10);
                if ((num[0, y - 1] + SumRow) == (num[y - 1, 0] + SumColum))
                {
                    if ((num[0, y - 1] + SumRow) == (num[0, y - 1] + num[y - 1, 0] + SumD2))
                        flag = true;
                    else
                    {
                        int newnum = num[((y + 1) / 2) - 1, ((y + 1) / 2) - 1];
                        int d2 = (num[0, y - 1] + num[y - 1, 0] + SumD2) - newnum;

                        for (int ml = 0; ml <= 10; ml++)
                        {
                            num[((y + 1) / 2) - 1, ((y + 1) / 2) - 1] = ml;
                            if ((d2 + (num[((y + 1) / 2) - 1, ((y + 1) / 2) - 1])) == (num[0, y - 1] + SumRow))
                            {
                                flag = true;
                                //   Console.WriteLine(" T -------------");
                                break;
                            }
                        }
                    }
                }
            }
            SumNumber = (num[0, y - 1] + SumRow);
           // int SumDD = 0;
           for (int l = 1; l < y; l++)
            {
                int SumCColum = 0;
                int SumRRow = 0;
                for (int k = 0; k < y; k++)
                {
                    SumCColum += num[k, l];
                    SumRRow += num[l, k];

                }
                num[y-1, l] = SumNumber - SumCColum;
                num[l, y - 1] = SumNumber - SumRRow;
            }
          DrowMatrix( num);
        }
        public static void DrowMatrix(int[,] num)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1) ; Console.Write(num[i,j] + "\t") , j++);
                Console.WriteLine();
            }
        }


       
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(" Enter the Prim Number ");

                int x= int.Parse(Console.ReadLine());
                if (Prim(x))
                {
                    Console.WriteLine("Prim ");
                   AddMatrix(x);  
                }
                else
                    Console.WriteLine(" Not Prim ");


               // Console.ReadKey();
            }
        }
    }
}
