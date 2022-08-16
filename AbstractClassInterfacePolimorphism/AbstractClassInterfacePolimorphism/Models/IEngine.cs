using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfacePolimorphism.Models
{
    interface IEngine
    {
        public int HorsePower
        { get; set; }
        public float TankSize
        { get; set; }
        public float CurrentOil
        { get; set; }
        public string FuelType
        { get; set; }
        public float RemainOilAmount
        { get; set; }
    }
}
