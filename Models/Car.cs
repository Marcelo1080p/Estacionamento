using Estacionamento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models;

public class Car : IVehicle
{
    public Car(string  plate)
    {
        Plate = plate;
    }
    public String? Plate { get; set; }
    public string VehicleType => "Car";
    public decimal rate = 3.0m;
    public decimal Rate { get { return rate; } set { rate = value; } }

    public decimal CalculeRate(int hours)
    {
        return Rate * hours;
    }
}
