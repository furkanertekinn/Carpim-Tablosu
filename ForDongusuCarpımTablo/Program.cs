using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuCarpımTablo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <=9 ; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    int carpimDeger = i * j;
                    Console.Write("{0}*{1}={2}\t" ,i , j , carpimDeger);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
