using System.Collections;

namespace MyLists.Test
{
	public class AddListLastNegativeEmptyCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { }), new LinkedList(new int[] { 1, 5 }) };
		}
	}
}
