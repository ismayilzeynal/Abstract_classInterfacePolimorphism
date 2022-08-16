using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    class Square : Figure
    {
        //ctor
        public Square(float side)
        {
            Side = side;
        }



        //prop

        private float _side;

        public float Side
        {
            get { return _side; }
            set 
            {
                if(value>=0)
                _side = value; 
            }
        }


        
        //implement
        public override float CalcArea()
        {
            return Side*Side;
        }

    }
}
