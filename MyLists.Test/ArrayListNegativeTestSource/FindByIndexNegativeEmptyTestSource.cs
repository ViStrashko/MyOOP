using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 3, new ArrayList(new int[] { }) };
		}
	}
}
