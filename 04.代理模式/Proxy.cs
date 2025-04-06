using System;

namespace _04.代理模式
{
    public class Proxy : Subject
    {
        private RealSubject _subject;
        public Proxy()
        {
            if (_subject == null)
            {
                _subject = new RealSubject();
            }
        }

        public override void DoSomething()
        {
            Console.WriteLine("我是代理哦");
            _subject.DoSomething();
            Console.WriteLine("代理完成");
        }
    }
}
