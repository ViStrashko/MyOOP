using System.Collections;

namespace MyLists.Test
{
	public class DeletAllNumbersCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, new ArrayList(new int[] { 55, 7, 55, 55, -8, -15, 55 }), new ArrayList(new int[] { 7, -8, -15 }), 4 };
			yield return new object[] { 20, new ArrayList(new int[] { 55, 7, -8, -15 }), new ArrayList(new int[] { 55, 7, -8, -15 }), 0 };
			yield return new object[] { 55, new ArrayList(new int[] { 55 }), new ArrayList(new int[] { }), 1 };

			yield return new object[] { 55, new LinkedList(new int[] { 55, 2, 55, 55, -3, -15, 55 }), new LinkedList(new int[] { 2, -3, -15 }), 4 };
			yield return new object[] { 20, new LinkedList(new int[] { 55, 2, -3, -15 }), new LinkedList(new int[] { 55, 2, -3, -15 }), 0 };
			yield return new object[] { 5, new LinkedList(new int[] { 5 }), new LinkedList(new int[] { }), 1 };
		}
	}
}
