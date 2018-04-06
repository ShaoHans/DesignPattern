using System;
using System.Collections.Generic;
using System.Text;

namespace _15.备忘录模式
{
    public class Memento
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

        public Memento(int vitality, int atk, int defensive)
        {
            Vitality = vitality;
            Atk = atk;
            Defensive = defensive;
        }
    }
}
