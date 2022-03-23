using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexNegativeTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, 55, new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
