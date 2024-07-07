using Estacionamento.Interfaces;
using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string plate)
        {
            return new Motorcycle(plate);
        }
    }
}
