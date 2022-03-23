using System.Collections;

namespace MyLists.Test
{
	public class FindByIndexTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { 1, 2, 3 }), 1 };
			yield return new object[] { 3, new ArrayList(new int[] { 1, 2, 3, 4 }), 4 };
		}
	}
}
