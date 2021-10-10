using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableExample
{
   class MyMapNode<k,v>
    {
        private int size;
        private LinkedList<keyValue<k, v>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<k, v>>[size];

        }
        public int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);

        }
        public v Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<k, v>> linkedlist = GetLinkedList(position);
            foreach (keyValue<k, v> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }

            }
            return default(v);
        }

        public LinkedList<keyValue<k, v>> GetLinkedList(int position)
        {
            LinkedList<keyValue<k, v>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<keyValue<k, v>>();

                items[position] = linkedlist;
            }
            return linkedlist;
        }
        public void Add(k key, v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<k, v>> linkedlist = GetLinkedList(position);
            keyValue<k, v> item = new keyValue<k, v>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }

        public struct keyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
    }
}
