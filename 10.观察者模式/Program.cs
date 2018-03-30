using System;

namespace _10.观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver emailObserver = new EmailObserver();
            IObserver smsObserver = new SmsObserver();
            ISubject subject = new PublishProjectSubject();
            subject.Add(emailObserver);
            subject.Add(smsObserver);
            subject.Nodify();

            Console.ReadKey();
        }
    }
}
