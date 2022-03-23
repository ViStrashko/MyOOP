using System.Collections;

namespace MyLists.Test
{
	public class ChangeByIndexTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, 55, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 55, 3 }) };
			yield return new object[] { 0, 55, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 55, 2, 3 }) };
		}
	}
}
