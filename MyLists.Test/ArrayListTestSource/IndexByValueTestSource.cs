using System.Collections;

namespace MyLists.Test
{
	public class IndexByValueTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3, 1 }), 0 };
			yield return new object[] { -1, new ArrayList(new int[] { 1, 2, 3, -1 }), 3 };
			yield return new object[] { 5, new ArrayList(new int[] { 1, 2, 3, 4 }), -1 };
		}
	}
}
