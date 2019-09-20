using System;

namespace _100_Primeiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
        
            while (x <= 100)
            {
                if (x % 2 != 0)
                { 
                    Console.WriteLine("{0}",x);
                }

                x++;
            }
        }
    }
}

//int i;
//for (i = 1; i <= 100; i+=2){
//    Console.Write(i+ " ");
//}
