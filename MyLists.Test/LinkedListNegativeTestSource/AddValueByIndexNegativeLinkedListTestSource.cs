using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, -1, new LinkedList(new int[] { 1, 2, 3 }) };
			yield return new object[] { 10, 1, new LinkedList(new int[] { 55 }) };
		}
	}
}
