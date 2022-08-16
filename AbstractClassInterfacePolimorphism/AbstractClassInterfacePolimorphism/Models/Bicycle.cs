using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    class Bicycle : Vehicle
    {
        private string _pedalKind;

        public string PedalKind
        {
            get { return _pedalKind; }
            set { _pedalKind = value; }
        }

        public override float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
