using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, 55, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
