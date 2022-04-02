using System;

namespace MyLists
{
	public interface ICollection
	{
		void AddValueLast(int value);

		void AddValueFirst(int value);

		void AddValueByIndex(int value, int index);

		void RemoveOneElementLast();

		void RemoveOneElementFirst();

		void RemoveOneElementByIndex(int index);

		void RemoveElementsLast(int numberOfElements);

		void RemoveElementsFirst(int numberOfElements);

		void RemoveElementsByIndex(int index, int numberOfElements);

		int FindByIndex(int index);

		int IndexByValue(int value);

		void ChangeByIndex(int index, int value);

		void Reverse();

		int GetMinElementArray();

		int GetMaxElementArray();

		int GetIndexMinElementArray();

		int GetIndexMaxElementArray();

		void AscendingSort();

		void DescendingSort();

		int DeletFirstNumber(int value);

		int DeletAllNumbers(int value);

	/*	void AddListLast(ArrayList list);
		void AddListLast(LinkedList list);

		void AddListFirst(ArrayList list);
		void AddListFirst(LinkedList list);

		void AddListByIndex(int index, ArrayList list);
		void AddListByIndex(int index, LinkedList list);
	*/}
}
