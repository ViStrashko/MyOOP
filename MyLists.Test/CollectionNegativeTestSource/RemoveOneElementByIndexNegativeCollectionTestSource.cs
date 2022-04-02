using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementByIndexNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 3, new ArrayList(new int[] { 1, 2, 3 }) };
			yield return new object[] { -1, new ArrayList(new int[] { 1, 2, 3 }) };

			yield return new object[] { 3, new LinkedList(new int[] { 5, 6, 7 }) };
			yield return new object[] { -1, new LinkedList(new int[] { 5, 6, 7 }) };
		}
	}
}
