using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    abstract class Vehicle
    {
        private float _drivePath;                   // km
        private float _driveTime;                   // hour


        public float DriveTime
        {
            get { return _driveTime; }
            set { if(value>=0) _driveTime = value; }
        }

        public float DrivePath
        {
            get { return _drivePath; }
            set { if(value>=0) _drivePath = value; }
        }

        public abstract float AverageSpeed();
        

    }
}
