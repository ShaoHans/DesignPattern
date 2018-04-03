using System;
using System.Collections.Generic;
using System.Text;

namespace _13.状态模式
{
    public abstract class WaterState
    {
        public int Degree { get; protected set; }

        public void SetDegree(int degree)
        {
            Degree = degree;
        }

        public abstract void Show();
    }
}
