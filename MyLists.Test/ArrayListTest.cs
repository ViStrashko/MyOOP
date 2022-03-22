using NUnit.Framework;
using MyLists;
using System.Collections;

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

		[TestCaseSource(typeof(AddValueByIndexSource))]
		public void AddValueByIndexTest(int value, int index, ArrayList list, ArrayList expectedList)
		{
			ArrayList actualList = list;
			actualList.AddValueByIndex(value, index);
			Assert.AreEqual(expectedList, actualList);
		}
	}
}
