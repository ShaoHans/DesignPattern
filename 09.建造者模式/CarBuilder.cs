namespace _09.建造者模式
{
    public abstract class CarBuilder
    {
        public abstract void BuildLunZi();

        public abstract void BuildYiZi();

        public abstract void BuildCheKuangJia();

        public abstract void BuildFaDongJi();

        public abstract Car GetResult();
    }
}
