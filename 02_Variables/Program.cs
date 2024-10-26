using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			#region Double Değişkenler
			//double number;
			//number = 4.85;
			//Console.WriteLine(number);

			//Console.WriteLine("***** Fiyat Listesi *****");
			//         Console.WriteLine();
			//double applePrice, oragePrice, strawberryPrice, potatoPrice, tomatoPrice;
			//applePrice = 14.85;
			//oragePrice = 20.95;
			//strawberryPrice = 45;
			//potatoPrice = 9.74;
			//tomatoPrice = 6.88;

			//         Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + "\u20BA");
			//         Console.WriteLine("---- Portakal Birim Fiyatı :" + oragePrice + "\u20BA");
			//         Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + "\u20BA");
			//         Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + "\u20BA");
			//         Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + "\u20BA");

			//double appleGram, orageGram, strawGram, potatoGram, tomatoGram;
			//appleGram = 1.245;
			//orageGram = 2.650;
			//strawGram = 0.750;
			//potatoGram = 4.859;
			//tomatoGram = 3.745;

			//double appleTotalPrice = appleGram * applePrice;
			//double orageTotalPrice = orageGram * oragePrice;
			//double strawTotalPrice = strawGram * strawberryPrice;
			//double potatoTotalPrice = potatoGram * potatoPrice;
			//double tomatoTotalPrice = tomatoGram * tomatoPrice;

			//         Console.WriteLine("Alınan Ürünler ve Fiyat");
			//         Console.WriteLine("Elma : "+ appleGram + " kilo " + " Elma Birim Fiyat: "+applePrice + "\u20BA" + " Toplam Ücret : " + appleTotalPrice + "\u20BA");
			//         Console.WriteLine("Portakal : "+ orageGram + " kilo " + " Portakal Birim Fiyat: " + oragePrice + "\u20BA" + " Toplam Ücret : " + orageTotalPrice + "\u20BA");
			//         Console.WriteLine("Çilek : "+ strawGram + " kilo " + " Çilek Birim Fiyat: " + strawberryPrice + "\u20BA" + " Toplam Ücret : " + strawTotalPrice + "\u20BA");
			//         Console.WriteLine("Patates : "+ potatoGram + " kilo " + " Patates Birim Fiyat: " + potatoPrice + "\u20BA" + " Toplam Ücret : " + potatoTotalPrice + "\u20BA");
			//         Console.WriteLine("Domates : "+ tomatoGram + " kilo " + " Domates Birim Fiyat: " + tomatoPrice + "\u20BA" + " Toplam Ücret : " + tomatoTotalPrice + "\u20BA");
			//double shoppingTotalPrice = appleTotalPrice + orageTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
			//Console.WriteLine("Toplam Ücret : "+ shoppingTotalPrice +  "\u20BA");


			#endregion

			#region Char Değişkenler
			//char symbol;
			//symbol= 'A';
			//         Console.WriteLine(symbol);

			#endregion

			#region Klavyeden Veri Girişleri String Değişkenler

			//         Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
			//         Console.WriteLine("Yolcu Adı:");
			//passengerName = Console.ReadLine();
			//Console.WriteLine("Yolcu Soyadı:");
			//passengerSurname = Console.ReadLine();
			//         Console.WriteLine("İlçe Bilgisi");
			//passengerDistrict = Console.ReadLine();
			//         Console.WriteLine("Şehir Bilgisi");
			//passengerCity = Console.ReadLine();
			//         Console.WriteLine("Yolcu Yaşı");
			//passengerAge = Console.ReadLine();
			//         Console.WriteLine("TC Kimlik Numarası");
			//passengerIdentityNumber = Console.ReadLine();
			//         Console.WriteLine();
			//         Console.WriteLine("-------------------------------------");
			//         Console.WriteLine("Yolcu TC Kimlik Numarası:" +passengerIdentityNumber  +" Yolcu Ad Soyad : " +passengerName + " " 
			//	+ passengerSurname + " Yolcu il/ilçe :" + passengerCity + "/" + passengerDistrict + "  Yolcu Yaş: "+ passengerAge);


			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

			//int shoePrice, computerPrice, chairPrice, tvPrice;
			//shoePrice = 1000;
			//computerPrice = 20000;
			//chairPrice = 5000;
			//tvPrice = 1200;

			//int shoesCount,computerCount, chairCount, tvCount;
			//         Console.WriteLine("Lütfen aldığınız Ayakkabı adetini giriniz :");
			//shoesCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("Lütfen aldığınız Bilgisayar adetini giriniz :");
			//computerCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("Lütfen aldığınız Sandalye adetini giriniz :");
			//chairCount = int.Parse(Console.ReadLine());
			//Console.WriteLine("Lütfen aldığınız TV adetini giriniz :");
			//tvCount = int.Parse(Console.ReadLine());

			//int totelPrice = shoesCount * shoePrice+ computerPrice* computerCount + chairPrice*chairCount+ tvPrice*tvCount;
			//         Console.WriteLine("Toplam gereken ödeme : " + totelPrice);

			#endregion

			#region Klavyeden Ondalıklı Sayı İşlemleri

			//double exam1,exam2,exam3,result;

			//         Console.WriteLine("Lütfen Öğrencinin 1. Sınav Sonucunu Giriniz: ");
			//exam1 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Lütfen Öğrencinin 2. Sınav Sonucunu Giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Lütfen Öğrencinin 3. Sınav Sonucunu Giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());
			//result= (exam1 + exam2 + exam3)/3;
			//         Console.WriteLine("Öğrencinin Not Ortalması : "+ result);

			#endregion

			#region Klavyeden Karakter Sayı İşlemleri

			//char gender;
   //         Console.WriteLine("Lütfen cinsiyet seçiniz :");
			//gender = char.Parse(Console.ReadLine());
			//Console.WriteLine("Seçilen Cinsiyet : " + gender);

			#endregion

			Console.Read();
		}
	}
}
