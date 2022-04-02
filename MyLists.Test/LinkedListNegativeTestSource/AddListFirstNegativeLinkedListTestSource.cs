using System.Collections;

namespace MyLists.Test
{
	public class AddListFirstNegativeLinkedListTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new LinkedList(new int[] { 1, 5 }), null };
			yield return new object[] { new LinkedList(new int[] { }), null };
		}
	}
}
