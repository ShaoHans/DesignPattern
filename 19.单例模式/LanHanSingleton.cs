namespace _19.单例模式
{
    /// <summary>
    /// 懒汉式单例类
    /// </summary>
    public sealed class LanHanSingleton
    {
        private static LanHanSingleton singleton;
        private static object sync = new object();

        private LanHanSingleton()
        {

        }

        public static LanHanSingleton GetInstance()
        {
            if (singleton == null)
            {
                lock (sync)
                {
                    if (singleton == null)
                    {
                        singleton = new LanHanSingleton();
                    }
                }
            }

            return singleton;
        }
    }
}
