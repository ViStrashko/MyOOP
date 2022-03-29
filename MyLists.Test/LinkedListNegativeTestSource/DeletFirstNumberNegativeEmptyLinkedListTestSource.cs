using System.Collections;

namespace MyLists.Test
{
	public class DeletFirstNumberNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 20, new LinkedList(new int[] { }) };
		}
	}
}
