using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        abstract public double AverageSpeed();
        abstract public void ShowInfo();
     
    }
}
