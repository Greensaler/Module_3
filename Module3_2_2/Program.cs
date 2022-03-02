using System;

namespace Module3_2_2
{
	class Program
	{
		public static void Main(string[] args)
		{

			string myName;
			myName = "Stepan2";

			Console.WriteLine(myName);

			// из модуля 3.7 перевод в другой тип

			int olddata = 6;
			byte data = (byte)olddata;

			Console.Write("Enter your age: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your age is {0} ", age);
			Console.ReadKey();

			Console.ReadKey();
		}
	}
}
