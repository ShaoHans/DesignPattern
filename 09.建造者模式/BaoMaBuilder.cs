using System;
using System.Collections.Generic;
using System.Text;

namespace _09.建造者模式
{
    public class BaoMaBuilder: CarBuilder
    {
        Car car;
        public BaoMaBuilder()
        {
            car = new Car();
        }

        public override void BuildCheKuangJia()
        {
            car.CheKuangJia = "宝马车框架";
        }

        public override void BuildFaDongJi()
        {
            car.FaDongJi = "宝马车发动机";
        }

        public override void BuildLunZi()
        {
            car.LunZi = "宝马车轮子";
        }

        public override void BuildYiZi()
        {
            car.YiZi = "宝马车椅子";
        }

        public override Car GetResult()
        {
            return car;
        }
    }
}
