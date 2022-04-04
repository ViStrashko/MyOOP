using NUnit.Framework;
using System;

namespace MyLists.Test
{
	[TestFixture]
	public class CollectionTest
	{
		[TestCaseSource(typeof(AddValueLastCollectionTestSource))]
		public void AddValueLastTest(int value, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.AddValueLast(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueFirstCollectionTestSource))]
		public void AddValueFirstTest(int value, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.AddValueFirst(value);
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(AddValueByIndexCollectionTestSource))]
		public void AddValueByIndexTest(int value, int index, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.AddValueByIndex(value, index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeEmptyCollectionTestSource))]
		public void AddValueByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, int index, ICollection list)
		{
			Assert.Throws<Exception>(() => list.AddValueByIndex(value, index));
		}
		[TestCaseSource(typeof(AddValueByIndexNegativeCollectionTestSource))]
		public void AddValueByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int value, int index, ICollection list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.AddValueByIndex(value, index));
		}


		[TestCaseSource(typeof(RemoveOneElementLastCollectionTestSource))]
		public void RemoveOneElementLastTest(ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveOneElementLast();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.RemoveOneElementLast());
			Assert.Throws<Exception>(() => list2.RemoveOneElementLast());
		}


		[TestCaseSource(typeof(RemoveOneElementFirstCollectionTestSource))]
		public void RemoveOneElementFirstTest(ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveOneElementFirst();
			Assert.AreEqual(expectedList, actualList);
		}
		[Test]
		public void RemoveOneElementFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.RemoveOneElementFirst());
			Assert.Throws<Exception>(() => list2.RemoveOneElementFirst());
		}


		[TestCaseSource(typeof(RemoveOneElementByIndexCollectionTestSource))]
		public void RemoveOneElementByIndexTest(int index, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveOneElementByIndex(index);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeEmptyCollectionTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ICollection list)
		{
			Assert.Throws<Exception>(() => list.RemoveOneElementByIndex(index));
		}
		[TestCaseSource(typeof(RemoveOneElementByIndexNegativeCollectionTestSource))]
		public void RemoveOneElementByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ICollection list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveOneElementByIndex(index));
		}


		[TestCaseSource(typeof(RemoveElementsLastCollectionTestSource))]
		public void RemoveElementsLastTest(int numberOfElements, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveElementsLast(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeEmptyCollectionTestSource))]
		public void RemoveElementsLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, ICollection list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsLast(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsLastNegativeCollectionTestSource))]
		public void RemoveElementsLastNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, ICollection list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsLast(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsFirstCollectionTestSource))]
		public void RemoveElementsFirstTest(int numberOfElements, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveElementsFirst(numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeEmptyCollectionTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int numberOfElements, ICollection list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsFirst(numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsFirstNegativeCollectionTestSource))]
		public void RemoveElementsFirstNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int numberOfElements, ICollection list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsFirst(numberOfElements));
		}


		[TestCaseSource(typeof(RemoveElementsByIndexCollectionTestSource))]
		public void RemoveElementsByIndexTest(int index, int numberOfElements, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.RemoveElementsByIndex(index, numberOfElements);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeEmptyCollectionTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int numberOfElements, ICollection list)
		{
			Assert.Throws<Exception>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeIndexCollectionTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, ICollection list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberCollectionTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsLessEqualToZeroAndMoreLength_ShuoldThrowException(int index, int numberOfElements, ICollection list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}
		[TestCaseSource(typeof(RemoveElementsByIndexNegativeNumberOutOfRangeCollectionTestSource))]
		public void RemoveElementsByIndexNegativeTest_WhenNunberElementsOutOfRangeArray_ShuoldThrowException(int index, int numberOfElements, ICollection list)
		{
			Assert.Throws<ArgumentException>(() => list.RemoveElementsByIndex(index, numberOfElements));
		}


		[TestCaseSource(typeof(FindByIndexCollectionTestSource))]
		public void FindByIndexTest(int index, ICollection list, int expected)
		{
			int actual = list.FindByIndex(index);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(FindByIndexNegativeEmptyCollectionTestSource))]
		public void FindByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ICollection list)
		{
			Assert.Throws<Exception>(() => list.FindByIndex(index));
		}
		[TestCaseSource(typeof(FindByIndexNegativeCollectionTestSource))]
		public void FindByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ICollection list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.FindByIndex(index));
		}


		[TestCaseSource(typeof(IndexByValueCollectionTestSource))]
		public void IndexByValueTest(int value, ICollection list, int expected)
		{
			int actual = list.IndexByValue(value);
			Assert.AreEqual(expected, actual);
		}
		[TestCaseSource(typeof(IndexByValueNegativeEmptyCollectionTestSource))]
		public void IndexByValueNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ICollection list)
		{
			Assert.Throws<Exception>(() => list.IndexByValue(value));
		}


		[TestCaseSource(typeof(ChangeByIndexCollectionTestSource))]
		public void ChangeByIndexTest(int index, int value, ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.ChangeByIndex(index, value);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeEmptyCollectionTestSource))]
		public void ChangeByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, int value, ICollection list)
		{
			Assert.Throws<Exception>(() => list.ChangeByIndex(index, value));
		}
		[TestCaseSource(typeof(ChangeByIndexNegativeCollectionTestSource))]
		public void ChangeByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, int value, ICollection list)
		{
			Assert.Throws<IndexOutOfRangeException>(() => list.ChangeByIndex(index, value));
		}


		[TestCaseSource(typeof(ReverseCollectionTestSource))]
		public void ReverseTest(ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.Reverse();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(GetMinElementArrayCollectionTestSource))]
		public void GetMinElementArrayTest(ICollection list, int expected)
		{
			int actual = list.GetMinElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.GetMinElementArray());
			Assert.Throws<Exception>(() => list2.GetMinElementArray());
		}


		[TestCaseSource(typeof(GetMaxElementArrayCollectionTestSource))]
		public void GetMaxElementArrayTest(ICollection list, int expected)
		{
			int actual = list.GetMaxElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.GetMaxElementArray());
			Assert.Throws<Exception>(() => list2.GetMaxElementArray());
		}


		[TestCaseSource(typeof(GetIndexMinElementArrayCollectionTestSource))]
		public void GetIndexMinElementArrayTest(ICollection list, int expected)
		{
			int actual = list.GetIndexMinElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMinElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.GetIndexMinElementArray());
			Assert.Throws<Exception>(() => list2.GetIndexMinElementArray());
		}


		[TestCaseSource(typeof(GetIndexMaxElementArrayCollectionTestSource))]
		public void GetIndexMaxElementArrayTest(ICollection list, int expected)
		{
			int actual = list.GetIndexMaxElementArray();
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void GetIndexMaxElementArrayNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException()
		{
			ICollection list = new ArrayList();
			ICollection list2 = new LinkedList();
			Assert.Throws<Exception>(() => list.GetIndexMaxElementArray());
			Assert.Throws<Exception>(() => list2.GetIndexMaxElementArray());
		}


		[TestCaseSource(typeof(AscendingSortCollectionTestSource))]
		public void AscendingSortTest(ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.AscendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DescendingSortCollectionTestSource))]
		public void DescendingSortTest(ICollection list, ICollection expectedList)
		{
			ICollection actualList = list;
			actualList.DescendingSort();
			Assert.AreEqual(expectedList, actualList);
		}


		[TestCaseSource(typeof(DeletFirstNumberCollectionTestSource))]
		public void DeletFirstNumberTest(int value, ICollection list, ICollection expectedList, int expected)
		{
			int actual = list.DeletFirstNumber(value);
			ICollection actualList = list;
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletFirstNumberNegativeEmptyCollectionTestSource))]
		public void DeletFirstNumberNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ICollection list)
		{
			Assert.Throws<Exception>(() => list.DeletFirstNumber(value));
		}


		[TestCaseSource(typeof(DeletAllNumbersCollectionTestSource))]
		public void DeletAllNumbersTest(int value, ICollection list, ICollection expectedList, int expectedNumber)
		{
			int actualNumber = list.DeletAllNumbers(value);
			ICollection actualList = list;
			Assert.AreEqual(expectedNumber, actualNumber);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(DeletAllNumbersNegativeEmptyCollectionTestSource))]
		public void DeletAllNumbersNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int value, ICollection list)
		{
			Assert.Throws<Exception>(() => list.DeletAllNumbers(value));
		}



	/*	[TestCaseSource(typeof(GetLengthTestSource))]
		public void GetLengthTest(ArrayList list, int expected)
		{
			int actual = list.Length;
			Assert.AreEqual(expected, actual);
		}


	*/	[TestCaseSource(typeof(AddListLastCollectionTestSource))]
		public void AddListLastTest(ICollection firstList, ICollection secondList, ICollection expectedList)
		{
			ICollection actualList = firstList;
			firstList.AddListLast(secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListLastNegativeCollectionTestSource))]
		public void AddListLastNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(ICollection firstList, ICollection secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListLast(secondList));
		}
		[TestCaseSource(typeof(AddListLastNegativeEmptyCollectionTestSource))]
		public void AddListLastNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(ICollection firstList, ICollection secondList)
		{
			Assert.Throws<Exception>(() => firstList.AddListLast(secondList));
		}


		[TestCaseSource(typeof(AddListFirstCollectionTestSource))]
		public void AddListFirstTest(ICollection firstList, ICollection secondList, ICollection expectedList)
		{
			ICollection actualList = firstList;
			firstList.AddListFirst(secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListFirstNegativeCollectionTestSource))]
		public void AddListFirstNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(ICollection firstList, ICollection secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListFirst(secondList));
		}
		[TestCaseSource(typeof(AddListFirstNegativeEmptyCollectionTestSource))]
		public void AddListFirstNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(ICollection firstList, ICollection secondList)
		{
			Assert.Throws<Exception>(() => firstList.AddListFirst(secondList));
		}


		[TestCaseSource(typeof(AddListByIndexCollectionTestSource))]
		public void AddListByIndexTest(int index, ICollection firstList, ICollection secondList, ICollection expectedList)
		{
			ICollection actualList = firstList;
			firstList.AddListByIndex(index, secondList);
			Assert.AreEqual(expectedList, actualList);
		}
		[TestCaseSource(typeof(AddListByIndexNegativeCollectionTestSource))]
		public void AddListByIndexNegativeTest_WhenLinkToTheNullList_ShuoldThrowException(int index, ICollection firstList, ICollection secondList)
		{
			Assert.Throws<NullReferenceException>(() => firstList.AddListByIndex(index, secondList));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeEmptyCollectionTestSource))]
		public void AddListByIndexNegativeTest_WhenLengthIsNotEqualToZero_ShuoldThrowException(int index, ICollection firstList, ICollection secondList)
		{
			Assert.Throws<Exception>(() => firstList.AddListByIndex(index, secondList));
		}
		[TestCaseSource(typeof(AddListByIndexNegativeIndexCollectionTestSource))]
		public void AddListByIndexNegativeTest_WhenIndexLessIsNotEqualToZeroAndMoreLength_ShuoldThrowException(int index, ICollection firstList, ICollection secondList)
		{
			Assert.Throws<IndexOutOfRangeException>(() => firstList.AddListByIndex(index, secondList));
		}
	}
}
