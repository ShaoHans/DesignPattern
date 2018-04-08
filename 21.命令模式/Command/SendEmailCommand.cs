using System;
using System.Collections.Generic;
using System.Text;

namespace _21.命令模式
{
    public class SendEmailCommand : Command
    {
        private EmailReceiver receiver;

        public SendEmailCommand(EmailReceiver receiver)
        {
            this.receiver = receiver;
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
