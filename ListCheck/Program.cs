using System;
using MyLists;

namespace ListCheck
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] array = new int[] { 5, 10, -4, 555 };
			ArrayList list = new ArrayList();
			ArrayList list2 = new ArrayList(55);
			ArrayList list3 = new ArrayList(array);
			while (true)
			{
				Console.Clear();
				//Console.Write("Введите число: ");
				//int number = Convert.ToInt32(Console.ReadLine());
				//list3.AddValueLast(number);
				//list3.AddValueFirst(number);
				//list3.RemoveOneElementLast();
				//list3.RemoveOneElementFirst();
				//list3.RemoveElementsLast(2);
				//list3.RemoveElementsFirst(2);
				//Console.Write("Введите индекс числа: ");
				//int index = Convert.ToInt32(Console.ReadLine());
				//list3.AddValueByIndex(number, index);
				//list3.RemoveOneElementByIndex(index);
				//list3.RemoveElementsByIndex(index, 3);
				//int value = list3.FindByIndex(index);
				//int value = list3.IndexByValue(number);
				//list3.ChangeByIndex(index, 55);
				//list3.Reverse();
				//int value = list3.GetMinElementArray();
				//int value = list3.GetMaxElementArray();
				//int value = list3.GetIndexMinElementArray();
				//int value = list3.GetIndexMaxElementArray();
				//list3.AscendingSort();
				//list3.DescendingSort();
				//int value = list3.DeletFirstNumber(number);
				//int value = list3.DeletAllNumbers(number);
				//list3.AddListLast(list2);
				//list3.AddListFirst(list2);
				//list3.AddListByIndex(index, list3);
				list3.Write();
				Console.WriteLine();
				//Console.WriteLine(value);
				Console.ReadKey();
			}
		}
	}
}
