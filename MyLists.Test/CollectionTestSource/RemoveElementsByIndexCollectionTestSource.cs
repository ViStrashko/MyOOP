using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 7 }) };
			yield return new object[] { 1, 2, new ArrayList(new int[] { 5, 6, 7, 8 }), new ArrayList(new int[] { 5, 8 }) };
			yield return new object[] { 0, 3, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { }) };
			yield return new object[] { 1, 0, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 6, 7 }) };

			yield return new object[] { 0, 2, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 3 }) };
			yield return new object[] { 1, 2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 4 }) };
			yield return new object[] { 0, 3, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { }) };
			yield return new object[] { 1, 0, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
