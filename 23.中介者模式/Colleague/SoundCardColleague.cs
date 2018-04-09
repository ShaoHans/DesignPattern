using System;
using System.Collections.Generic;
using System.Text;

namespace _23.中介者模式
{
    public class SoundCardColleague : Colleague
    {
        public SoundCardColleague(Mediator mediator) : base(mediator)
        {
        }

        public void Show()
        {
            Console.WriteLine("开始播放声音");
        }
    }
}
