using System.Collections;

namespace MyLists.Test
{
	public class AddListFirstNegativeCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 5, 5 }), null };
			yield return new object[] { new ArrayList(new int[] { }), null };
			
			yield return new object[] { new LinkedList(new int[] { 1, 5 }), null };
			yield return new object[] { new LinkedList(new int[] { }), null };
		}
	}
}
