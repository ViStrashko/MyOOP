using System.Collections;

namespace MyLists.Test
{
	public class AddValueFirstLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 14, 1, 2, 3 }) };
			yield return new object[] { 10, new LinkedList(new int[] { 55 }), new LinkedList(new int[] { 10, 55 }) };
			yield return new object[] { 55, new LinkedList(new int[] { }), new LinkedList(new int[] { 55 }) };
		}
	}
}
