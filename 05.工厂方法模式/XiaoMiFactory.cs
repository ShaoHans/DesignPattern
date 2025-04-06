namespace _05.工厂方法模式
{
    public class XiaoMiFactory : IMobileFactory
    {
        public Mobile Create()
        {
            return new XiaoMi();
        }
    }
}
