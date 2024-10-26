using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region If Else
			//Console.WriteLine("Lütfen şifreyi Giriniz");
			//string password;
			//password = Console.ReadLine();
			//if (password == "abcd")
			//{
			//             Console.WriteLine("Giriş başarılı");			
			//}
			//         else
			//         {
			//             Console.WriteLine("giriş başarısız");
			//         }

			//string capital, country;
			//         Console.WriteLine("Başkenti Giriniz:                            ");
			//capital = Console.ReadLine();
			//         Console.WriteLine("Ülkeyi Giriniz:");
			//country = Console.ReadLine();

			//if(capital == "ankara" & country=="turkiye")
			//{
			//             Console.WriteLine("veriler doğrulandı");
			//}
			//else
			//{
			//	Console.WriteLine("hatalı bilgiler");
			//}

			//int exam1, exam2, exam3, avarage;
			//string result="ERROR";

			//Console.WriteLine("Sınav 1");
			//exam1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Sınav 2");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Sınav 3");
			//exam3 = int.Parse(Console.ReadLine());

			//avarage = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine("Sınav ortalaması : " + avarage);

			//if (avarage > 0 & avarage < 50)
			//{
			//	result = "vasat";
			//}
			//else if (avarage >= 50 & avarage < 70)
			//{
			//	result="ORTA";
			//}
			//else
			//{
			//	result="SÜPERR";
			//}
			//         Console.WriteLine(result);
			//Console.Read();

			#endregion

			#region Mod İşlemleri
			//int number;
			//number = 26;
			//int result = number % 5;
			//         Console.WriteLine(result);

			//Console.WriteLine("Lütfen 1. sayiyi giriniz");
			//int number1 = int.Parse(Console.ReadLine());
			//         Console.WriteLine("Lütfen 2. sayiyi giriniz");
			//int number2 = int.Parse(Console.ReadLine());

			//int result = number1 % number2;
			//         Console.WriteLine("1.sayinin 2. sayiya bölümünden kalan : " + result);
			#endregion

			#region CHAR DEĞİŞKENLER İLE KARAR YAPILARI
			//char team;
   //         Console.WriteLine("Lütfen takım sembolünü giriniz");
			//team = char.Parse(Console.ReadLine());

			//if (team == 'g' | team == 'G')
			//{
			//	Console.WriteLine("Galatasaray");
			//}
			//else if (team == 'f' | team == 'F')
			//{
			//	Console.WriteLine("Fenerbahçe");
			//}
			//else if (team =='b'| team == 'B')
			//{
   //             Console.WriteLine("BEŞİKTAŞKKKKKK");
			//}
			//else
			//{
   //             Console.WriteLine("GEÇERSİZ KARAKTER");
			//}
			//Console.Read();
            #endregion

            #region Switch Case

   //         Console.WriteLine("Lütfen Ayı Girin");
			//int monthNumber = int.Parse(Console.ReadLine());
			//switch (monthNumber)
			//{
			//	case 1: Console.WriteLine("OCAK");
			//		break;
			//	case 2:
			//		Console.WriteLine("ŞUBAT");
			//		break;
			//	case 3:
			//		Console.WriteLine("MART");
			//		break;
			//	case 4:
			//		Console.WriteLine("NİSAN");
			//		break;
			//	case 5:
			//		Console.WriteLine("MAYIS");
			//		break;
			//	case 6:
			//		Console.WriteLine("HAZİRAN");
			//		break;
			//	case 7:
			//		Console.WriteLine("TEMMUZ");
			//		break;
			//	case 8:
			//		Console.WriteLine("AĞUSTOS");
			//		break;

			//		default: Console.WriteLine("HATALİ GİRİŞ"); break;
			//}
			//Console.Read();
			#endregion

		}
	}
}
