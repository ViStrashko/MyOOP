using System.Collections;

namespace MyLists.Test
{
	public class ReverseCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 7, 6, 5 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };

			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 3, 2, 1 }) };
			yield return new object[] { new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
		}
	}
}
