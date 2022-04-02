using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { 5, 6, 7 }), 5 };
			yield return new object[] { 3, new ArrayList(new int[] { 5, 6, 7, 8 }), 8 };

			yield return new object[] { 0, new LinkedList(new int[] { 1, 2, 3 }), 1 };
			yield return new object[] { 3, new LinkedList(new int[] { 1, 2, 3, 4 }), 4 };
		}
	}
}
