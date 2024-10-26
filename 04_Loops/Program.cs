using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            // x başlangıç değeri
            // y bitiş
            // z artış , azalış

            //for(int i =3; i<=50; i += 3)
            // {
            //     Console.WriteLine(i);
            // }

            //Console.WriteLine("Lütfen Ekrana Yazilmasini istediğiniz Adeti giriniz");
            //int finisValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i<= finisValue; i++)
            //{
            //    Console.WriteLine("FİRGAM");
            //}

            #endregion
            #region For Döngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0) 
            //    {

            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++) 
            //{ 
            //totalValue = totalValue + i;
            //}
            //Console.WriteLine(totalValue);

            //int totelValue = 0;
            //for(int i = 1; i<=20;i++)
            //{
            //    if( i %2 == 0)
            //    {
            //        totelValue += i;
            //    }
            //}
            //Console.WriteLine(totelValue);

            //int count = 0;
            //for (int i = 1;i <=50;i++)
            //{
            //    if(i %7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("7 ye tam bölünen sayi toplamı : " +count);

            //bir bakteri her saat sonunda 2 ye bölünüyor yani 2 katina çikiyor
            //1-2 
            //2-4
            //4-8
            //8-16  2^n
            //int bakteri = 1;
            //for (int i = 1; i <=24; i++)
            //{
            //    bakteri = bakteri * 2;
            //    Console.WriteLine(i + " saatin sonunda bakteri sayisi :"+bakteri);
            //}
            #endregion
            #region While Döngüsü

            //while(şartlar)
            // {  işlemler }
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhabalar efendim.");
            //    i++;
            //}
            //int i = 1;
            //while(i <= 10)
            //{
            //    if(i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            #region örnek sinav sorusu
            //// klavyeen girilen 3 basamakı sayinin basamaklarını toplamını hesaplayan kodu yaziniz
            //Console.WriteLine("basamakları toplamını hesapmalama istediğiniz 3 basamaklı bir sayiyiy giriniz");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100)/10;
            //Console.WriteLine(ones + hundreds+tens);
            #endregion
            Console.Read();
        }
    }
}
