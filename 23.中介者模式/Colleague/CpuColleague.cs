using System;

namespace _23.中介者模式
{
    public class CpuColleague : Colleague
    {
        public CpuColleague(Mediator mediator) : base(mediator)
        {
        }

        public void Handle()
        {
            Console.WriteLine("开始处理...");
        }
    }
}
