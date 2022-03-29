using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, 0, new LinkedList(new int[] { }) };
		}
	}
}
