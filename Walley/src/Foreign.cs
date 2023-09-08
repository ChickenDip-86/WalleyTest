using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Foreign : IVehicle
{
    public bool IsTollFree { get; } = true;
    public string GetVehicleType() => "Foreign";
}
