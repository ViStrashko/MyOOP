using NUnit.Framework;
using System;

namespace MyLists.Test
{
	[TestFixture]
	public class LinkedListTest
	{
		[TestCaseSource(typeof(AddValueLastTestSource))]
		public void AddValueLastTest(int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueLast(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueFirstTestSource))]
		public void AddValueFirstTest(int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueFirst(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueByIndexTestSource))]
		public void AddValueByIndexTest(int value, int index, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueByIndex(value, index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeEmptyTestSource))]
		public void AddValueByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, int index, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.AddValueByIndex(value, index));
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeTestSource))]
		public void AddValueByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int value, int index, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.AddValueByIndex(value, index));
		}


		[TestCaseSource(typeof(RemoveOneElementLastTestSource))]
		public void RemoveOneElementLastTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveOneElementLast();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.RemoveOneElementLast());
		}


		[TestCaseSource(typeof(RemoveOneElementFirstTestSource))]
		public void RemoveOneElementFirstTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveOneElementFirst();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.RemoveOneElementFirst());
		}


		[TestCaseSource(typeof(RemoveOneElementByIndexTestSource))]
		public void RemoveOneElementByIndexTest(int index, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveOneElementByIndex(index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeEmptyTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.RemoveOneElementByIndex(index));
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveOneElementByIndex(index));
		}


		[TestCaseSource(typeof(RemoveElementsLastTestSource))]
		public void RemoveElementsLastTest(int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsLast(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeEmptyTestSource))]
		public void RemoveElementsLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsLast(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeTestSource))]
		public void RemoveElementsLastNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsLast(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsFirstTestSource))]
		public void RemoveElementsFirstTest(int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsFirst(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeEmptyTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsFirst(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsFirst(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsByIndexTestSource))]
		public void RemoveElementsByIndexTest(int index, int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsByIndex(index, numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeEmptyTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeIndexTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberOutOfRangeTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsOutOfRangeArray_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}


		[TestCaseSource(typeof(FindByIndexTestSource))]
		public void FindByIndexTest(int index, LinkedList list, int expected)
		{
			int actual = list.FindByIndex(index);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(FindByIndexNegativeEmptyTestSource))]
		public void FindByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.FindByIndex(index));
		}
		[TestCaseSource(typeof(FindByIndexNegativeTestSource))]
		public void FindByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.FindByIndex(index));
		}


		[TestCaseSource(typeof(IndexByValueTestSource))]
		public void IndexByValueTest(int value, LinkedList list, int expected)
		{
			int actual = list.IndexByValue(value);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(IndexByValueNegativeEmptyTestSource))]
		public void IndexByValueNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.IndexByValue(value));
		}


		[TestCaseSource(typeof(ChangeByIndexTestSource))]
		public void ChangeByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.ChangeByIndex(index, value);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeEmptyTestSource))]
		public void ChangeByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int value, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.ChangeByIndex(index, value));
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeTestSource))]
		public void ChangeByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int value, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.ChangeByIndex(index, value));
		}


		[TestCaseSource(typeof(ReverseTestSource))]
		public void ReverseTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.Reverse();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(GetMinElementArrayTestSource))]
		public void GetMinElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetMinElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.GetMinElementList());
		}


		[TestCaseSource(typeof(GetMaxElementArrayTestSource))]
		public void GetMaxElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetMaxElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.GetMaxElementList());
		}


		[TestCaseSource(typeof(GetIndexMinElementArrayTestSource))]
		public void GetIndexMinElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetIndexMinElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.GetIndexMinElementList());
		}


		[TestCaseSource(typeof(GetIndexMaxElementArrayTestSource))]
		public void GetIndexMaxElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetIndexMaxElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<Exception>(() => list.GetIndexMaxElementList());
		}


		[TestCaseSource(typeof(AscendingSortTestSource))]
		public void AscendingSortTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AscendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DescendingSortTestSource))]
		public void DescendingSortTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.DescendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DeletFirstNumberTestSource))]
		public void DeletFirstNumberTest(int value, LinkedList list, LinkedList expectedList, int expected)
		{
			int actual = list.DeletFirstNumber(value);
			LinkedList actualList = list;
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletFirstNumberNegativeEmptyTestSource))]
		public void DeletFirstNumberNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.DeletFirstNumber(value));
		}


		[TestCaseSource(typeof(DeletAllNumbersTestSource))]
		public void DeletAllNumbersTest(int value, LinkedList list, LinkedList expectedList, int expectedNumber)
		{
			int actualNumber = list.DeletAllNumbers(value);
			LinkedList actualList = list;
			Assert.AreEqual(expectedNumber, actualNumber);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletAllNumbersNegativeEmptyTestSource))]
		public void DeletAllNumbersNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.DeletAllNumbers(value));
		}



		[TestCaseSource(typeof(GetLengthTestSource))]
		public void GetLengthTest(LinkedList list, int expected)
		{
			int actual = list.Length;
			Assert.AreEqual(expected, actual);
		}


		[TestCaseSource(typeof(AddListLastTestSource))]
		public void AddListLastTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			list.AddListLast(list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListLastNegativeTestSource))]
		public void AddListLastNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListLast(list));
		}

		[TestCaseSource(typeof(AddListFirstTestSource))]
		public void AddListFirstTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			list.AddListFirst(list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListFirstNegativeTestSource))]
		public void AddListFirstNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListFirst(list));
		}


		[TestCaseSource(typeof(AddListByIndexTestSource))]
		public void AddListByIndexTest(int index, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			list.AddListByIndex(index, list);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListByIndexNegativeTestSource))]
		public void AddListByIndexNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddListByIndex(index, list));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeEmptyTestSource))]
		public void AddListByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<Exception>(() => list.AddListByIndex(index, list));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeIndexTestSource))]
		public void AddListByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.AddListByIndex(index, list));
		}
	}
}
