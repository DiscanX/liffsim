using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    interface IDecorator
    {
        List<Tuple<int, string>> actionHistory { get; set; }
    }

}
