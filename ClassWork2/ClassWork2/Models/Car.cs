using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Car : Vehicle, IWheel, ITransmission, IEngine
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public bool TransmissionKind { get; set; }
        public double WheelThikness { get; set; }
    }
}
