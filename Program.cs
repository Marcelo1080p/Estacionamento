using Estacionamento.Models;
using System;

bool ShowMenu = true;

Parking parking = new Parking();

while (ShowMenu)
{
    Console.WriteLine(
        "Informe a opçaõ desejada:\n" +
        "[ 1 ] Ver veiculos estácionados\n" +
        "[ 2 ] Remover veiculo\n" +
        "[ 3 ] Adicionar veiculo\n"
    );
    

    switch (Console.ReadLine())
    {
        case "1":
            parking.ShowVehicles(); 
            break;
        case "2":
            parking.RemoveVehicle();
            break;
        case "3":
            parking.AddVehicle();
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}