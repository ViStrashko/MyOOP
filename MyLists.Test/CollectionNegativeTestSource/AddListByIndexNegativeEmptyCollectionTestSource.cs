using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new LinkedList(new int[] { }), new LinkedList(new int[] { 1, 2, 3 }) };
		}
	}
}
