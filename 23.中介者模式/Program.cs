using System;

namespace _23.中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MainBoardMediator mediator = new MainBoardMediator();
            HardDiskColleague hardDisk = new HardDiskColleague(mediator);
            CpuColleague cpu = new CpuColleague(mediator);
            SoundCardColleague soundCard = new SoundCardColleague(mediator);
            GraphicsCardColleague graphicsCard = new GraphicsCardColleague(mediator);

            mediator.HardDisk = hardDisk;
            mediator.Cpu = cpu;
            mediator.SoundCard = soundCard;
            mediator.GraphicsCard = graphicsCard;
            mediator.Change(hardDisk);
            Console.ReadKey();
        }
    }
}
