using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { 5 }) };
		}
	}
}
