using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellomun
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int sum = int.Parse(Console.ReadLine());

            //    int[] num = sum[] ;

            //    int maior = num[0];
            //    int menor = num[0];

            //    for (int i = 1; i < num.Length; i++)
            //    {
            //        int item = num[i];

            //        if(item > maior)
            //        {
            //            maior = item;
            //        }
            //        if (item < menor)
            //        {
            //            menor = item;
            //        }        
            //    }
            //    Console.WriteLine("Mair = " + maior);
            //    Console.WriteLine("Menor = " + menor);
            //    Console.ReadLine();   
            Console.Write("Digite um numero1 : ");
            //int m = Hol();

            int a = pedir("Digite o numero: ");
            int b = pedir("Digite o numero: ");
            int c = pedir("Digite o numero: ");



        }
        static int pedir(string texto)
        {
            Console.Write(texto);
            return Somar();
        }

       // static int Hol()
       // {
       //
       //     int m = int.Parse(Console.ReadLine());
       //
       //     if (m > 5)
       //     {
       //         Console.WriteLine("voce se ferroooo");
       //     }
       //     Console.ReadLine();
       //     return m;
       //  
       // }

        static int Somar(int a, int b, int c)
        {
             
             return a+b+c;

        }
    }
}
