using System.Collections;

namespace MyLists.Test
{
	public class AscendingSortTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 55, 2, -3, -15 }), new ArrayList(new int[] { -15, -3, 2, 55 }) };
			yield return new object[] { new ArrayList(new int[] { 5, 5, 5, 5 }), new ArrayList(new int[] { 5, 5, 5, 5 }) };
			yield return new object[] { new ArrayList(new int[] { 0, 0, 0 }), new ArrayList(new int[] { 0, 0, 0 }) };
			yield return new object[] { new ArrayList(new int[] { 2 }), new ArrayList(new int[] { 2 }) };
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
		}
	}
}
