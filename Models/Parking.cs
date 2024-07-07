using System;
using System.Collections.Generic;
using System.Linq;
using Estacionamento.Interfaces;
using Estacionamento.Services;

namespace Estacionamento.Models
{
    public class Parking
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        private Dictionary<string, IVehicleFactory> vehicleFactories = new Dictionary<string, IVehicleFactory>
        {
            { "1", new MotorcycleFactory() },
            { "2", new CarFactory() }
        };

        public void AddVehicle()
        {
            Console.WriteLine("Deseja cadastrar carro ou moto?\n" +
                              "[ 1 ] Moto\n" +
                              "[ 2 ] Carro");

            string typeVehicle = Console.ReadLine();

            if (vehicleFactories.ContainsKey(typeVehicle))
            {
                Console.WriteLine("Informe a Placa do Veículo: ");
                string plate = Console.ReadLine();

                IVehicleFactory factory = vehicleFactories[typeVehicle];
                IVehicle vehicle = factory.CreateVehicle(plate);
                vehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        public void RemoveVehicle()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("Ainda não tem veículos estacionados.");
                return;
            }

            Console.WriteLine("Digite a placa do veículo para remover: ");
            string infoPlate = Console.ReadLine();

            Console.WriteLine("Digite quantas horas o veículo ficou estacionado: ");
            if (!int.TryParse(Console.ReadLine(), out int hours))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido de horas.");
                return;
            }

            IVehicle vehicleToRemove = vehicles.FirstOrDefault(x => x.Plate == infoPlate);
            if (vehicleToRemove == null)
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }

            decimal fee = vehicleToRemove.CalculeRate(hours);
            vehicles.Remove(vehicleToRemove);
            Console.WriteLine($"Veículo com placa {infoPlate} removido com sucesso.");
            Console.WriteLine($"A taxa de estacionamento para {hours} horas é: {fee:C}");
        }


        public void ShowVehicles()
        {
            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"Tipo de veículo: {vehicle.VehicleType}, Placa: {vehicle.Plate}");
                }
            }
            else
            {
                Console.WriteLine("Ainda não tem veículos cadastrados");
            }
        }
    }
}
