using System;
using System.Collections.Generic;
using System.Text;

namespace _13.状态模式
{
    public class WaterContext
    {
        private WaterState _waterState;

        public void ShowWaterState(int degree)
        {
            if (degree <= 0)
            {
                _waterState = new IceWaterState();
            }
            else if (degree > 0 && degree <= 100)
            {
                _waterState = new WarmWaterState();
            }
            else
            {
                _waterState = new AirWaterState();
            }
            _waterState.SetDegree(degree);
            _waterState.Show();
        }
    }
}
