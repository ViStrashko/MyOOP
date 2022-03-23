using System.Collections;

namespace MyLists.Test
{
	public class AddListByIndexNegativeEmptyTestSource: IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 0, new ArrayList(new int[] { }) };
		}
	}
}
