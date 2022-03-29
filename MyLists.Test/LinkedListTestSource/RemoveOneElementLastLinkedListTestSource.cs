using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementLastLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2 }) };
			yield return new object[] { new LinkedList(new int[] { 55 }), new LinkedList(new int[] { }) };
		}
	}
}
