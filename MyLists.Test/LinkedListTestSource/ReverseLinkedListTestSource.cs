using System.Collections;

namespace MyLists.Test
{
	public class ReverseLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 3, 2, 1 }) };
			yield return new object[] { new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
		}
	}
}
