using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    class Car : Vehicle
    {
        private int _doorCount;

        public int DoorCount
        {
            get { return  _doorCount; }
            set 
            {  
                if(value>0)
                    _doorCount = value; 
            }
        }

        private string _winCode;

        public string WinCode
        {
            get { return _winCode; }
            set { _winCode = value; }
        }

        public override float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
