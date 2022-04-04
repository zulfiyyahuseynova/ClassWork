using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Plane : Vehicle, IWheel, IEngine
    {
        private double _wingLength;
        public double WingLength { get { return _wingLength; } set { if (value > 0 || value <= 117) _wingLength = value; } }

        private int _horsePower;
        public int HorsePower { get { return _horsePower; } set { if (value > 0) _horsePower = value; } }

        private double _tankSize;
        public double TankSize { get { return _tankSize; } set { if (value > 0 || value <= 100000) _tankSize = value; } }

        private double _currentOil;
        public double CurrentOil { get { return _currentOil; } set { if (value > 0 || value <= TankSize) _currentOil = value; } }

        private string _fuelType;
        public string FuelType
        {
            get { return _fuelType; }
            set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; }
        }

        private double _wheelThickness;
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }

        private double _driveTime;
        public double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }

        private double _drivePath;
        public double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }

        public Plane(int wingLength, int horsePower, double tankSize, double currentOil, string fuelType, double wheelThickness, double driveTime, double drivePath)
        {
            WingLength = wingLength;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            WheelThickness = wheelThickness;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
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
