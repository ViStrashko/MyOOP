using System.Collections;

namespace MyLists.Test
{
	public class ReverseTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 3, 2, 1 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
		}
	}
}
