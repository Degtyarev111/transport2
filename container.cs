using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{
    public class container
    {
        public int size { get; set; }
        public int weight { get; set; }
        public container(int size, int weight)
        {
            this.size = size;
            this.weight = weight;
        }
    }
}
