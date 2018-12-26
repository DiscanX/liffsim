using System.Collections.Generic;

namespace Simul.Models
{
    interface IDecorator
    {
        List<(int day, string description)> ActionHistory { get; set; }
    }

}
