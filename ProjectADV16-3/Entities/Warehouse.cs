using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectADV16_3.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public Dictionary<ResourceType, double> ResourceList { get; set; }

        public Warehouse(int id)
        {
            Id = id;
            ResourceList = new Dictionary<ResourceType, double>();
        }

        public bool HasResource(ResourceType resourceType, double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            return ResourceList.ContainsKey(resourceType) && ResourceList[resourceType] >= amount;
        }

        public double GetResourceAmount(ResourceType resourceType)
        {
            if (ResourceList.ContainsKey(resourceType))
            {
                return ResourceList[resourceType];
            }

            return 0;
        }

        public bool AddResource(ResourceType resourceType, double amount)
        {
            if (resourceType == ResourceType.Electricity || amount <= 0)
            {
                return false;
            }

            if (ResourceList.ContainsKey(resourceType))
            {
                ResourceList[resourceType] += amount;
            }
            else
            {
                ResourceList[resourceType] = amount;
            }

            return true;
        }

        public bool TakeResource(ResourceType resourceType, double amount)
        {
            if (!HasResource(resourceType, amount))
            {
                return false;
            }

            ResourceList[resourceType] -= amount;
            return true;
        }
    }
}