namespace Simul.Models
{
    public interface IPerson : IPlayer
    {
        bool AlreadyTrained { get; set; }
        bool AlreadyWorked { get; set; }
        bool CanResign { get; set; }
        ICompany Employer { get; set; }
        int Energy { get; set; }
        int JobStartDay { get; set; }
        decimal Salary { get; set; }
        Skillset Skillset { get; set; }
        float Strength { get; set; }

        string DisplayProductivity();
        string DisplayCurrentEmployer();

        float GetCurrentUsedSkillLevel();
        void Resign(int currentDay);
        void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay);
        void Train();
        WorkResult Work();
        void Eat(Resource resource, int quantity);
        void EatUntilFull();
        bool CanWork();
        bool CanTrain();
    }
}