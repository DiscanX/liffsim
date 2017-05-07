using System.Collections.Generic;

namespace Simul.Models
{
    public interface ICompany : IPlayer
    {
        List<IPerson> employees { get; set; }
        Resource producedResource { get; set; }
        float progress { get; set; }

        eWorkResult Produce(IPerson employee, decimal salary);
    }
}