using System;

namespace _23.中介者模式
{
    public class HardDiskColleague : Colleague
    {
        public HardDiskColleague(Mediator mediator) : base(mediator)
        {
        }

        public void ProvideMovieData()
        {
            Console.WriteLine("我是电影文件");
        }
    }
}
