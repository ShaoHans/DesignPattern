namespace _09.建造者模式
{
    public class BenChiBuilder : CarBuilder
    {
        Car car;
        public BenChiBuilder()
        {
            car = new Car();
        }

        public override void BuildCheKuangJia()
        {
            car.CheKuangJia = "奔驰车框架";
        }

        public override void BuildFaDongJi()
        {
            car.FaDongJi = "奔驰车发动机";
        }

        public override void BuildLunZi()
        {
            car.LunZi = "奔驰车轮子";
        }

        public override void BuildYiZi()
        {
            car.YiZi = "奔驰车椅子";
        }

        public override Car GetResult()
        {
            return car;
        }
    }
}
