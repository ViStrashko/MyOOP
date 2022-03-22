using System.Collections;

namespace MyLists.Test
{
	public class RemoveOneElementFirstTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { new ArrayList(new int[] { 1, 2, 3 }), new ArrayList(new int[] { 2, 3 }) };
			yield return new object[] { new ArrayList(new int[] { 55 }), new ArrayList(new int[] { }) };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { new ArrayList(new int[] { }), new ArrayList(new int[] { }) };
		}
	}
}
