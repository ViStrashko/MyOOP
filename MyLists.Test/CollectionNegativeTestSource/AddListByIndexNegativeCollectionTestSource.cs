using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new ArrayList(new int[] { 15, 15 }), null };
			yield return new object[] { 2, new ArrayList(new int[] { }), null };

			yield return new object[] { 1, new LinkedList(new int[] { 5, 5 }), null };
			yield return new object[] { 0, new LinkedList(new int[] { }), null };
		}
	}
}
