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
	}
	public class AddValueLastTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3, 14 }) };
			yield return new object[] { 5, new ArrayList(new int[] { 1 }), new ArrayList(new int[] { 1, 5 }) };
			yield return new object[] { 55, new ArrayList (new int[] { }), new ArrayList(new int[] { 55 }) };
		}
	}
}
