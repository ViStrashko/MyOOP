using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsFirstNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 2, new ArrayList(new int[] { }) };
			yield return new object[] { 0, new ArrayList(new int[] { }) };

			yield return new object[] { 3, new LinkedList(new int[] { }) };
			yield return new object[] { 1, new LinkedList(new int[] { }) };
		}
	}
}
