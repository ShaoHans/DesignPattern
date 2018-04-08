using System;
using System.Collections.Generic;
using System.Text;

namespace _18.迭代器模式
{
    public class ConcreteAggregate : Aggregate
    {
        private List<object> _items = new List<object>();

        public int Count { get { return _items.Count; } }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public override Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
