using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexNegativeTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { -1, new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
