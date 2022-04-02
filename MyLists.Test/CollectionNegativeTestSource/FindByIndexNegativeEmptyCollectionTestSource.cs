using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 3, new ArrayList(new int[] { }) };

			yield return new object[] { 4, new LinkedList(new int[] { }) };
		}
	}
}
