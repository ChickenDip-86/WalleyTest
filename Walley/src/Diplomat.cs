﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator;

namespace Walley.src
{
    public class Diplomat : IVehicle
    {
        public string GetVehicleType()
        {
            return "Diplomat";
        }
    }
}
