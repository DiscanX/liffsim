namespace Simul.Models
{
    public class JobOffer
    {
        public ICompany Employer { get; set; }
        public decimal Salary { get; set; }

        public JobOffer(ICompany employer, decimal salary)
        {
            Employer = employer;
            Salary = salary;
        }
    }
}
