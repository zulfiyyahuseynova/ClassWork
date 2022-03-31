using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Plane: Vehicle, IWheel, IEngine
    {
        public double WingLength { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public double WheelThikness { get; set; }
    }
}
