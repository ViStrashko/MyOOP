using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 55, new ArrayList(new int[] { }) };

			yield return new object[] { 1, 15, new LinkedList(new int[] { }) };
		}
	}
}
