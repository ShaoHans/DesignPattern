namespace _09.建造者模式
{
    public class Director
    {
        CarBuilder _builder;

        public Director(CarBuilder builder)
        {
            _builder = builder;
        }

        public void Create()
        {
            _builder.BuildCheKuangJia();
            _builder.BuildFaDongJi();
            _builder.BuildLunZi();
            _builder.BuildYiZi();
        }
    }
}
