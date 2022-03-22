using System.Collections;

namespace MyLists.Test
{
	public class DeletFirstNumberTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 55, new ArrayList(new int[] { 55, 2, -3, -15 }), new ArrayList(new int[] { 2, -3, -15 }), 0 };
			yield return new object[] { -15, new ArrayList(new int[] { 55, 2, -3, -15 }), new ArrayList(new int[] { 55, 2, -3 }), 3 };
			yield return new object[] { 20, new ArrayList(new int[] { 55, 2, -3, -15 }), new ArrayList(new int[] { 55, 2, -3, -15 }), -1 };
			yield return new object[] {5, new ArrayList(new int[] { 5 }), new ArrayList(new int[] { }), 0 };
			//Отбить как ошибку, и есть ошибка в ArrayList
			yield return new object[] { 20, new ArrayList(new int[] { }), new ArrayList(new int[] { }), 0 };
		}
	}
}
