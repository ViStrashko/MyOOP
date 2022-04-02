using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementFirstCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 6, 7 }) };
			yield return new object[] { new ArrayList(new int[] { 5 }), new ArrayList(new int[] { }) };

			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 2, 3 }) };
			yield return new object[] { new LinkedList(new int[] { 55 }), new LinkedList(new int[] { }) };
		}
	}
}
