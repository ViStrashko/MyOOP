using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 1, 5, 5, 2, 3 }) };
			yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 1, 2, 5, 5, 3 }) };
			yield return new object[] { 0, new LinkedList(new int[] { -1 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 5, 5, -1 }) };
		}
	}
}
