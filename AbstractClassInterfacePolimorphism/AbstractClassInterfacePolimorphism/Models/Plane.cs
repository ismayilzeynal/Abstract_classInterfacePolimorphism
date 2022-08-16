using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    class Plane
    {
        private float _wingLength;

        public float WingLength
        {
            get { return _wingLength; }
            set 
            { 
                if(value>0)
                _wingLength = value; 
            }
        }

    }
}
