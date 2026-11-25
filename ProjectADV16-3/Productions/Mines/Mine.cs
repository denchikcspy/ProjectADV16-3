using System;
using System.Collections.Generic;
using System.Text;
using ProjectADV16_3.Productions;

namespace ProjectADV16_3.Productions.Mines
{
    public abstract class Mine : Production
    {
        protected Mine(int id, string name, double efficiency = 100.0)
            : base(id, name, efficiency)
        {
        }
    }
}