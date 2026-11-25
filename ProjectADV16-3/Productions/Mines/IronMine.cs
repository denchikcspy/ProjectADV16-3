using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectADV16_3.Productions.Mines
{
    public class IronMine : Mine
    {
        public IronMine(int id, string name, double efficiency = 100.0)
            : base(id, name, efficiency)
        {
        }

        public override void Produce()
        {
            
        }
    }
}