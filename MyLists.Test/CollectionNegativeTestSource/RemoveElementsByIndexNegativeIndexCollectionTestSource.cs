using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 2, new ArrayList(new int[] { 5 }) };
			yield return new object[] { -1, 2, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { 2, 3, new LinkedList(new int[] { 5 }) };
			yield return new object[] { -2, 3, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
