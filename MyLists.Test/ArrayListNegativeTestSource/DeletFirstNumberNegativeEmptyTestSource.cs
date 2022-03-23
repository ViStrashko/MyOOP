using System.Collections;

namespace MyLists.Test
{
	public class DeletFirstNumberNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 20, new ArrayList(new int[] { }) };
		}
	}
}
