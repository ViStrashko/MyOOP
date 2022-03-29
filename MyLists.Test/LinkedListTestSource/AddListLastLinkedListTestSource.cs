using System.Collections;

namespace MyLists.Test
{
	public class AddListLastLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3, 1, 2, 3 }) };
			yield return new object[] { new LinkedList(new int[] { -1 }), new LinkedList(new int[] { -1 }), new LinkedList(new int[] { -1, -1 }) };
		}
	}
}
