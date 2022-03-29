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
			LinkedList list4 = new LinkedList(5);
			LinkedList list5 = new LinkedList();
			LinkedList list6 = new LinkedList(array);
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
				//list4.AddValueLast(25);
				//list4.AddValueLast(1);
				//list4.AddValueLast(-1);
				//list4.AddValueFirst(10);
				//list4.AddValueLast(55);
				//list4.AddValueFirst(-5);
				//list4.AddValueByIndex(0, 4);
				//list4.RemoveOneElementLast();
				//list4.RemoveOneElementFirst();
				//list4.RemoveOneElementByIndex(0);
				//list4.RemoveElementsLast(2);
				//list4.RemoveElementsFirst(2);
				//list4.RemoveElementsByIndex(0, 3);
				//list4.RemoveElementsLast(2);
				//int value = list5.FindByIndex(0);
				//int value = list4.IndexByValue(4);
				//list4.ChangeByIndex(2, 55);
				//list4.Reverse();
				//int value = list4.GetMinElementList();
				//int value = list4.GetMaxElementList();
				//int value = list4.GetIndexMinElementList();
				//int value = list4.GetIndexMaxElementList();
				//list4.AscendingSort();
				//list4.DescendingSort();			
				//int value = list4.DeletFirstNumber(5);
				//int value = list4.DeletAllNumbers(5);
				//list4.AddListLast(list6);
				//list4.AddListFirst(list6);
				//list4.AddListByIndex(1, list6);
			/*	list5.AddValueLast(1);
				list5.AddValueLast(2);
				list5.AddValueLast(5);
				list5.RemoveOneElementByIndex(2);
				list5.RemoveOneElementByIndex(1);
				list5.RemoveOneElementByIndex(0);
				list5.RemoveOneElementByIndex(0);
			*/  Console.WriteLine();
				//Console.WriteLine(value);
				Console.ReadKey();
			}
		}
	}
}
