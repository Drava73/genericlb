using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericlb
{
    class Program
    {
        #region 1
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
        #endregion
        #region 2
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }
        #endregion
        #region 3
        public static T Sum<T>(T[] array) where T : struct, IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                return default(T);
            }
            T sum = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                sum = (dynamic)sum + array[i];
            }
            return sum;
        }
        #endregion
        #region 4
        public class Stack<T>
        {
            private List<T> items;

            public Stack()
            {
                items = new List<T>();
            }

            public int Count
            {
                get { return items.Count; }
            }

            public T Peek()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("The stack is empty.");
                }
                return items[items.Count - 1];
            }

            public void Push(T item)
            {
                items.Add(item);
            }

            public T Pop()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("The stack is empty.");
                }
                T item = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return item;
            }
        }
        #endregion
        #region
        public class Queue<T>
        {
            private List<T> items;

            public Queue()
            {
                items = new List<T>();
            }

            public int Count
            {
                get { return items.Count; }
            }

            public T Peek()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }
                return items[0];
            }

            public void Enqueue(T item)
            {
                items.Add(item);
            }

            public T Dequeue()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }
                T item = items[0];
                items.RemoveAt(0);
                return item;
            }
        }
        #endregion 5
    }
}
