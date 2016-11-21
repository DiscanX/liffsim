using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simul
{
    public partial class Form1 : Form
    {
        PersonController personController;

        public Form1()
        {
            InitializeComponent();
            personController = new PersonController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Person person in personController.persons)
            {
                lstPersonnes.Items.Add(person.name);
            }
        }

        private void FillList()
        {

        }

        private void DisplayPerson()
        {

        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = personController.persons.First(x => x.name == lstPersonnes.SelectedItem.ToString());
            txtNom.Text = person.name;
            txtMonnaie.Text = person.money.ToString();
        }
    }
}
