using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberOutOfRangeTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 3, new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
