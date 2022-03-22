using System.Collections;

namespace MyLists.Test
{
	public class AddValueLastTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3, 14 }) };
			yield return new object[] { 10, new ArrayList(new int[] { 55 }), new ArrayList(new int[] { 55, 10 }) };
			yield return new object[] { 55, new ArrayList(new int[] { }), new ArrayList(new int[] { 55 }) };
		}
	}
}
