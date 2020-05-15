using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Type_of_Train
    {
        Cargo,
        Passenger,
        high_speed
    }
    public class Train : transport
    {
        int number_of_cars { get; set; }
        Type_of_Train type_of_train { get; set; }
    }
}
