using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, null, new LinkedList(new int[] { 1, 2, 3}) };
		}
	}
}
