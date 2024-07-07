using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Interfaces;
namespace Estacionamento.Models;

public class Motorcycle: IVehicle
{
    public Motorcycle(string plate) => Plate = plate;
    public string Plate { get; set; }
    public string? VehicleType => "Motorcycle";
    public decimal rate = 2.0m;
    public decimal Rate { get { return rate; } set { rate = value; } }

    public  decimal CalculeRate(int hours)
    {
        return Rate * hours;
    }

}
