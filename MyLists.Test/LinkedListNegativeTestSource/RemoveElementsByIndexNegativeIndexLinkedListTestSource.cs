using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeIndexLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 2, new LinkedList(new int[] { 5 }) };
			yield return new object[] { -1, 2, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
