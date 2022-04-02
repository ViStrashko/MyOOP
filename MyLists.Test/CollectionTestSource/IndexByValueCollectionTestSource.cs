using System.Collections;

namespace MyLists.Test
{
	public class IndexByValueCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 5, new ArrayList(new int[] { 5, 6, 7, 5 }), 0 };
			yield return new object[] { -5, new ArrayList(new int[] { 5, 6, 7, -5 }), 3 };
			yield return new object[] { 9, new ArrayList(new int[] { 5, 6, 7, 8 }), -1 };

			yield return new object[] { 1, new LinkedList(new int[] { 1, 2, 3, 1 }), 0 };
			yield return new object[] { -1, new LinkedList(new int[] { 1, 2, 3, -1 }), 3 };
			yield return new object[] { 5, new LinkedList(new int[] { 1, 2, 3, 4 }), -1 };
		}
	}
}
