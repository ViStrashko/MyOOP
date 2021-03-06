using System.Collections;

namespace MyLists.Test
{
	public class GetMinElementArrayLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 55, 2, -3, -15 }), -15 };
			yield return new object[] { new LinkedList(new int[] { 5, 5, 5, 5 }), 5 };
			yield return new object[] { new LinkedList(new int[] { 2 }), 2 };
		}
	}
}
