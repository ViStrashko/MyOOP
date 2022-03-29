using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
