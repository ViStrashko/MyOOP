using NUnit.Framework;
using MyLists;
using System;

namespace MyLists.Test
{
	[TestFixture]
	public class ArrayListTest
	{
		[TestCase( , )]
		public void AddValueLastTest( , )
		{
			int[] array = ListsMock.GetMock(actualType);
			int[] expected = ListsMock.GetMock(expectedType);
			ArrayList list = new ArrayList(array);
			int[] actual = list.AddValueLast(5);
		    Assert.AreEqual(expected, actual);
		}
	}
}
