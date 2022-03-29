using System.Collections;

namespace MyLists.Test
{
	public class GetIndexMinElementArrayLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 55, 2, -3, -15 }), 3 };
			yield return new object[] { new LinkedList(new int[] { 5, 5, 5, 5 }), 0 };
			yield return new object[] { new LinkedList(new int[] { 2 }), 0 };
		}
	}
}
