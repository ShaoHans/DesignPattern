using System;

namespace _15.备忘录模式
{
    public class Originator
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; protected set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Atk { get; protected set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defensive { get; protected set; }

        public Originator(int vitality, int atk, int defensive)
        {
            Vitality = vitality;
            Atk = atk;
            Defensive = defensive;
        }

        /// <summary>
        /// 存档
        /// </summary>
        /// <returns></returns>
        public Memento SaveMemento()
        {
            return new Memento(Vitality, Atk, Defensive);
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(Memento memento)
        {
            Vitality = memento.Vitality;
            Atk = memento.Atk;
            Defensive = memento.Defensive;
        }

        /// <summary>
        /// 战斗
        /// </summary>
        public void Fight()
        {
            Vitality = new Random().Next(0, 101);
            Atk = new Random().Next(0, 101);
            Defensive = new Random().Next(0, 101);
        }

        public void Show()
        {
            Console.WriteLine($"当前生命力值：{Vitality}，攻击力值：{Atk}，防御力值：{Defensive}");
        }
    }
}
