using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte number1,number2,sum;
            //number1 = 20;
            //number2 = 10;
            //sum = Convert.ToByte(number1 + number2);
            //Console.WriteLine(sum);

            //Klavyeden 2 sayı alıp bunların carpimini hesaplayın
            byte sayi1,sayi2,carpim;
            Console.WriteLine("Lütfen 1.sayiyi giriniz : ");
            Console.WriteLine();
            sayi1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Lütfen ikinci sayiyi giriniz : ");
            Console.WriteLine();
            sayi2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            carpim = Convert.ToByte(sayi1 * sayi2);
            Console.WriteLine("Girmis oldugunuz sayilarin carpimi : " + carpim);

            Console.Read();
        }
    }
}
