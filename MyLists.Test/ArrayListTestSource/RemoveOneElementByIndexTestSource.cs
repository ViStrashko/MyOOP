using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementByIndexTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 2, 3 }) };
			yield return new object[] { 1, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 3 }) };
			yield return new object[] { 2, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2 }) };
			yield return new object[] { 0, new ArrayList(new int[] { 55 }), new ArrayList(new int[] { }) };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { 0, new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
			yield return new object[] { 3, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
			yield return new object[] { -1, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 2, 3 }) };
		}
	}
}
