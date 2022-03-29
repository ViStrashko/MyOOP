using System.Collections;

namespace MyLists.Test
{
	public class IndexByValueNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 3, new LinkedList(new int[] { }) };
		}
	}
}
