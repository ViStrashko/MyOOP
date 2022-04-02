using System.Collections;

namespace MyLists.Test
{
	public class GetMaxElementArrayCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 55, 2, -3, -25 }), 55 };
			yield return new object[] { new ArrayList(new int[] { 5, 5, 5, 5 }), 5 };
			yield return new object[] { new ArrayList(new int[] { -2 }), -2 };

			yield return new object[] { new LinkedList(new int[] { 55, 2, -3, -15 }), 55 };
			yield return new object[] { new LinkedList(new int[] { 5, 5, 5, 5 }), 5 };
			yield return new object[] { new LinkedList(new int[] { -2 }), -2 };
		}
	}
}
