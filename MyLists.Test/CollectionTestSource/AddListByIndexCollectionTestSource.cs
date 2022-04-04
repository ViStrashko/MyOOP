using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 1, 1 }), new ArrayList(new int[] { 5, 1, 1, 6, 7 }) };
			yield return new object[] { 2, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 1, 1 }), new ArrayList(new int[] { 5, 6, 1, 1, 7 }) };
			yield return new object[] { 0, new ArrayList(new int[] { -11 }), new ArrayList(new int[] { 1, 1 }), new ArrayList(new int[] { 1, 1, -11 }) };
			yield return new object[] { 0, new ArrayList(new int[] { -11 }), new ArrayList(new int[] { }), new ArrayList(new int[] { -11 }) };

			yield return new object[] { 1, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 1, 5, 5, 2, 3 }) };
			yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 1, 2, 5, 5, 3 }) };
			yield return new object[] { 0, new LinkedList(new int[] { -1 }), new LinkedList(new int[] { 5, 5 }), new LinkedList(new int[] { 5, 5, -1 }) };
		}
	}
}
