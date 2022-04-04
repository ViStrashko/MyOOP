using System;

namespace MyLists
{
	public class ArrayList: ICollection
	{
		public int this[int index]
		{
			get
			{
				if (index < 0 || index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				return _array[index];
			}
			set
			{
				if (index < 0 || index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				_array[index] = value;
			}
		}

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
			if (array == null || array.Length == 0)
			{
				_array = new int[10];
				Length = 0;
			}
			else
			{
				_array = array;
				Length = array.Length;
				UpSize();
			}
		}

		public void AddValueLast(int value)
		{
			if (Length >= _array.Length)
			{
				UpSize();
			}
			_array[Length] = value;
			Length++;
		}

		public void AddValueFirst(int value)
		{
			if (Length >= _array.Length)
			{
				UpSize();
			}
			InsertFirst(0);
			_array[0] = value;
			Length++;
		}

		public void AddValueByIndex(int value, int index)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
			}
			if (Length >= _array.Length)
			{
				UpSize();
			}
			InsertByIndex(index);
			_array[index] = value;
			Length++;
		}

		public void RemoveOneElementLast()
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (Length <= _array.Length/2)
			{
				DownSize();
			}
			Length--;
		}

		public void RemoveOneElementFirst()
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			Remove(0);
			Length--;
		}

		public void RemoveOneElementByIndex(int index)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			Remove(index);
			Length--;
		}

		public void RemoveElementsLast(int numberOfElements)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			Length -= numberOfElements;
		}

		public void RemoveElementsFirst(int numberOfElements)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			RemoveMultipleElements(0, numberOfElements);
			Length -= numberOfElements;
		}

		public void RemoveElementsByIndex(int index, int numberOfElements)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the array");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			RemoveMultipleElements(index, numberOfElements);
			Length -= numberOfElements;
		}

		public int FindByIndex(int index)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
			}
			return _array[index];
		}

		public int IndexByValue(int value)
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
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
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
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
			UpSize();
		}

		public int GetMinElementArray()
		{
			if (Length < 1)
			{
				throw new Exception("The array is empty");
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
				throw new Exception("The array is empty");
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
				throw new Exception("The array is empty");
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
				throw new Exception("The array is empty");
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
				throw new Exception("The array is empty");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
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
				throw new Exception("The array is empty");
			}
			if (Length <= _array.Length / 2)
			{
				DownSize();
			}
			int count = 0;
			for (int i = 0; i < Length; i++)
			{
				if (_array[i] == value)
				{
					count++;
				}
				else
				{
					_array[i - count] = _array[i];
				}
			}
			Length -= count;
			return count;
		}

		public void AddListLast(ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is ArrayList))
			{
				throw new NullReferenceException();
			}
			ArrayList list = (ArrayList)interfaceList;
			int index = Length;
			AddListToList(list, index);
		}

		public void AddListFirst(ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is ArrayList))
			{
				throw new NullReferenceException();
			}
			ArrayList list = (ArrayList)interfaceList;
			AddListToList(list);
		}

		public void AddListByIndex(int index, ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is ArrayList))
			{
				throw new NullReferenceException();
			}
			if (Length < 1)
			{
				throw new Exception("The array is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the array");
			}
			ArrayList list = (ArrayList)interfaceList;
			AddListToList(list, index);
		}

		public override string ToString()
		{
			string s = "[";
			for (int i = 0; i < Length; i++)
			{
				s += $"{_array[i]} ";
			}
			s += "]";
			return s;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is ArrayList))
			{
				return false;
			}
			else
			{
				ArrayList list = (ArrayList)obj;
				if (list.Length != this.Length)
				{
					return false;
				}
				else
				{
					for (int i = 0; i < this.Length; i++)
					{
						if (list[i] != this[i])
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		private void UpSize()
		{
			int newLength = (int)(_array.Length * 1.5+1);
			int[] newArray = new int[newLength];
			for (int i = 0; i < _array.Length; i++)
			{
				newArray[i] = _array[i];
			}
			_array = newArray;
		}

		private void DownSize()
		{
			int newLength = _array.Length - (_array.Length/3);
			int[] newArray = new int[newLength];
			for (int i = 0; i < newArray.Length; i++)
			{
				  newArray[i] = _array[i];
			}
			_array = newArray;
		}

		private void InsertFirst(int index, int valueOffset=1)
		{
			for (int i = index; i < Length; i++)
			{
				_array[((Length - 1) - i) + valueOffset] = _array[(Length - 1) - i];
			}
		}

		public void InsertByIndex(int index, int valueOffset = 1)
		{
			int j = 0;
			for (int i = 0; i < index; i++)
			{
				_array[i] = _array[i];
			}
			for (int i = index; i < Length; i++)
			{
				_array[((Length - 1) - j) + valueOffset] = _array[(Length - 1) - j];
				j++;
			}
		}

		private void Remove(int index)
		{
			for (int i = 0; i < index; i++)
			{
				_array[i] = _array[i];
			}
			for (int i = index + 1; i < Length; i++)
			{
				_array[i - 1] = _array[i];
			}
		}

		private void RemoveMultipleElements(int index, int numberOfElements)
		{
			if (numberOfElements > (Length - index))
			{
				throw new ArgumentException("Removing array elements from this index goes beyond the size of the array");
			}
			for (int i = 0; i < index; i++)
			{
				_array[i] = _array[i];
			}
			for (int i = index + numberOfElements; i < Length; i++)
			{
				_array[i - numberOfElements] = _array[i];
			}
		}
		private void AddListToList(ArrayList list, int index = 0)
		{
			int[] tmp = new int[_array.Length + list.Length];
			for (int i = 0; i < index; i++)
			{
				tmp[i] = _array[i];
			}
			for (int i = list.Length + index; i < tmp.Length; i++)
			{
				tmp[i] = _array[i - list.Length];
			}
			for (int i = index; i < list.Length + index; i++)
			{
				tmp[i] = list[i - index];
			}
			Length += list.Length;
			_array = tmp;
		}
	}
}
