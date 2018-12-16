using System.Collections.Generic;

namespace Simul.Models
{
    public interface ICompany : IPlayer
    {
        List<IPerson> Employees { get; set; }
        Resource ProducedResource { get; set; }
        float Progress { get; set; }

        eWorkResult Produce(IPerson employee, decimal salary);
    }
}