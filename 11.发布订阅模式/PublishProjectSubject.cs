using System;
using System.Collections.Generic;
using System.Text;

namespace _11.发布订阅模式
{
    public delegate void UpdateHandler();

    public class PublishProjectSubject : ISubject
    {
        // 解耦观察者

        public event UpdateHandler Update;

        public void Nodify()
        {
            Update?.Invoke();
        }
    }
}
