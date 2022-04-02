using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { }) };

			yield return new object[] { 1, 3, new LinkedList(new int[] { }) };
		}
	}
}
