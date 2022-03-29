using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberOutOfRangeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 3, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
