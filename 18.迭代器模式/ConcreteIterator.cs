using System;
using System.Collections.Generic;
using System.Text;

namespace _18.迭代器模式
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _currentIndex = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object Current()
        {
            return _aggregate[_currentIndex];
        }

        public override object First()
        {
            if (_aggregate.Count <= 0)
            {
                return null;
            }
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _currentIndex >= _aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object obj = null;
            _currentIndex++;
            if (_currentIndex < _aggregate.Count)
            {
                obj = _aggregate[_currentIndex];
            }
            return obj;
        }
    }
}
