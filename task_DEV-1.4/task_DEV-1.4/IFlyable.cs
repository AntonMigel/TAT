﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_1._4
{
    interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        float GetFlyTime(Coordinate newPoint);
    }
}
