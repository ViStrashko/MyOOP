using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsLastNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 4, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { 4, new LinkedList(new int[] { 5, 6, 7 }) };
		}
	}
}
