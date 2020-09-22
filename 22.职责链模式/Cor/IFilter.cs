using System;
using System.Collections.Generic;
using System.Text;

namespace _22.职责链模式.Cor
{
    public interface IFilter
    {
        void DoFileter(Request request, Response response, FilterChain chain);
    }

    public class ActionExecutingFilter : IFilter
    {
        public void DoFileter(Request request, Response response, FilterChain chain)
        {
            request.Header += "→ActionExecutingFilter";
            chain.DoFilter(request, response);
            response.Data += "→ActionExecutingFilter";
        }
    }

    public class ActionExecutedFilter : IFilter
    {
        public void DoFileter(Request request, Response response, FilterChain chain)
        {
            request.Header += "→ActionExecutedFilter";
            chain.DoFilter(request, response);
            response.Data += "→ActionExecutedFilter";
        }
    }

    public class ExceptionFilter : IFilter
    {
        public void DoFileter(Request request, Response response, FilterChain chain)
        {
            request.Header += "→ExceptionFilter";
            chain.DoFilter(request, response);
            response.Data += "→ExceptionFilter";
        }
    }
}
