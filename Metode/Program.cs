using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj = 8;
			Console.WriteLine($"Broj u main-u je {broj}");
			UvecajBroj(broj);
			//broj = UvecajBrojSaPromenom(broj);
			Console.WriteLine($"Broj u main-u je {broj}");

			List<int> listaBrojeva = new List<int>();
			listaBrojeva.Add(8);
			Console.WriteLine($"Broj iz liste u main-u je {listaBrojeva[0]}");
			UvecajBrojSaListe(listaBrojeva);
			Console.WriteLine($"Broj iz liste u main-u je {listaBrojeva[0]}");

			int broj2 = 8;
			Console.WriteLine($"Broj u main-u je {broj2}");
			UvecajReferentiInt(ref broj2);
			Console.WriteLine($"Broj u main-u je {broj2}");


			Console.ReadKey();


			Console.WriteLine("Krenuo sa main-om");
			MojaMetoda();
			PovratniTip();
			Console.WriteLine("Rezultat je: " + Sabiranje(4,8));
			Console.ReadKey();
		}

		static void UvecajReferentiInt(ref int broj)
		{
			broj++;
		}


		static int UvecajBrojSaPromenom(int brrr)
		{
			return ++brrr;
		}

		static void UvecajBrojSaListe(List<int> lista)
		{
			Console.WriteLine($"Broj je u metodi {++lista[0]}");
		}

		static void UvecajBroj(int br)
		{
			Console.WriteLine($"Broj je u metodi {++br}");
		}

		static int Sabiranje(int x, int y)
		{
			return x + y;
		}

		static void MojaMetoda()
		{
			Sabiranje(4, 5);
			Console.WriteLine("Moja metoda :D");
			PovratniTip();
		}

		static string PovratniTip()
		{
			bool bla = false;
			if (bla)
			{
				int x = 45;
				return "Evo iz metode string :)";
			}
			return "Moramo uvek da vratimo nesto :)";
		}


	}
}
