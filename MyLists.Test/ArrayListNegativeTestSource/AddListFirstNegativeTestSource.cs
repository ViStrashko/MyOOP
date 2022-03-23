using System.Collections;

namespace MyLists.Test
{
	public class AddListFirstNegativeTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { null };
		}
	}
}
