﻿namespace _14.适配器模式
{
    public class LoggerAdapter : LoggerTarget
    {
        private NLogAdaptee nlogger = new NLogAdaptee();

        public override void Info()
        {
            nlogger.WriteInfoLog();
        }
    }
}
