using System;
namespace MyLists
{
	public class ArrayList
	{
		public int Length { get; private set; }

		private int[] _array;

		public ArrayList()
		{
			_array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			Length = 5;
		}

		public void AddValueLast(int value)
		{
			Insert(Length);
			_array[Length] = value;
			Length++;
		}

		public void AddValueFirst(int value)
		{
			Insert(0);
			_array[0] = value;
			Length++;
		}

		public void AddValueByIndex(int value, int index)
		{
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the array");
			}
			Insert(index);
			_array[index] = value;
			Length++;
		}

		public void RemoveOneElementLast()
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			Remove(Length - 1);
			Length--;
		}

		public void RemoveOneElementFirst()
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			Remove(0);
			Length--;
		}

		public void RemoveOneElementByIndex(int index)
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the array");
			}
			Remove(index);
			Length--;
		}

		public void RemoveElementsLast(int numberOfElements)
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			RemoveMultipleElements(Length, numberOfElements);
			Length -= numberOfElements;
		}

		public void RemoveElementsFirst(int numberOfElements)
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			RemoveMultipleElements(0, numberOfElements);
			Length -= numberOfElements;
		}

		public void RemoveElementsByIndex(int index, int numberOfElements)
		{
			if (Length == 0)
			{
				throw new ArgumentException("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the array");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			RemoveMultipleElementsByIndex(index, numberOfElements);
			Length -= numberOfElements;
		}

		public void Write()
		{
			Console.Write($"L={Length} RL={_array.Length}   ");
			for (int i = 0; i < Length; i++)
			{
				Console.Write($"{_array[i]} ");
			}
		}

		private void UpSize()
		{
			int newLength = (int)(_array.Length * 1.5);
			int[] newArray = new int[newLength];
			for (int i = 0; i < _array.Length; i++)
			{
				newArray[i] = _array[i];
			}
			_array = newArray;
		}
		private void Insert(int index)
		{
			int[] newArray = new int[Length + 1];
			for (int i = 0; i < index; i++)
			{
				newArray[i] = _array[i];
			}
			for (int i = index; i < Length; i++)
			{
				newArray[i + 1] = _array[i];
			}
			_array = newArray;
		}

		private void Remove(int index)
		{
			int[] newArray = new int[Length - 1];
			for (int i = 0; i < index; i++)
			{
				newArray[i] = _array[i];
			}
			for (int i = index + 1; i < Length; i++)
			{
				newArray[i - 1] = _array[i];
			}
			_array = newArray;
		}

		private void RemoveMultipleElements(int index, int numberOfElements)
		{
			int[] newArray = new int[Length - numberOfElements];
			for (int i = 0; i < (index-numberOfElements); i++)
			{
				newArray[i] = _array[i];
			}
			for (int i = index + numberOfElements; i < Length; i++)
			{
				newArray[i-numberOfElements] = _array[i];
			}
			_array = newArray;
		}

		private void RemoveMultipleElementsByIndex(int index, int numberOfElements)
		{
			if (numberOfElements > (_array[Length] - _array[index]))
			{
				throw new ArgumentException("Deleting array elements goes beyond the size of the array");
			}
			int[] newArray = new int[Length - numberOfElements];
			for (int i = 0; i < index; i++)
			{
				newArray[i] = _array[i];
			}
			for (int i = index + numberOfElements; i < Length; i++)
			{
				newArray[i - numberOfElements] = _array[i];
			}
			_array = newArray;
		}
	}
}
