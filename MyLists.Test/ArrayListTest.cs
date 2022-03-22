using NUnit.Framework;

namespace MyLists.Test
{
	[TestFixture]
	public class ArrayListTest
	{
		[TestCaseSource(typeof(AddValueLastTestSource))]
		public void AddValueLastTest( int value, ArrayList list, ArrayList expectedList )
		{
			ArrayList actualList = list;
			actualList.AddValueLast(value);
		    Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(AddValueFirstTestSource))]
		public void AddValueFirstTest(int value, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.AddValueFirst(value);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(AddValueByIndexTestSource))]
		public void AddValueByIndexTest(int value, int index, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.AddValueByIndex(value, index);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveOneElementLastTestSource))]
		public void RemoveOneElementLastTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementLast();
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveOneElementFirstTestSource))]
		public void RemoveOneElementFirstTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementFirst();
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveOneElementByIndexTestSource))]
		public void RemoveOneElementByIndexTest(int index, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementByIndex(index);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveElementsLastTestSource))]
		public void RemoveElementsLastTest(int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsLast(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveElementsFirstTestSource))]
		public void RemoveElementsFirstTest(int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsFirst(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(RemoveElementsByIndexTestSource))]
		public void RemoveElementsByIndexTest(int index, int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsByIndex(index, numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(FindByIndexTestSource))]
		public void FindByIndexTest(int index, ArrayList list, int expected)
		{
			int actual = list.FindByIndex(index);
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(IndexByValueTestSource))]
		public void IndexByValueTest(int value, ArrayList list, int expected)
		{
			int actual = list.IndexByValue(value);
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(ChangeByIndexTestSource))]
		public void ChangeByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.ChangeByIndex(index, value);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(ReverseTestSource))]
		public void ReverseTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.Reverse();
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(GetMinElementArrayTestSource))]
		public void GetMinElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetMinElementArray();
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(GetMaxElementArrayTestSource))]
		public void GetMaxElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetMaxElementArray();
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(GetIndexMinElementArrayTestSource))]
		public void GetIndexMinElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetIndexMinElementArray();
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(GetIndexMaxElementArrayTestSource))]
		public void GetIndexMaxElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetIndexMaxElementArray();
			Assert.AreEqual(expected, actual);
		}

		[TestCaseSource(typeof(AscendingSortTestSource))]
		public void AscendingSortTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.AscendingSort();
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(DescendingSortTestSource))]
		public void DescendingSortTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.DescendingSort();
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(DeletFirstNumberTestSource))]
		public void DeletFirstNumberTest(int value, ArrayList list, ArrayList expectedList, int expected)
		{
			int actual = list.DeletFirstNumber(value);
			ArrayList actualList = list;
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(DeletAllNumbersTestSource))]
		public void DeletAllNumbersTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
		{
			int actualNumber = list.DeletAllNumbers(value);

			ArrayList actualList = list;

			Assert.AreEqual(expectedNumber, actualNumber);
			Assert.AreEqual(expectedList, actualList);
		}

		[TestCaseSource(typeof(GetLengthTestSource))]
		public void GetLengthTest(ArrayList list, int expected)
		{
			int actual = list.Length;
			Assert.AreEqual(expected, actual);
		}
	}
}
