﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiEditorDotNetCore3.Models
{
    public class StackEx<T>
    {
        public int Count
        {
            get { return items.Count; }
        }

        public T First
        {
            get { return items[0]; }
        }

        private List<T> items = new List<T>();

        public void Clear()
        {
            items.Clear();
        }

        public T Peek()
        {
            return items[items.Count - 1];
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count > 0)
            {
                T temp = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return temp;
            }
            else
                return default;
        }

        public void PushToBottom(T item)
        {
            items.Insert(0, item);
        }

        public void Remove(int itemAtPosition)
        {
            items.RemoveAt(itemAtPosition);
        }
    }
}