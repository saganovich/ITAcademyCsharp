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
		private T[] array;
		public int Size => array.Length;
		
		public MyStack()
		{
			this.array = new T[0];
		}

		public void Push(T item)
		{
			Array.Resize(ref this.array, Size + 1);
			array[Size-1] = item;
		}
		public T Pop()
		{
			if (Size == 0) { throw new Exception("The stack is empty"); }
			T tempElem = this.array[Size-1];
			Array.Resize(ref this.array, Size - 1);
			return tempElem;
		}
		public T Peek()
		{
			if (Size == 0) { throw new Exception("The stack is empty"); }
			return this.array[Size-1];
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
