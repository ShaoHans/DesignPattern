using System;
using System.Collections.Generic;
using System.Text;

namespace _23.中介者模式
{
    public class GraphicsCardColleague : Colleague
    {
        public GraphicsCardColleague(Mediator mediator) : base(mediator)
        {
        }

        public void Play()
        {
            Console.WriteLine("开始播放视频");
        }
    }
}
