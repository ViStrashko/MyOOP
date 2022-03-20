using System;
namespace MyLists
{
	public class ArrayList
	{
		public int Length { get; private set; }

		private int[] _array;

		public ArrayList()
		{
			_array = new int[10];
			Length = 0;
		}

		public ArrayList(int value)
		{
			_array = new int[10];
			_array[0] = value;
			Length = 1;
		}

		public ArrayList(int[] array)
		{
			_array = new int[10];
			Length = array.Length;
			if (array.Length > _array.Length)
			{
				UpSize();
			}
			int j = 0;
			for (int i = 0; i < array.Length; i++)
			{
				_array[i] = array[j++];
			}
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
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
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
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			Remove(Length - 1);
			Length--;
		}

		public void RemoveOneElementFirst()
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			Remove(0);
			Length--;
		}

		public void RemoveOneElementByIndex(int index)
		{
			if (Length < 1)
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
			if (Length < 1)
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
			if (Length < 1)
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
			if (Length < 1)
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

		public int FindByIndex(int index)
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the array");
			}
			return _array[index];
		}

		public int IndexByValue(int value)
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			for (int i = 0; i < Length; i++)
			{
				if (_array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public void ChangeByIndex(int index, int value)
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the array");
			}
			_array[index] = value;
		}

		public void Reverse()
		{
			int j = 0;
			int[] newArray = new int[Length];
			for (int i = (Length-1); i >= 0; i--)
			{
				 newArray[j++] = _array[i];
			}
			_array = newArray;
		}

		public int GetMinElementArray()
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int min;
			min = _array[0];
			for (int i = 1; i < Length; i++)
			{
				if (_array[i] < min)
				{
					min = _array[i];
				}
			}
			return min;
		}

		public int GetMaxElementArray()
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int max;
			max = _array[0];
			for (int i = 1; i < Length; i++)
			{
				if (_array[i] > max)
				{
					max = _array[i];
				}
			}
			return max;
		}

		public int GetIndexMinElementArray()
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int min;
			int index = 0;
			min = _array[0];
			for (int i = 1; i < Length; i++)
			{
				if (_array[i] < min)
				{
					min = _array[i];
					index = i;
				}
			}
			return index;
		}

		public int GetIndexMaxElementArray()
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int max;
			int index = 0;
			max = _array[0];
			for (int i = 1; i < Length; i++)
			{
				if (_array[i] > max)
				{
					max = _array[i];
					index = i;
				}
			}
			return index;
		}

		public void AscendingSort()
		{
			int tmp;
			for (int i = 0; i < Length; i++)
			{
				for (int j = i + 1; j < Length; j++)
				{
					if (_array[i] > _array[j])
					{
						tmp = _array[i];
						_array[i] = _array[j];
						_array[j] = tmp;
					}
				}
			}
		}

		public void DescendingSort()
		{
			int tmp;
			for (int i = 0; i < Length; i++)
			{
				for (int j = i + 1; j < Length; j++)
				{
					if (_array[i] < _array[j])
					{
						tmp = _array[j];
						_array[j] = _array[i];
						_array[i] = tmp;
					}
				}
			}
		}

		public int DeletFirstNumber(int value)
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int index = 0;
			for (int i = 0; i < Length; i++)
			{
				if (_array[i] == value)
				{
					index = i;
					Remove(index);
					Length--;
					return index;
				}
			}
			return -1;
		}

		public int DeletAllNumbers(int value)
		{
			if (Length < 1)
			{
				throw new ArgumentException("The array is empty");
			}
			int count = 0;
			for (int i = 0; i < Length; i++)
			{
				if (_array[i] == value)
				{
					Remove(i);
					i--;
					count++;
					Length--;
				}
			}
			return count;
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
			if (numberOfElements > (Length - index))
			{
				throw new ArgumentException("Removing array elements from this index goes beyond the size of the array");
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
