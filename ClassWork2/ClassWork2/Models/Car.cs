using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Car : Vehicle, IWheel, ITransmission, IEngine
    {
        private int _doorCount;
        public int DoorCount { get { return _doorCount; } set { if (value > 0 || value <= 5) _doorCount = value; } }

        private string _vinCode;
        public string VinCode
        {
            get { return _vinCode; }
            set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _vinCode = value; }
        }

        private int _horsePower;
        public int HorsePower { get { return _horsePower; } set { if (value > 0) _horsePower = value; } }

        private double _tankSize;
        public double TankSize { get { return _tankSize; } set { if (value > 0 || value < 65) _tankSize = value; } }

        private double _currentOil;
        public double CurrentOil { get { return _currentOil; } set { if (value > 0 || value <= TankSize) _currentOil = value; } }

        private string _fuelType;
        public string FuelType
        {
            get { return _fuelType; }
            set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; }
        }
        public bool TransmissionKind { get; set; }

        private double _wheelThickness;
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }

        private double _driveTime;
        public double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }

        private double _drivePath;
        public double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }

        public Car(int doorCount, string vinCode, bool transmissionKind, double wheelThickness, int horsePower, double tankSize, double currentOil, string fuelType, double driveTime, double drivePath)
        {
            DoorCount = doorCount;
            VinCode = vinCode;
            TransmissionKind = transmissionKind;
            WheelThickness = wheelThickness;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }
    }
}
