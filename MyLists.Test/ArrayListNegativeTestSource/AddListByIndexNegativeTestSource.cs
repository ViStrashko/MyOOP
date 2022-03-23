using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 1, null };
		}
	}
}
