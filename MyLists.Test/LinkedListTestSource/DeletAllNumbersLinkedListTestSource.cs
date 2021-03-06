using System.Collections;

namespace MyLists.Test
{
	public class DeletAllNumbersLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, new LinkedList(new int[] { 55, 2, 55, 55, -3, -15, 55 }), new LinkedList(new int[] { 2, -3, -15 }), 4 };
			yield return new object[] { 20, new LinkedList(new int[] { 55, 2, -3, -15 }), new LinkedList(new int[] { 55, 2, -3, -15 }), 0 };
			yield return new object[] { 5, new LinkedList(new int[] { 5 }), new LinkedList(new int[] { }), 1 };
		}
	}
}
