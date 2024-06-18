using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_challenge_hosting.Models;

public class Guest
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string CompleteName => $"{FirstName} {SecondName}".ToUpper();

    public Guest()
    {
        FirstName = "";
        SecondName = "";
    }

    public Guest(string firstName) 
    {
        FirstName = firstName;
        SecondName = "";
    }

    public Guest(string firstName, string secondName)
    {
        FirstName = firstName;
        SecondName = secondName;
    }
}