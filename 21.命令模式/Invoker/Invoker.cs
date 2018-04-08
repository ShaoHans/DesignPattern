using System;
using System.Collections.Generic;
using System.Text;

namespace _21.命令模式
{
    /// <summary>
    /// 命令传送者
    /// </summary>
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}
