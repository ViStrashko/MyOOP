using System.Collections;

namespace MyLists.Test
{
	public class AddValueFirstTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 14, 1, 2, 3 }) };
			yield return new object[] { 10, new ArrayList(new int[] { 55 }), new ArrayList(new int[] { 10, 55 }) };
			yield return new object[] { 55, new ArrayList(new int[] { }), new ArrayList(new int[] { 55 }) };
		}
	}
}
