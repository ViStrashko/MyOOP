using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeIndexLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }) };
			yield return new object[] { 3, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }) };
			yield return new object[] { 1, new LinkedList(new int[] { -1 }), new LinkedList(new int[] { 5, 5 }) };
		}
	}
}
