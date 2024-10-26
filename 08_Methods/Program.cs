using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            // Geriye değer döndürmeyen methodlar
            // customer ->  ekle,sil,güncelle,listele
            // void metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Fırat Engin");
            //    Console.WriteLine("Ali Engin");
            //    Console.WriteLine("Veli Engin");
            //}
            //CustomerList();
            //Console.WriteLine("------");
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 1;
            //    int z = -2;
            //    Console.WriteLine(x+y+z);
            //}
            //Sum();
            #endregion
            #region Geriye değer döndürmeyen String parametreli metodlar

            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri adı :" + customerName + " " + "Müşteri Soyadı: " + customerSurname);
            //}
            //CustomerCard("Fırat", "Gamze");
            //CustomerCard("Engin", "Demir");
            #endregion
            #region Geriye değer döndürmeyen İnt parametreli metodlar

            //void Sum(int x,int y,int z)
            //{
            //    int result = x + y + z;
            //    Console.WriteLine(result);
            //}
            //Sum(2, 3, 6);
            #endregion
            #region Geriye değer Döndüren  metodlar

            //string CustomerName()
            //{
            //    return "Firat Engin";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Firat";
            //    string surname = "Engin";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion
            #region Geriye değer Döndüren Paremetreli metodlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo ="Ülke : "  + countryName + " Başkent :" + capital + " Bayrak Rengi" + flagColor + " ";
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adı: ");
            //x = Console.ReadLine();
            //Console.WriteLine("Ülke başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine("Ülke bayrak renk/leri giriniz");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("japonya","tokyo","kırmızı beyaz"));


            #endregion
            #region Geriye değer Döndüren Int Paremetreli metodlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(2,5));
            //Console.WriteLine(Sum(21,5));
            //Console.WriteLine(Sum(23,25));
            //Console.WriteLine(Sum(223,253));

            #endregion

            #region örnek uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " " + "Öğrenci sinavi geçti";
            //    }
            //    else
            //    {
            //        return student + " " + "Öğrenci sinavdan kaldı";
            //    }
            //}
            //Console.WriteLine(ExamResult("Fırat", 30, 20, 40));
            //Console.WriteLine(ExamResult("Gamze", 90, 20, 40));
            #endregion

            Console.Read();
        }
    }
}
