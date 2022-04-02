using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, 0, new ArrayList(new int[] { }) };

			yield return new object[] { 15, 0, new LinkedList(new int[] { }) };
		}
	}
}
