using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { }) };
		}
	}
}
