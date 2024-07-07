using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string plate);
    }
}

