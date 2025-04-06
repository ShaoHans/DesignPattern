namespace _05.工厂方法模式
{
    public class NokiaFactory : IMobileFactory
    {
        public Mobile Create()
        {
            return new Nokia();
        }
    }
}
