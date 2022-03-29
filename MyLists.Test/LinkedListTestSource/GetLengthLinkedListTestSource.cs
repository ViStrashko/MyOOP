using System.Collections;

namespace MyLists.Test
{
	public class GetLengthLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), 3 };
			yield return new object[] { new LinkedList(new int[] { 555 }), 1 };
			yield return new object[] { new LinkedList(new int[] { }), 0 };
		}
	}
}
