using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsLastNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 4, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
