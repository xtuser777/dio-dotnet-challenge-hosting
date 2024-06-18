using System.Text;
using dio_dotnet_challenge_hosting.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Guest> hospedes = new();

Guest p1 = new(firstName: "Hóspede 1");
Guest p2 = new(firstName: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suit suit = new(type: "Premium", capacity: 2, amountPerDay: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserve reserve = new Reserve(reservedDays: 10);
reserve.RegisterSuit(suit);
reserve.RegisterGuests(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserve.GetGuestsQuantity()}");
Console.WriteLine($"Valor diária: {reserve.AmountPerDayCalculate()}");