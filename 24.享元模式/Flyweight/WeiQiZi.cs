using System.Drawing;

namespace _24.享元模式
{
    /// <summary>
    /// 围棋子
    /// </summary>
    public abstract class WeiQiZi
    {
        public string Color { get; protected set; }

        public abstract void Display(Point point);
    }
}
