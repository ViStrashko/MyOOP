using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsFirstTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
			yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 2, 3 }) };
			yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 3 }) };
			yield return new object[] { 3, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { }) };
		}
	}
}
