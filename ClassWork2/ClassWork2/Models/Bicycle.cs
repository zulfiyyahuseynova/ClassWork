using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Bicycle : Vehicle, IWheel
    {
        private string _pedalKind;
        public string PedalKind
        {
            get { return _pedalKind; }
            set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _pedalKind = value; }
        }
        private double _wheelThickness;
        public double WheelThickness
        {
            get { return _wheelThickness; }
            set { if (value > 0) _wheelThickness = value; }
        }
        private double _driveTime;
        public double DriveTime
        {
            get { return _driveTime; }
            set { if (value > 0) _driveTime = value; }
        }
        private double _drivePath;
        public double DrivePath
        {
            get { return _drivePath; }
            set { if (value > 0) _drivePath = value; }
        }


        public Bicycle(string pedalKind, double wheelThickness, double driveTime, double drivePath)
        {
            PedalKind = pedalKind;
            WheelThickness = wheelThickness;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public override void ShowInfo()
        {
            foreach (var item in this.GetType().GetProperties())
            {
                Console.WriteLine(item.Name + ":" + item.GetValue(this));
            }
        }
    }
}

