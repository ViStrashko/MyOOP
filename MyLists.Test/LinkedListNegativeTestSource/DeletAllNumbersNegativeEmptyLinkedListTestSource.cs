using System.Collections;

namespace MyLists.Test
{
	public class DeletAllNumbersNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 20, new LinkedList(new int[] { }) };
		}
	}
}
