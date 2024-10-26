using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "blue";
            //colors[1] = "green";
            //colors[2] = "white";
            //colors[3] = "yellow";

            //Console.WriteLine(colors[3]);
            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);
            //int[] numbers = new int[10];
            //numbers[0] = 21;
            //numbers[1] = 25;
            //numbers[2] = 63;
            //numbers[3] = 43;
            //numbers[7] = 926;

            //string[] citie = { "Prag", "Roma", "Cizre", "İstanbul" };
            //Console.WriteLine(citie[2]);


            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = {"yeşiş", "sari", "kırmızı", "lacivert", "siyah", "beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //    Console.WriteLine(". dizi elemani" + i);
            //}
            //int[] number = { 1232, 20817, 345, 4457, 98545, 6245, 74545 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            //Console.WriteLine(symbols[5] + " ♥ " + symbols[6]);
            //Console.WriteLine("DİZİ ELEMAN SAYİSİNİ GİRİN");
            //int esayisi= int.Parse(Console.ReadLine());
            //int[] dizi = new int[esayisi];
            //for (int i = 0; i < esayisi; i++)
            //{
            //    Console.WriteLine("dizinin " + (i+1) + ". sayisini giriniz");
            //    dizi[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("YAZİLAN ELEMANLAR ");
            //for (int i = 0;i < dizi.Length; i++)
            //{

            //    Console.Write(dizi[i] + " ");
            //}
            //int eb = dizi[0];
            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > eb)
            //    {
            //        eb = dizi[i];
            //    }
            //}
            //Console.WriteLine("en büyük "+ eb);

            //string[] persons = { "ali", "veli", "murat", "fırat" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 23, 523, 7345, 734534, 242, 3424, 5235, 234, 234, 324, 234 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers2 = { 23, 523, 7345, 734534, 242, 3424, 5235, 234, 234, 324, 234 };
            //Array.Reverse(numbers2);
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            #endregion

            #region Dizi metotları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "ferat" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 232, 2132, 512, 3123, 512, 312, 321, 32, 13, 123, 21312 };

            //Console.WriteLine("dizinin en büyük elemani" + numbers.Max() + "dizinin en kücük elemani" + numbers.Min());



            #endregion
            #region kullanici değeri alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. şehri giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 990 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];  
            //}
            //Console.WriteLine("toplam : "+ sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Console.WriteLine("çift sayilar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
              
            //}
            //Console.WriteLine("tek sayilar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            #endregion

            Console.Read();
        }
    }
}
