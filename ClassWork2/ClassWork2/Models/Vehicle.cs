using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public void AverageSpeed(double drivePath, double driveTime)
        {
            DrivePath = drivePath;
            DriveTime = driveTime;
            Console.WriteLine($"Sureti: {DrivePath / DriveTime}");
        }
        public void ShowInfo()
        {

        }
    }
}
