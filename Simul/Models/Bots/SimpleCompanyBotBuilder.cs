using System;

namespace Simul.Models.Bots
{
    public class SimpleCompanyBotBuilder
    {
        private Random _rnd;
        private ICompany _company;
        private int _passion;
        private int _greediness;
        private int _stability;

        public SimpleCompanyBotBuilder()
        {
            _rnd = new Random();
        }

        public SimpleCompanyBotBuilder SetCompany(ICompany company)
        {
            _company = company;
            return this;
        }

        public SimpleCompanyBotBuilder SetPassion(int passion)
        {
            _passion = passion;
            return this;
        }

        public SimpleCompanyBotBuilder SetGreediness(int greediness)
        {
            _greediness = greediness;
            return this;
        }

        public SimpleCompanyBotBuilder SetStability(int stability)
        {
            _stability = stability;
            return this;
        }

        public SimpleCompanyBot Build()
        {
            return new SimpleCompanyBot(_company,
                                        _passion,
                                        _greediness,
                                        _stability,
                                        _rnd);
        }
    }
}
