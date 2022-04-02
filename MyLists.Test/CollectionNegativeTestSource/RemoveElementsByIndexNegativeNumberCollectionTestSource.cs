using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexNegativeNumberCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { 5 }) };

			yield return new object[] { 0, 3, new LinkedList(new int[] { 5 }) };
		}
	}
}
