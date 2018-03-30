using System;

namespace _11.发布订阅模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SmsObserver smsObserver = new SmsObserver();
            EmailObserver emailObserver = new EmailObserver();
            ISubject subject = new PublishProjectSubject();
            subject.Update += new UpdateHandler(smsObserver.SendSms);
            subject.Update += emailObserver.SendEmail;
            subject.Nodify();
            Console.ReadKey();
        }
    }
}
