using System;
using System.Collections.Generic;

namespace Simul.Models
{
    interface IDecorator
    {
        List<Tuple<int, string>> ActionHistory { get; set; }
    }

}
