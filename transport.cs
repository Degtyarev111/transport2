using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;
using static System.Console;


namespace ConsoleApp1
{
    public class transport
    {
        int capacity { get; set; }
        int carrying_capacity { get; set; }
        int speed { get; set; }
        string CanCare(container a)
        {
            if (carrying_capacity > a.weight)
            {
                return("Может выдержать");
            }else{
                return ("Не может выдержать");
            }
        }

    }
}
