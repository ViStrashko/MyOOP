using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementByIndexNegativeEmptyLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new LinkedList(new int[] { }) };
		}
	}
}
