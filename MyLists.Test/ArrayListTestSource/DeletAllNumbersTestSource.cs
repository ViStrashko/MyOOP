using System.Collections;

namespace MyLists.Test
{
	public class DeletAllNumbersTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, new ArrayList(new int[] { 55, 2, 55, 55, -3, -15, 55 }), new ArrayList(new int[] { 2, -3, -15 }), 4 };
			yield return new object[] { 20, new ArrayList(new int[] { 55, 2, -3, -15 }), new ArrayList(new int[] { 55, 2, -3, -15 }), 0 };
			yield return new object[] { 5, new ArrayList(new int[] { 5 }), new ArrayList(new int[] { }), 1 };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { 20, new ArrayList(new int[] { }), new ArrayList(new int[] { }), 0 };
		}
	}
}
