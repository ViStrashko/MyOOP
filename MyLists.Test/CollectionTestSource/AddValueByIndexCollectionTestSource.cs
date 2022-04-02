﻿using System.Collections;

namespace MyLists.Test
{
	public class AddValueByIndexCollectionTestSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new object[] { 14, 1, new ArrayList(new int[] { 5, 6, 7 }), new ArrayList(new int[] { 5, 14, 6, 7 }) };
			yield return new object[] { 14, 2, new ArrayList(new int[] {5, 6, 7 }), new ArrayList(new int[] { 5, 6, 14, 7 }) };
			yield return new object[] { 10, 0, new ArrayList(new int[] { 5 }), new ArrayList(new int[] { 10, 5 }) };

			yield return new object[] { 14, 1, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 14, 2, 3 }) };
			yield return new object[] { 14, 2, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 14, 3 }) };
			yield return new object[] { 10, 0, new LinkedList(new int[] { 55 }), new LinkedList(new int[] { 10, 55 }) };
		}
	}
}
