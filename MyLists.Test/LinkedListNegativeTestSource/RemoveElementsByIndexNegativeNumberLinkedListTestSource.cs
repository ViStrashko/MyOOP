using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new LinkedList(new int[] { 5 }) };
		}
	}
}
