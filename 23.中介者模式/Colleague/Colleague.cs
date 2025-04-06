namespace _23.中介者模式
{
    /// <summary>
    /// 同事抽象类
    /// </summary>
    public abstract class Colleague
    {
        public Mediator Mediator { get; protected set; }

        public Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}
