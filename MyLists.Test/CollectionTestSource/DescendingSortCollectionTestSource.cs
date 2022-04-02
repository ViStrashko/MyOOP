using System.Collections;

namespace MyLists.Test
{
	public class DescendingSortCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 7, 55, -8, -15 }), new ArrayList(new int[] { 55, 7, -8, -15 }) };
			yield return new object[] { new ArrayList(new int[] { 5, 5, 5, 5 }), new ArrayList(new int[] { 5, 5, 5, 5 }) };
			yield return new object[] { new ArrayList(new int[] { 1, 5, 4, 3, 2 }), new ArrayList(new int[] { 5, 4, 3, 2, 1 }) };
			yield return new object[] { new ArrayList(new int[] { 5, 4, 3, 2, 1 }), new ArrayList(new int[] { 5, 4, 3, 2, 1 }) };
			yield return new object[] { new ArrayList(new int[] { 0, 0, 0 }), new ArrayList(new int[] { 0, 0, 0 }) };
			yield return new object[] { new ArrayList(new int[] { 2 }), new ArrayList(new int[] { 2 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };

			yield return new object[] { new LinkedList(new int[] { 2, 55, -3, -15 }), new LinkedList(new int[] { 55, 2, -3, -15 }) };
			yield return new object[] { new LinkedList(new int[] { 5, 5, 5, 5 }), new LinkedList(new int[] { 5, 5, 5, 5 }) };
			yield return new object[] { new LinkedList(new int[] { 1, 5, 4, 3, 2 }), new LinkedList(new int[] { 5, 4, 3, 2, 1 }) };
			yield return new object[] { new LinkedList(new int[] { 5, 4, 3, 2, 1 }), new LinkedList(new int[] { 5, 4, 3, 2, 1 }) };
			yield return new object[] { new LinkedList(new int[] { 0, 0, 0 }), new LinkedList(new int[] { 0, 0, 0 }) };
			yield return new object[] { new LinkedList(new int[] { 2 }), new LinkedList(new int[] { 2 }) };
			yield return new object[] { new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
		}
	}
}
