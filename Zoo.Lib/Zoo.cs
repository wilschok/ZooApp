using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    class Zoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;

        public Zoo(decimal entranceFee)
        {
            EntranceFee = entranceFee;
        }
    }
}
