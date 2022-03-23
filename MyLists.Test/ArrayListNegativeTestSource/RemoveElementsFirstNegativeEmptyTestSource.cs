using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsFirstNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 2, new ArrayList(new int[] { }) };
			yield return new object[] { 0, new ArrayList(new int[] { }) };
		}
	}
}
