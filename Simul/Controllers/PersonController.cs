using Simul.Models;
using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simul.Controllers
{
    public class PersonController
    {
        static PersonController() { }
        private static PersonController instance = new PersonController();
        public static PersonController Instance { get { return instance; } }

        public List<Person> persons { get; set; }

        private PersonController()
        {
            persons = new List<Person>();
        }
    }
}
