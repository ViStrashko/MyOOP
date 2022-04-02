using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, 55, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { -2, 15, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
