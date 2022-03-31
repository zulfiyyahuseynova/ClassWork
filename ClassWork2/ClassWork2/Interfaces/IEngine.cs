using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Interfaces
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public void LeftFuelAmount()
        {

        }
    }
}
