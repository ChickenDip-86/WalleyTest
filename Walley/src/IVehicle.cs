using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IVehicle
{
    public bool IsTollFree { get; } 
    String GetVehicleType();
}
