using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexNegativeEmptyTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, 0, new ArrayList(new int[] { }) };
		}
	}
}
