using System.Collections;

namespace MyLists.Test
{
	public class AddListFirstCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 6, 7, 5, 6, 7 }) };
			yield return new object[] { new ArrayList(new int[] { -11 }), new ArrayList(new int[] { -11 }), new ArrayList(new int[] { -11, -11 }) };
			yield return new object[] { new ArrayList(new int[] { -11 }), new ArrayList(new int[] { }), new ArrayList(new int[] { -11 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { -11 }), new ArrayList(new int[] { -11 }) };

			yield return new object[] { new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 3, 1, 2, 3 }) };
			yield return new object[] { new LinkedList(new int[] { -1 }), new LinkedList(new int[] { -1 }), new LinkedList(new int[] { -1, -1 }) };
		}
	}
}
