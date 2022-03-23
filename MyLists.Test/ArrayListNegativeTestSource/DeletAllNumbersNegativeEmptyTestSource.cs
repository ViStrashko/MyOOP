using System.Collections;

namespace MyLists.Test
{
	public class DeletAllNumbersNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 20, new ArrayList(new int[] { }) };
		}
	}
}
