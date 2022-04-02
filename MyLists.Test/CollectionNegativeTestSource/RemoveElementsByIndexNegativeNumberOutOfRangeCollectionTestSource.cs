using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberOutOfRangeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 3, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { 1, 4, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
