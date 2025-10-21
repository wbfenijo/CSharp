
using System;

namespace Programko
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			for(int i = 1; i < 11; i++)
			{
				Console.WriteLine("Nazdar Adam");
				Console.WriteLine("Ako sa mas?");
				
			}

			for(float i = 1; i < 11; i++)
			{
				Console.WriteLine(1/i);				
			}
			
			for(int i = 1; i < 11; i++)
			{
				Console.Write(i);
				Console.Write(" na druhu je ");
				Console.WriteLine(i * i);
				
			}
			Console.Write("Ako sa volas?");
			Console.WriteLine("Ahoj {0}.", Console.ReadLine());
			
			Console.Write("Prve cislo:");
			int num1 = Convert.ToInt16(Console.ReadLine());
			
			Console.Write("Druhe cislo:");
			int num2 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Sucet je {0}",num1 + num2);
			Console.ReadKey(true);
		}
	}
}