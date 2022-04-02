using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { -2, new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
