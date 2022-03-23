using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 1, 2, 3, 2, 3 }) };
			yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 1, 2, 3, 3 }) };
			yield return new object[] { 0, new ArrayList(new int[] { -1 }), new ArrayList(new int[] { -1, -1 }) };
		}
	}
}
