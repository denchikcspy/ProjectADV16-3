using System;
using System.Collections.Generic;
using System.Text;
using ProjectADV16_3.Productions;

namespace ProjectADV16_3.Entities
{
    public class Concern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Production> ProductionList { get; set; }
        public Warehouse Warehouse { get; set; }
        public double AvailableElectricity { get; set; }

        public Concern(int id, string name, Warehouse warehouse)
        {
            Id = id;
            Name = name;
            ProductionList = new List<Production>();
            Warehouse = warehouse;
            AvailableElectricity = 0;
        }
    }
}