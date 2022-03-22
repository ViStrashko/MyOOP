using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, 1, new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 1, 14, 2, 3 }) };
			yield return new object[] { 10, 0, new ArrayList(new int[] { 55 }), new ArrayList(new int[] { 10, 55 }) };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { 55, 0, new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
		}
	}
}
