using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : IVehicle
{
    public bool IsTollFree { get; } = false;
    public string GetVehicleType() => "Car";
}
