using System;
using MyLists;

namespace ListCheck
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ArrayList array = new ArrayList();
			while (true)
			{
				Console.Clear();
				//Console.Write("Введите число: ");
				//int number = Convert.ToInt32(Console.ReadLine());
				//array.AddValueLast(number);
				//array.AddValueFirst(number);
				//array.RemoveOneElementLast();
				//array.RemoveOneElementFirst();
				//array.RemoveElementsLast(2);
				//array.RemoveElementsFirst(2);
				//Console.Write("Введите индекс числа: ");
				//int index = Convert.ToInt32(Console.ReadLine());
				//array.AddValueByIndex(number, index);
				//array.RemoveOneElementByIndex(index);
				//array.RemoveElementsByIndex(index, 3);
				array.Write();
				Console.WriteLine();
				Console.WriteLine(array.Length);
				Console.ReadKey();
			}
		}
	}
}
