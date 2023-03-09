using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
	sealed class MyStack <T>
	{
		private int top;
		private int size;
		private T[] array;
		public int Size
		{
			get
			{
				return array.Length;
			}
			private set
			{
				size = value;
			}
		}
		
		public MyStack()
		{
			this.size = 0;
			this.array = new T[size];
		}

		public void Push(T item)
		{
			Resize(TypeResize.Up);
			array[Size-1] = item;
		}
		public T Pop()
		{
			if (Size == 0) { throw new Exception("The stack is empty"); }
			T tempElem = this.array[Size-1];
			Resize(TypeResize.Down);
			return tempElem;
		}
		public T Peek()
		{
			if (Size == 0) { throw new Exception("The stack is empty"); }
			return this.array[Size-1];
		}
		private void Resize(TypeResize type)
		{
			switch (type)
			{
				case TypeResize.Up:
					Array.Resize(ref this.array, Size+1);
					break;
				case TypeResize.Down:
					Array.Resize(ref this.array, Size-1);
					break;
			}
			
		}
		public override string ToString()
		{
			StringBuilder tempstr = new StringBuilder();
			tempstr.Append("[");
			foreach(T item in this.array)
			{
				tempstr.Append("\"");
				tempstr.Append(item.ToString());
				tempstr.Append("\",");
			}
			if(this.array.Length > 0)tempstr.Remove(tempstr.Length-1,1);
			tempstr.Append("]");
			return tempstr.ToString();
		}
	}
}
