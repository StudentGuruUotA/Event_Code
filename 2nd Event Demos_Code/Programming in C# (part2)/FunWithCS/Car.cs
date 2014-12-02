using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    public class Car
    {
        public int Speed { get; set; }
        public void Accelerate()
        {
            Speed += 10;
            if (Speed > 120)
            {
                if (CarSpeedLimitReached != null)
                {
                    CarSpeedLimitReached("IOU IOU");
                }
            }
        }

        public event
            CarSpeedLimitReachedHandler
            CarSpeedLimitReached;
    }

    public delegate void
        CarSpeedLimitReachedHandler(string msg);
}
