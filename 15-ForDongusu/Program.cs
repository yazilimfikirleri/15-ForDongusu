using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den 100'e kadar saydırma
            //for(int i=1; i<=100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //1-100 arasındaki sayıların toplamları.
            //int sonuc = 0;
            //for(int i=1; i<=100; i++)
            //{
            //    sonuc += i;
            //}
            //Console.WriteLine("Toplam= " + sonuc);
            //Console.Read();

            //Çarpım Tablosu
           for(int i=1; i<=10; i++)
            {
                for(int z=1; z<=10; z++)
                {
                    //1x1=1
                    Console.WriteLine($"{i}x{z}={i * z}");
                }
                Console.WriteLine("--------");
            }
            Console.Read();
        }
    }
}
