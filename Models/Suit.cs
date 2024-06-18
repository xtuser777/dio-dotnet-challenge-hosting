using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_challenge_hosting.Models;

public class Suit
{
    public string Type { get; set; }
    public int Capacity { get; set; }
    public decimal AmountPerDay { get; set; }

    public Suit()
    {
        Type = "";
        Capacity = 0;
        AmountPerDay = 0;
    }   

    public Suit(string type, int capacity, decimal amountPerDay)
    {
        Type = type;
        Capacity = capacity;
        AmountPerDay = amountPerDay;
    }
}