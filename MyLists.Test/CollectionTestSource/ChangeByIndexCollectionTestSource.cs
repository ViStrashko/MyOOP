using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 55, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 55, 7 }) };
			yield return new object[] { 0, 55, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 55, 6, 7 }) };

			yield return new object[] { 1, 55, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 55, 3 }) };
			yield return new object[] { 0, 55, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 55, 2, 3 }) };
		}
	}
}
