using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Diplomat : IVehicle
{
    public bool IsTollFree { get; } = true;
    public string GetVehicleType() => "Diplomat";
}
