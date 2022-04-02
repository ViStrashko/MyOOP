using NUnit.Framework;
using System;

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
		[TestCaseSource(typeof(AddValueByIndexNegativeEmptyTestSource))]
		public void AddValueByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, int index, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.AddValueByIndex(value, index));
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeTestSource))]
		public void AddValueByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int value, int index, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.AddValueByIndex(value, index));
		}


		[TestCaseSource(typeof(RemoveOneElementLastTestSource))]
		public void RemoveOneElementLastTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementLast();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.RemoveOneElementLast());
		}


		[TestCaseSource(typeof(RemoveOneElementFirstTestSource))]
		public void RemoveOneElementFirstTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementFirst();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.RemoveOneElementFirst());
		}


		[TestCaseSource(typeof(RemoveOneElementByIndexTestSource))]
		public void RemoveOneElementByIndexTest(int index, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveOneElementByIndex(index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeEmptyTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.RemoveOneElementByIndex(index));
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveOneElementByIndex(index));
		}


		[TestCaseSource(typeof(RemoveElementsLastTestSource))]
		public void RemoveElementsLastTest(int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsLast(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeEmptyTestSource))]
		public void RemoveElementsLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsLast(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeTestSource))]
		public void RemoveElementsLastNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, ArrayList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsLast(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsFirstTestSource))]
		public void RemoveElementsFirstTest(int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsFirst(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeEmptyTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsFirst(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, ArrayList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsFirst(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsByIndexTestSource))]
		public void RemoveElementsByIndexTest(int index, int numberOfElements, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.RemoveElementsByIndex(index, numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeEmptyTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int numberOfElements, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeIndexTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, ArrayList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberOutOfRangeTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsOutOfRangeArray_ShuoldThrowException(int index, int numberOfElements, ArrayList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}


		[TestCaseSource(typeof(FindByIndexTestSource))]
		public void FindByIndexTest(int index, ArrayList list, int expected)
		{
			int actual = list.FindByIndex(index);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(FindByIndexNegativeEmptyTestSource))]
		public void FindByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.FindByIndex(index));
		}
		[TestCaseSource(typeof(FindByIndexNegativeTestSource))]
		public void FindByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.FindByIndex(index));
		}


		[TestCaseSource(typeof(IndexByValueTestSource))]
		public void IndexByValueTest(int value, ArrayList list, int expected)
		{
			int actual = list.IndexByValue(value);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(IndexByValueNegativeEmptyTestSource))]
		public void IndexByValueNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.IndexByValue(value));
		}


		[TestCaseSource(typeof(ChangeByIndexTestSource))]
		public void ChangeByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.ChangeByIndex(index, value);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeEmptyTestSource))]
		public void ChangeByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int value, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.ChangeByIndex(index, value));
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeTestSource))]
		public void ChangeByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index,int value, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.ChangeByIndex(index, value));
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
		[Test]
		public void GetMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.GetMinElementArray());
		}


		[TestCaseSource(typeof(GetMaxElementArrayTestSource))]
		public void GetMaxElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetMaxElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.GetMaxElementArray());
		}


		[TestCaseSource(typeof(GetIndexMinElementArrayTestSource))]
		public void GetIndexMinElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetIndexMinElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.GetIndexMinElementArray());
		}


		[TestCaseSource(typeof(GetIndexMaxElementArrayTestSource))]
		public void GetIndexMaxElementArrayTest(ArrayList list, int expected)
		{
			int actual = list.GetIndexMaxElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ArrayList list = new ArrayList();
			Assert.Throws<Exception>(() => list.GetIndexMaxElementArray());
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
		[TestCaseSource(typeof(DeletFirstNumberNegativeEmptyTestSource))]
		public void DeletFirstNumberNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.DeletFirstNumber(value));
		}


		[TestCaseSource(typeof(DeletAllNumbersTestSource))]
		public void DeletAllNumbersTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
		{
			int actualNumber = list.DeletAllNumbers(value);
			ArrayList actualList = list;
			Assert.AreEqual(expectedNumber, actualNumber);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletAllNumbersNegativeEmptyTestSource))]
		public void DeletAllNumbersNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.DeletAllNumbers(value));
		}



		[TestCaseSource(typeof(GetLengthTestSource))]
		public void GetLengthTest(ArrayList list, int expected)
		{
			int actual = list.Length;
			Assert.AreEqual(expected, actual);
		}


		[TestCaseSource(typeof(AddListLastTestSource))]
		public void AddListLastTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			list.AddListLast(list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListLastNegativeTestSource))]
		public void AddListLastNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(ArrayList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListLast(list));
		}


		[TestCaseSource(typeof(AddListFirstTestSource))]
		public void AddListFirstTest(ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			list.AddListFirst(list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListFirstNegativeTestSource))]
		public void AddListFirstNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(ArrayList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListFirst(list));
		}


		[TestCaseSource(typeof(AddListByIndexTestSource))]
		public void AddListByIndexTest(int index, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			list.AddListByIndex(index, list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListByIndexNegativeTestSource))]
		public void AddListByIndexNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListByIndex(index, list));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeEmptyTestSource))]
		public void AddListByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<Exception>(() => list.AddListByIndex(index, list));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeIndexTestSource))]
		public void AddListByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ArrayList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.AddListByIndex(index, list));
		}
	}
}
