using System;
using System.Linq;

namespace Simul.Models
{
    public enum WorkResult
    {
        Success,
        FailureStocksTooLow,
        FailureNotEnoughMoney
    }

    public class Person : Player, IPerson
    {
        public decimal Strength { get; set; }
        public ICompany Employer { get; set; }
        public decimal Salary { get; set; }
        public Skillset Skillset { get; set; }
        public bool AlreadyWorked { get; set; }
        public bool AlreadyTrained { get; set; }
        public bool CanResign { get; set; }
        public int JobStartDay { get; set; }

        private int _energy;

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value < Constants.MIN_ENERGY) { throw new Exception("Energy can't go below zero"); }
                _energy = value > Constants.MAX_ENERGY ? Constants.MAX_ENERGY : value;
            }
        }

        public Person(string name,
            Country country,
            decimal money,
            Skillset skillset,
            Inventory inventory,
            int energy,
            decimal strength,
            bool isHumanControlled = false) : base(name, country, money, inventory, isHumanControlled)
        {
            Skillset = skillset;
            Strength = strength;
            Energy = energy;
        }

        public string DisplayProductivity()
        {
            if (Employer != null)
            {
                return Skillset.Skills.First(x => x.Key == Employer.ProducedResource.ImprovedSkill).Value.ToString();
            }

            return Skillset.Skills.OrderByDescending(x => x.Value).First().Value.ToString();
        }

        public decimal GetCurrentUsedSkillLevel()
        {
            if (Employer == null)
            {
                throw new Exception("No current used skill, as there is no current employer");
            }

            return Skillset.Skills.First(x => x.Key == Employer.ProducedResource.ImprovedSkill).Value;
        }

        public void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay)
        {
            if (Employer != null)
            {
                throw new Exception("Already has an employer. Needs to resign first");
            }

            if (Country != jobMarket.Country)
            {
                throw new Exception("Can't take job from another country");
            }

            jobMarket.Offers.Remove(jobOffer);
            jobOffer.Employer.Employees.Add(this);

            Employer = jobOffer.Employer;
            Salary = jobOffer.Salary;
            JobStartDay = currentDay;
            CanResign = false;
        }

        public WorkResult Work()
        {
            if (AlreadyWorked)
            {
                throw new Exception("This person already worked");
            }

            var workResult = Employer.Produce(this, Salary);
            if (workResult == WorkResult.Success)
            {
                IncrementSkill(Employer.ProducedResource.ImprovedSkill);
                Energy -= Constants.ENERGY_LOST_WORKING;
                AlreadyWorked = true;
            }
            else
            {
                CanResign = true;
            }

            return workResult;
        }

        public void Resign(int currentDay)
        {
            if (Employer == null)
            {
                throw new Exception("Can't resign, this person has no employer");
            }

            if (!CanResign)
            {
                throw new Exception("This person can't resign (as the value of the attribute canResign is false)");
            }

            if (Country != Employer.Country)
            {
                throw new Exception("Can't work for another country");
            }

            Employer.Employees.Remove(this);

            Employer = null;
            Salary = 0;
            JobStartDay = 0;
            CanResign = false;
        }

        public void Train()
        {
            if (AlreadyTrained)
            {
                throw new Exception("This person already trained");
            }

            IncrementStrength();
            Energy -= Constants.ENERGY_LOST_TRAINING;
            AlreadyTrained = true;
        }

        public void Eat(Resource resource, int quantity = 1)
        {
            var quantityAfterEating = Inventory.Stocks[resource] - quantity;

            if (!resource.Edible)
            {
                throw new Exception("This resource can't be eaten");
            }

            if (quantityAfterEating < 0)
            {
                throw new Exception("Quantity can't go below zero");
            }

            Energy += Constants.ENERGY_GAINED_AFTER_EATING * quantity;
            Inventory.Stocks[resource] = quantityAfterEating;
        }

        public void EatUntilFull()
        {
            if (_energy + Constants.ENERGY_GAINED_AFTER_EATING <= Constants.MAX_ENERGY)
            {
                var edibleResources = Inventory.Stocks.Where(x => x.Key.Edible && x.Value > 0);
                var quantityToEat = Math.Min((Constants.MAX_ENERGY - _energy) / Constants.ENERGY_GAINED_AFTER_EATING, edibleResources.Count());

                foreach (var edibleRessource in edibleResources)
                {
                    if (edibleRessource.Value >= quantityToEat)
                    {
                        Eat(edibleRessource.Key, quantityToEat);
                        break;
                    }
                    else
                    {
                        Eat(edibleRessource.Key, edibleRessource.Value);
                        quantityToEat -= edibleRessource.Value;
                    }
                }
            }
        }

        private void IncrementStrength()
        {
            Strength = Calculator.CalculateStrengthIncrement(Strength);
        }

        private void IncrementSkill(Skill skill)
        {
            Skillset.Skills[skill] = Calculator.CalculateSkillIncrement(Skillset.Skills[skill]);
        }

        public string DisplayCurrentEmployer()
        {
            return Employer == null ? "None" : Employer.Name;
        }

        public bool CanWork()
        {
            return Employer != null && _energy - Constants.ENERGY_LOST_WORKING >= 0 && !AlreadyWorked;
        }

        public bool CanTrain()
        {
            return _energy - Constants.ENERGY_LOST_TRAINING >= 0 && !AlreadyTrained;
        }
    }
}
