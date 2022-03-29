using System.Collections;

namespace MyLists.Test
{
	public class AscendingSortLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 55, 2, -3, -15 }), new LinkedList(new int[] { -15, -3, 2, 55 }) };
			yield return new object[] { new LinkedList(new int[] { 5, 5, 5, 5 }), new LinkedList(new int[] { 5, 5, 5, 5 }) };
			yield return new object[] { new LinkedList(new int[] { 5, 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3, 4, 5 }) };
			yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4, 5 }), new LinkedList(new int[] { 1, 2, 3, 4, 5 }) };
			yield return new object[] { new LinkedList(new int[] { 0, 0, 0 }), new LinkedList(new int[] { 0, 0, 0 }) };
			yield return new object[] { new LinkedList(new int[] { 2 }), new LinkedList(new int[] { 2 }) };
			yield return new object[] { new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
		}
	}
}
