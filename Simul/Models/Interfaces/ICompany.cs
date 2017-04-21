namespace Simul.Models
{
    public interface ICompany : IPlayer
    {
        eWorkResult Produce(Person employee, decimal salary);
    }
}