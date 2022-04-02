using System.Collections;

namespace MyLists.Test
{
	public class DeletFirstNumberNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 20, new ArrayList(new int[] { }) };

			yield return new object[] { 10, new LinkedList(new int[] { }) };
		}
	}
}
