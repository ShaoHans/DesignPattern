namespace _09.建造者模式
{
    public class Car
    {
        /// <summary>
        /// 轮子
        /// </summary>
        public string LunZi { get; set; }

        /// <summary>
        /// 发动机
        /// </summary>
        public string FaDongJi { get; set; }

        /// <summary>
        /// 车框架
        /// </summary>
        public string CheKuangJia { get; set; }

        /// <summary>
        /// 椅子
        /// </summary>
        public string YiZi { get; set; }

        public override string ToString()
        {
            return $"{YiZi},{LunZi},{FaDongJi},{CheKuangJia}";
        }
    }
}
