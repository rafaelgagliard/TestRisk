// See https://aka.ms/new-console-template for more information
using Risk.Core;
using Risk.Mappers;
using Risk.Models;

Console.WriteLine("Insira a data de referência");
var referenceDate = Console.ReadLine();

Request request = new() { ReferenceDate = referenceDate.ConvertToDateTime() };

Console.WriteLine("Insira a quantidade de operações");
var qtdOperations = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= qtdOperations; i++)
{
    Console.WriteLine($"Insira as informações da {i}ª operação");
    var operations = Console.ReadLine();
    request.Trades.Add(operations.ConvertToTrade());
}

foreach (var trade in request.Trades)
    Console.WriteLine(trade.Categorize(request.ReferenceDate));

Console.ReadKey();

