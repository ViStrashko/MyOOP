using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new LinkedList(new int[] { 5, 5 }), null };
			yield return new object[] { 1, null, null };
		}
	}
}
