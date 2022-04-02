using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsLastCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 6, 7 }) };
			yield return new object[] { 1, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 6 }) };
			yield return new object[] { 2, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5 }) };
			yield return new object[] { 3, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { }) };

			yield return new object[] { 0, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3 }) };
			yield return new object[] { 1, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2 }) };
			yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1 }) };
			yield return new object[] { 3, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { }) };
		}
	}
}
