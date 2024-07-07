using Estacionamento.Interfaces;
using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string plate)
        {
            return new Car(plate);
        }
    }
}