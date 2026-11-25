using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectADV16_3.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ResourceType Type { get; set; }

        public Resource(int id, string name, decimal price, ResourceType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}