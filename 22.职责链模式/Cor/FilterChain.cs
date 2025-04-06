using System.Collections.Generic;

namespace _22.职责链模式.Cor
{
    public class FilterChain
    {
        private int _index = 0;
        private List<IFilter> _filters = new List<IFilter>();

        public FilterChain Add(IFilter filter)
        {
            _filters.Add(filter);
            return this;
        }

        public void DoFilter(Request request, Response response)
        {
            if (_filters.Count <= _index)
            {
                return;
            }

            var filter = _filters[_index];
            _index++;
            filter.DoFileter(request, response, this);
        }
    }
}
