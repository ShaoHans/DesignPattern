using System;

namespace _21.命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Command sendEmail = new SendEmailCommand(new EmailReceiver());
            Invoker invoker = new Invoker();
            invoker.SetCommand(sendEmail);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
