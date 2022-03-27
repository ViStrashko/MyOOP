using System;

namespace MyLists
{
	public class LinkedList
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

		public void AddValueLast(int value)
		{
			if (_root == null)
			{
				_root = new Node(value);
				_tail = _root;
			}
			else
			{
				Node crnt = GetLinkNode(Length-1);
				_tail = crnt;
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

		public void AddValueByIndex(int index, int value)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index <  0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the list");
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

		public void RemoveOneElementLast(int number = 1)
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
				Node crnt = GetLinkNode(Length - 1 - number);
				crnt.Next = null;
			}
		}

		public void RemoveOneElementFirst(int number = 1)
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
				int count = 0;
				while(count++ < number)
				{
					Node crnt = _root.Next;
					_root = crnt;
				}
			}
		}

		public void RemoveOneElementByIndex(int index, int number = 1)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the list");
			}
			if (Length <= 1)
			{
				_root = null;
			}
			else if (index == 0)
			{
				RemoveOneElementFirst(number);
			}
			else
			{
				Node root = GetLinkNode(index - 1);
				Node tail = GetLinkNode(index + number);
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
			RemoveOneElementLast(numberOfElements);
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
			RemoveOneElementFirst(numberOfElements);
		}

		public void RemoveElementsByIndex(int index, int numberOfElements)
		{
			if (_root == null)
			{
				throw new Exception("The list is empty");
			}
			if (index < 0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the list");
			}
			if (numberOfElements < 0 || numberOfElements > Length)
			{
				throw new ArgumentException("The number of elements to be deleted must be positive and not exceed the value of the list");
			}
			if (numberOfElements > (Length - index))
			{
				throw new ArgumentException("Removing list elements from this index goes beyond the size of the list");
			}
			RemoveOneElementByIndex(index, numberOfElements);
		}

		public void Write()
		{
			for (int i = 0; i < Length; i++)
			{
				Node[] d = new Node[i];
				Console.Write($"{d} ");
			}
		}

		public override string ToString()
		{
			string s = "[ ";
			Node crnt = _root;
			while (crnt != null)
			{
				for (int i = 0; i < Length; i++)
				{
					s += $"{crnt.Value} ";
					crnt = crnt.Next;
				}
			}
			s += "]";
			return s;
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
	}
}
