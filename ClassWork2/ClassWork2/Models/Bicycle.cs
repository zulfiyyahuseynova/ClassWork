using ClassWork2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2.Models
{
    class Bicycle : Vehicle, IWheel
    {
        public string PedalKind { get; set; }
        public double WheelThikness { get; set; }
    }
}
