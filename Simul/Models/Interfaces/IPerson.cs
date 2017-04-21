namespace Simul.Models
{
    public interface IPerson : IPlayer
    {
        bool alreadyTrained { get; set; }
        bool alreadyWorked { get; set; }
        bool canResign { get; set; }
        Company employer { get; set; }
        int Energy { get; set; }
        int jobStartDay { get; set; }
        decimal salary { get; set; }
        Skillset skillset { get; set; }
        float strength { get; set; }

        string DisplayProductivity();
        float GetCurrentUsedSkillLevel();
        void Resign(int currentDay);
        void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay);
        void Train();
        eWorkResult Work();
    }
}