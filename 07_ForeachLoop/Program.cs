using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //foreach(1;2;3;4)
            //1: değişken türü
            //2: Değişken adı
            //3. In
            //4. Liste,koleksiyon , dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 23, 123, 5314, 32423, 4634, 12312, 45, 23, 423, 423, 412, 312 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            ////}

            //int[] numbers = { 23, 123, 5314, 32423, 4634, 12312, 45, 23, 423, 423, 412, 312 };
            //foreach (int i in numbers)
            //{
            //    if(i %2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            ////}
            //int[] numbers = { 23, 123, 5314, 32423, 4634, 12312, 45, 23, 423, 423, 412, 312 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;    
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,90,0,8,6,34,534,324,234
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string word = " Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion
            #region Örnek Sınav sistem u
            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();    
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Sınıfta kaç öğrenci var ?");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //// öğrenci isim ve not ortalamaları 
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin ismini giriniz");
            //    studentNames[i] = Console.ReadLine();
                
            //    double totalExamResult = 0;
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrencinin {j+1}. sınavını giriniz:  ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            ////öğrenicinin ortalaması ve geçip kalma durumu
            //for(int i = 0;i < studentCount;i++)
            //{ 
            //    if(studentExamAvg[i] < 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci not ortalaması {studentExamAvg[i]} olduğundan dersten kalmıştır");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci not ortalaması {studentExamAvg[i]} olduğundan dersten geçmiştir");
            //    }
              
            //}

            //

            #endregion

            Console.Read();
        }
    }
}
