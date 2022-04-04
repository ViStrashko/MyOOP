using System;

namespace MyLists
{
	public class LinkedList: ICollection
	{
		private Node _root;

		private Node _tail;

		public int this[int index]
		{
			get
			{
				if (index < 0 || index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				Node crnt = _root;
				for (int i = 1; i <= index; i++)
				{
					crnt = crnt.Next;
				}
				return crnt.Value;
			}
			set
			{
				if (index < 0 || index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				Node crnt = _root;
				for (int i = 1; i <= index; i++)
				{
					crnt = crnt.Next;
				}
				crnt.Value = value;
			}
		}

		public int Length
		{
			get
			{
				int count = 0;
				Node crnt = _root;
				while (crnt != null)
				{
					crnt = crnt.Next;
					count++;
				}
				return count;
			}
			private set
			{
			}
		}

		public LinkedList()
		{
			_root = null;
			_tail = null;
		}

		public LinkedList(int value)
		{
			_root = new Node(value);
			_tail = _root;
		}

		public LinkedList(int[] values)
		{
			if (values == null || values.Length == 0)
			{
				_root = null;
				_tail = null;
			}
			else
			{
				_root = new Node(values[0]);
				_tail = _root;
				for (int i = 1; i < values.Length; i++)
				{
					_tail.Next = new Node(values[i]);
					_tail = _tail.Next;
				}
			}
		}

		public void AddValueLast(int value)
		{
			if (_root == null)
			{
				_root = new Node(value);
				_tail = _root;
			}
			else
			{
				_tail = GetLinkNode(Length - 1);
				_tail.Next = new Node(value);
				_tail = _tail.Next;
			}
		}

		public void AddValueFirst(int value)
		{
			if (_root == null)
			{
				_root = new Node(value);
				_tail = _root;
			}
			else
			{
				_tail = _root;
				_root = new Node(value);
				_root.Next = _tail;
			}
		}

		public void AddValueByIndex(int value, int index)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index <  0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			else
			{
				if (index == 0)
				{
					AddValueFirst(value);
				}
				else
				{
					Node root = GetLinkNode(index-1);
					Node tail = GetLinkNode(index);
					Node crnt = new Node(value);
					root.Next = crnt;
					crnt.Next = tail;
				}
			}
		}

		public void RemoveOneElementLast()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else
			{
				Node crnt = GetLinkNode(Length - 2);
				crnt.Next = null;
			}
		}

		public void RemoveOneElementFirst()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else
			{
				_root = _root.Next;
			}
		}

		public void RemoveOneElementByIndex(int index)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else if (index == 0)
			{
				RemoveOneElementFirst();
			}
			else
			{
				Node root = GetLinkNode(index - 1);
				Node tail = GetLinkNode(index + 1);
				root.Next = tail;
			}
		}

		public void RemoveElementsLast(int numberOfElements)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the list");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else
			{
				if (Length == numberOfElements)
				{
					_root = null;
				}
				else
				{
					Node crnt = GetLinkNode(Length - 1 - numberOfElements);
					crnt.Next = null;
				}
			}
		}

		public void RemoveElementsFirst(int numberOfElements)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the list");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else
			{
				int count = 0;
				while (count++ < numberOfElements)
				{
					_root = _root.Next;
				}
			}
		}

		public void RemoveElementsByIndex(int index, int numberOfElements)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the list");
			}
			if (numberOfElements > (Length - index))
			{
				throw new ArgumentException("Removing list elements from this index goes beyond the size of the list");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else if (index == 0)
			{
				Node tail = GetLinkNode(index + numberOfElements);
				_root = tail;
			}
			else
			{
				Node root = GetLinkNode(index - 1);
				Node tail = GetLinkNode(index + numberOfElements);
				root.Next = tail;
			}
		}

		public int FindByIndex(int index)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			Node crnt = GetLinkNode(index);
			return crnt.Value;
		}

		public int IndexByValue(int value)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value == value)
				{
					return i;
				}
				crnt = crnt.Next;
			}
			return -1;
		}

		public void ChangeByIndex(int index, int value)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			Node crnt = GetLinkNode(index);
			crnt.Value = value;
		}

		public void Reverse()
		{
			Node crnt = _root;
			Node prev = null;
			Node next = null;
			while (crnt != null)
			{
				next = crnt.Next;
				crnt.Next = prev;
				prev = crnt;
				crnt = next;
			}
			_root = prev;
		}

		public int GetMinElementArray()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			int min = _root.Value;
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value < min)
				{
					min = crnt.Value;
				}
				crnt = crnt.Next;
			}
			return min;
		}

		public int GetMaxElementArray()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			int max = _root.Value;
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value > max)
				{
					max = crnt.Value;
				}
				crnt = crnt.Next;
			}
			return max;
		}

		public int GetIndexMinElementArray()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			int index = 0;
			int min = _root.Value;
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value < min)
				{
					min = crnt.Value;
					index = i;
				}
				crnt = crnt.Next;
			}
			return index;
		}

		public int GetIndexMaxElementArray()
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			int index = 0;
			int max = _root.Value;
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value > max)
				{
					max = crnt.Value;
					index = i;
				}
				crnt = crnt.Next;
			}
			return index;
		}

		public void AscendingSort()
		{
			int length = Length;
			Node crnt;
			Node prev;
			for (int i = length - 2; i >= 0; i--)
			{
				if (i == 0)
				{
					crnt = _root;
					if (crnt.Next != null && crnt.Value > crnt.Next.Value)
					{
						_root = crnt.Next;
						crnt.Next = _root.Next;
						_root.Next = crnt;
					}
					prev = _root;
				}
				else 
				{
					prev = GetLinkNode(i - 1);
					crnt = prev.Next;
				}
				while (crnt.Next != null && crnt.Value > crnt.Next.Value)
				{
					prev.Next = crnt.Next;
					crnt.Next = prev.Next.Next;
					prev.Next.Next = crnt;
					prev = prev.Next;
				}
			}
			_tail = GetLinkNode(length - 1);
		}

		public void DescendingSort()
		{
			int length = Length;
			Node crnt;
			Node prev;
			for (int i = length - 2; i >= 0; i--)
			{
				if (i == 0)
				{
					crnt = _root;
					if (crnt.Next != null && crnt.Value < crnt.Next.Value)
					{
						_root = crnt.Next;
						crnt.Next = _root.Next;
						_root.Next = crnt;
					}
					prev = _root;
				}
				else
				{
					prev = GetLinkNode(i - 1);
					crnt = prev.Next;
				}
				while (crnt.Next != null && crnt.Value < crnt.Next.Value)
				{
					prev.Next = crnt.Next;
					crnt.Next = prev.Next.Next;
					prev.Next.Next = crnt;
					prev = prev.Next;
				}
			}
			_tail = GetLinkNode(length - 1);
		}

		public int DeletFirstNumber(int value)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			Node crnt = _root;
			for (int i = 0; i < Length; i++)
			{
				if (crnt.Value == value)
				{
					RemoveOneElementByIndex(i);
					return i;
				}
				crnt = crnt.Next;
			}
			return -1;
		}

		public int DeletAllNumbers(int value)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			int count = 0;
			int index = 0;
			for (int i = 0; i < Length; i++)
			{
				index = IndexByValue(value);
				if (index != -1)
				{
					RemoveOneElementByIndex(index);
					count++;
				}
			}
			return count;
		}

		public void AddListLast(ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is LinkedList))
			{
				throw new NullReferenceException();
			}
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			LinkedList list = (LinkedList)interfaceList;
			_tail = GetLinkNode(Length - 1);
			LinkedList tmpList = new LinkedList();
			tmpList = tmpList.CopyList(list);
			_tail.Next = tmpList._root;
			_tail = tmpList._tail;
		}

		public void AddListFirst(ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is LinkedList))
			{
				throw new NullReferenceException();
			}
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			LinkedList list = (LinkedList)interfaceList;
			LinkedList tmpList = new LinkedList();
			tmpList = tmpList.CopyList(list);
			tmpList._tail.Next = _root;
			_root = tmpList._root;
		}

		public void AddListByIndex(int index, ICollection interfaceList)
		{
			if (interfaceList == null || !(interfaceList is LinkedList))
			{
				throw new NullReferenceException();
			}
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new IndexOutOfRangeException("There is no such index in the list");
			}
			else
			{
				LinkedList list = (LinkedList)interfaceList;
				if (index == 0)
				{
					AddListFirst(list);
				}
				else
				{
					LinkedList tmpList = new LinkedList();
					tmpList = tmpList.CopyList(list);
					Node root = GetLinkNode(index - 1);
					Node tail = GetLinkNode(index);
					root.Next = tmpList._root;
					tmpList._tail.Next = tail;
				}
			}
		}

		public override string ToString()
		{
			string s = "[";
			Node crnt = _root;
			while (crnt != null)
			{
				s += $"{crnt.Value} ";
				crnt = crnt.Next;
			}
			s += "]";
			return s;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is LinkedList))
			{
				return false;
			}
				LinkedList list = (LinkedList)obj;
				if (list.Length != this.Length)
				{
					return false;
				}
				Node thisCrnt = _root;
				Node listCrnt = list._root;
				while (thisCrnt!=null)
				{
					if (thisCrnt.Value != listCrnt.Value)
					{
						return false;
					}
					thisCrnt = thisCrnt.Next;
					listCrnt = listCrnt.Next;
				}
			return true;
		}

		private Node GetLinkNode(int index)
		{
			Node crnt = _root;
			for (int i = 1; i <= index; i++)
			{
				crnt = crnt.Next;
			}
			return crnt;
		}

		private LinkedList CopyList(LinkedList list)
		{
			Node crnt = list._root;
			LinkedList tmpList = new LinkedList();
			for (int i = 0; i < list.Length; i++)
			{
				tmpList.AddValueLast(crnt.Value);
				crnt = crnt.Next;
			}
			return tmpList;
		}
	}
}
