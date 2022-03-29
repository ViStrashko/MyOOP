using NUnit.Framework;
using System;

namespace MyLists.Test
{
	[TestFixture]
	public class LinkedListTest
	{
		[TestCaseSource(typeof(AddValueLastLinkedListTestSource))]
		public void AddValueLastTest(int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueLast(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueFirstLinkedListTestSource))]
		public void AddValueFirstTest(int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueFirst(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueByIndexLinkedListTestSource))]
		public void AddValueByIndexTest(int value, int index, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AddValueByIndex(value, index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeEmptyLinkedListTestSource))]
		public void AddValueByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, int index, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.AddValueByIndex(value, index));
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeLinkedListTestSource))]
		public void AddValueByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int value, int index, LinkedList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.AddValueByIndex(value, index));
		}


		[TestCaseSource(typeof(RemoveOneElementLastLinkedListTestSource))]
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
			Assert.Throws<NullReferenceException>(() => list.RemoveOneElementLast());
		}


		[TestCaseSource(typeof(RemoveOneElementFirstLinkedListTestSource))]
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
			Assert.Throws<NullReferenceException>(() => list.RemoveOneElementFirst());
		}


		[TestCaseSource(typeof(RemoveOneElementByIndexLinkedListTestSource))]
		public void RemoveOneElementByIndexTest(int index, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveOneElementByIndex(index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeEmptyLinkedListTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.RemoveOneElementByIndex(index));
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeLinkedListTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveOneElementByIndex(index));
		}


		[TestCaseSource(typeof(RemoveElementsLastLinkedListTestSource))]
		public void RemoveElementsLastTest(int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsLast(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeEmptyLinkedListTestSource))]
		public void RemoveElementsLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.RemoveElementsLast(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeLinkedListTestSource))]
		public void RemoveElementsLastNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsLast(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsFirstLinkedListTestSource))]
		public void RemoveElementsFirstTest(int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsFirst(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeEmptyLinkedListTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.RemoveElementsFirst(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeLinkedListTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsFirst(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsByIndexLinkedListTestSource))]
		public void RemoveElementsByIndexTest(int index, int numberOfElements, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.RemoveElementsByIndex(index, numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeEmptyLinkedListTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeIndexLinkedListTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberLinkedListTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberOutOfRangeLinkedListTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsOutOfRangeArray_ShuoldThrowException(int index, int numberOfElements, LinkedList list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}


		[TestCaseSource(typeof(FindByIndexLinkedListTestSource))]
		public void FindByIndexTest(int index, LinkedList list, int expected)
		{
			int actual = list.FindByIndex(index);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(FindByIndexNegativeEmptyLinkedListTestSource))]
		public void FindByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.FindByIndex(index));
		}
		[TestCaseSource(typeof(FindByIndexNegativeLinkedListTestSource))]
		public void FindByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.FindByIndex(index));
		}


		[TestCaseSource(typeof(IndexByValueLinkedListTestSource))]
		public void IndexByValueTest(int value, LinkedList list, int expected)
		{
			int actual = list.IndexByValue(value);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(IndexByValueNegativeEmptyLinkedListTestSource))]
		public void IndexByValueNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.IndexByValue(value));
		}


		[TestCaseSource(typeof(ChangeByIndexLinkedListTestSource))]
		public void ChangeByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.ChangeByIndex(index, value);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeEmptyLinkedListTestSource))]
		public void ChangeByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int value, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.ChangeByIndex(index, value));
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeLinkedListTestSource))]
		public void ChangeByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int value, LinkedList list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.ChangeByIndex(index, value));
		}


		[TestCaseSource(typeof(ReverseLinkedListTestSource))]
		public void ReverseTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.Reverse();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(GetMinElementArrayLinkedListTestSource))]
		public void GetMinElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetMinElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<NullReferenceException>(() => list.GetMinElementList());
		}


		[TestCaseSource(typeof(GetMaxElementArrayLinkedListTestSource))]
		public void GetMaxElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetMaxElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<NullReferenceException>(() => list.GetMaxElementList());
		}


		[TestCaseSource(typeof(GetIndexMinElementArrayLinkedListTestSource))]
		public void GetIndexMinElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetIndexMinElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<NullReferenceException>(() => list.GetIndexMinElementList());
		}


		[TestCaseSource(typeof(GetIndexMaxElementArrayLinkedListTestSource))]
		public void GetIndexMaxElementArrayTest(LinkedList list, int expected)
		{
			int actual = list.GetIndexMaxElementList();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			LinkedList list = new LinkedList();
			Assert.Throws<NullReferenceException>(() => list.GetIndexMaxElementList());
		}


		[TestCaseSource(typeof(AscendingSortLinkedListTestSource))]
		public void AscendingSortTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.AscendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DescendingSortLinkedListTestSource))]
		public void DescendingSortTest(LinkedList list, LinkedList expectedList)
		{
			LinkedList actualList = list;
			actualList.DescendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DeletFirstNumberLinkedListTestSource))]
		public void DeletFirstNumberTest(int value, LinkedList list, LinkedList expectedList, int expected)
		{
			int actual = list.DeletFirstNumber(value);
			LinkedList actualList = list;
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletFirstNumberNegativeEmptyLinkedListTestSource))]
		public void DeletFirstNumberNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.DeletFirstNumber(value));
		}


		[TestCaseSource(typeof(DeletAllNumbersLinkedListTestSource))]
		public void DeletAllNumbersTest(int value, LinkedList list, LinkedList expectedList, int expectedNumber)
		{
			int actualNumber = list.DeletAllNumbers(value);
			LinkedList actualList = list;
			Assert.AreEqual(expectedNumber, actualNumber);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletAllNumbersNegativeEmptyLinkedListTestSource))]
		public void DeletAllNumbersNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, LinkedList list)
		{
			Assert.Throws<NullReferenceException>(() => list.DeletAllNumbers(value));
		}



		[TestCaseSource(typeof(GetLengthLinkedListTestSource))]
		public void GetLengthTest(LinkedList list, int expected)
		{
			int actual = list.Length;
			Assert.AreEqual(expected, actual);
		}


		[TestCaseSource(typeof(AddListLastLinkedListTestSource))]
		public void AddListLastTest(LinkedList firstList, LinkedList secondList, LinkedList expectedList)
		{
			LinkedList actualList = firstList;
			firstList.AddListLast(secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListLastNegativeLinkedListTestSource))]
		public void AddListLastNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListLast(secondList));
		}

		[TestCaseSource(typeof(AddListLastNegativeEmptyLinkedListTestSource))]
		public void AddListLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListLast(secondList));
		}


		[TestCaseSource(typeof(AddListFirstLinkedListTestSource))]
		public void AddListFirstTest(LinkedList firstList, LinkedList secondList, LinkedList expectedList)
		{
			LinkedList actualList = firstList;
			firstList.AddListFirst(secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListFirstNegativeLinkedListTestSource))]
		public void AddListFirstNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListFirst(secondList));
		}
		[TestCaseSource(typeof(AddListFirstNegativeEmptyLinkedListTestSource))]
		public void AddListFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListFirst(secondList));
		}


		[TestCaseSource(typeof(AddListByIndexLinkedListTestSource))]
		public void AddListByIndexTest(int index, LinkedList firstList, LinkedList secondList, LinkedList expectedList)
		{
			LinkedList actualList = firstList;
			firstList.AddListByIndex(index, secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListByIndexNegativeLinkedListTestSource))]
		public void AddListByIndexNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(int index, LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListByIndex(index, secondList));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeEmptyLinkedListTestSource))]
		public void AddListByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListByIndex(index, secondList));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeIndexLinkedListTestSource))]
		public void AddListByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, LinkedList firstList, LinkedList secondList)
		{
			Assert.Throws<IndexOutOfRangeException>(() => firstList.AddListByIndex(index, secondList));
		}
	}
}
