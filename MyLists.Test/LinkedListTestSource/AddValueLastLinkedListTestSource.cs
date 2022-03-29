using System.Collections;

namespace MyLists.Test
{
	public class AddValueLastLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3, 14 }) };
			yield return new object[] { 10, new LinkedList(new int[] { 55 }), new LinkedList(new int[] { 55, 10 }) };
			yield return new object[] { 55, new LinkedList(new int[] { }), new LinkedList(new int[] { 55 }) };
		}
	}
}
