using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 55, new ArrayList(new int[] { }) };
		}
	}
}
