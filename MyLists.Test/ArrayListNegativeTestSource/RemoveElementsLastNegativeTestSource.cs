using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsLastNegativeTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 4, new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
