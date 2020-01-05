using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        bool IsEmpty();
        void Clear();
    }
}
