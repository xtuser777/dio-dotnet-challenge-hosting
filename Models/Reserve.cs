using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_challenge_hosting.Models;

public class Reserve
{
    public List<Guest> Guests { get; set; }
    public Suit Suit { get; set; }
    public int ReservedDays { get; set; }

    public Reserve()
    {
        Guests = new List<Guest>();
        Suit = new Suit();
        ReservedDays = 0;
    }

    public Reserve(int reservedDays)
    {
        Guests = new List<Guest>();
        Suit = new Suit();
        ReservedDays = reservedDays;    
    }

    public void RegisterGuests(List<Guest> hospedes)
    {
        if (hospedes.Count <= Suit.Capacity)
        {
            Guests = hospedes;
        }
        else
        {
            throw new ArgumentException("Quantidade de hospedes excede o limite da suite.");
        }
    }

    public void RegisterSuit(Suit suit)
    {
        Suit = suit;
    }

    public int GetGuestsQuantity()
    {
        return Guests.Count;
    }

    public decimal AmountPerDayCalculate()
    {
        decimal valor = ReservedDays * Suit.AmountPerDay;

        if (ReservedDays >= 10)
        {
            valor -= valor * 0.1M;
        }

        return valor;
    }
}