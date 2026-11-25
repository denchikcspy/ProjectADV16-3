using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectADV16_3.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<ResourceType, double> RequiredResourcesList { get; set; }
        public Dictionary<ResourceType, double> ReceivedResourcesList { get; set; }
        public int Duration { get; set; }

        public Recipe(int id, string name, int duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
            RequiredResourcesList = new Dictionary<ResourceType, double>();
            ReceivedResourcesList = new Dictionary<ResourceType, double>();
        }
    }
}