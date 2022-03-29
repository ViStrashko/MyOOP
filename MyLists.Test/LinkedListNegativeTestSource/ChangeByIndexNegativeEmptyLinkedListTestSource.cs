using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 55, new LinkedList(new int[] { }) };
		}
	}
}
