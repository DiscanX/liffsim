using Simul.Models;
using System.Collections.Generic;

namespace Simul.Controllers
{
    public class PersonController
    {
        static PersonController() { }
        public static PersonController Instance = new PersonController();

        public List<IPerson> Persons { get; set; }

        private PersonController()
        {
            Persons = new List<IPerson>();
        }
    }
}
