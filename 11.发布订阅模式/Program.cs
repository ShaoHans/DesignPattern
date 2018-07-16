using _11.发布订阅模式.EventBus;
using System;
using System.Threading;

namespace _11.发布订阅模式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SmsObserver smsObserver = new SmsObserver();
            EmailObserver emailObserver = new EmailObserver();
            ISubject subject = new PublishProjectSubject();
            subject.Update += new UpdateHandler(smsObserver.SendSms);
            subject.Update += emailObserver.SendEmail;
            subject.Nodify();
            */

            // 钓鱼
            // 1.初始化鱼竿
            FishingRod fishingRod = new FishingRod();
            // 2.声明垂钓者
            FishingMan jiangTaiGong = new FishingMan("姜太公");
            // 3.分配鱼竿
            jiangTaiGong.FishingRod = fishingRod;
            // 4.注册观察者
            //fishingRod.FishingEvent += new FishingEventHandler().HandleEvent();
            // 5.循环钓鱼
            while (jiangTaiGong.FishCount < 5)
            {
                jiangTaiGong.Fishing();
                Console.WriteLine("------------------------------");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

            Console.ReadKey();
        }
    }
}
