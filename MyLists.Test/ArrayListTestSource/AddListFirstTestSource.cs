using System.Collections;

namespace MyLists.Test
{
	public class AddListFirstTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3, 1, 2, 3 }) };
			yield return new object[] { new ArrayList(new int[] { -1 }), new ArrayList(new int[] { -1, -1 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
		}
	}
}
