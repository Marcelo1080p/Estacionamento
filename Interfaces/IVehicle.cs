using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Interfaces
{
    public interface IVehicle
    {
        string Plate { get; }
        string VehicleType { get; }
        decimal CalculeRate(int hours);
    }
}
