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
			if (index <  0 || index >= Length)
			{
				throw new ArgumentException("There is no such index in the list");
			}
			if (_root == null)
			{
				_root = new Node(value);
				_tail = _root;
			}
			else
			{
				if (index == 0)
				{
					AddValueFirst(value);
				}
				else
				{
					Node root = GetNode(index-1);
					Node tail = GetNode(index);
					Node crnt = new Node(value);
					root.Next = crnt;
					crnt.Next = tail;
				}
			}
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

		private Node GetNode(int index)
		{
			Node crnt = _root;
			for (int i = 1; i <= index; i++)
			{
				Node[] d = new Node[i];
				crnt = crnt.Next;
			}
			return crnt;
		}
	}
}
