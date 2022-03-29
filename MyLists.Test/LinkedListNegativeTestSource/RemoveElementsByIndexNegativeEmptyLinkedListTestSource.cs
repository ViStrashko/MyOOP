using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new LinkedList(new int[] { }) };
		}
	}
}
