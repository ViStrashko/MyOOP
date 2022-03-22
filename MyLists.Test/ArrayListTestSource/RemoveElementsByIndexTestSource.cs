using System.Collections;

namespace MyLists.Test
{
	public class RemoveElementsByIndexTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, 2, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 3 }) };
			yield return new object[] { 1, 2, new ArrayList(new int[] { 1, 2, 3, 4 }), new ArrayList(new int[] { 1, 4 }) };
			yield return new object[] { 0, 3, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { }) };
			yield return new object[] { 1, 0, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { 0, 2, new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
			yield return new object[] { 1, 2, new ArrayList(new int[] { 5 }), new ArrayList(new int[] { 5 }) };
			yield return new object[] { 0, 2, new ArrayList(new int[] { 5 }), new ArrayList(new int[] { 5 }) };
			yield return new object[] { 1, 3, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
			yield return new object[] { -1, 2, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
