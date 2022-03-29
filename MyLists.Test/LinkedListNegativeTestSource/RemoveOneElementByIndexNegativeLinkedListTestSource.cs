using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementByIndexNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 3, new LinkedList(new int[] { 1, 2, 3 }) };
			yield return new object[] { -1, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
