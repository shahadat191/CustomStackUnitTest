using System;
using System.Collections.Generic;
using System.Text;


namespace MyStack
{
    public class MyStack<T> : IStack<T>
    {
        List<T> list;
        public int Count { get; set; }
        public MyStack()
        {
            list = new List<T>();
            Count = 0;
        }
        public void Push(T value)
        {
            list.Add(value);
            Count++;
        }
        public T Pop()
        {
            
            T topItem = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return topItem;
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new System.InvalidOperationException("Stack is empty");
            }
            return list[list.Count - 1];
        }
        public bool IsEmpty()
        {
            return list.Count == 0 ? true : false;
        }
        public void Clear()
        {
            list.Clear();
            Count = 0;
        }
    }
}