using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectADV16_3.Productions
{
    public class PowerPlant : Production
    {
        public PowerPlant(int id, string name, double efficiency = 100.0)
            : base(id, name, efficiency)
        {
        }

        public override void Produce()
        {
            
        }
    }
}