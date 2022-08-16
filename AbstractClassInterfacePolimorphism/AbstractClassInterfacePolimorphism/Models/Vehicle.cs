using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    abstract class Vehicle
    {
        public abstract float DriveTime();          // hour
        public abstract float DrivePath();          // km
        public abstract float AverageSpeed();       // km/h

    }
}
