using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsFirstNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 2, new LinkedList(new int[] { }) };
			yield return new object[] { 0, new LinkedList(new int[] { }) };
		}
	}
}
