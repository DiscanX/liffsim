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
        PersonneController personneController;

        public Form1()
        {
            InitializeComponent();
            personneController = new PersonneController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Personne personne in personneController.personnes)
            {
                lstPersonnes.Items.Add(personne.nom);
            }
        }

        private void RemplirListe()
        {

        }

        private void AfficherPersonne()
        {

        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personne personne = personneController.personnes.First(x => x.nom == lstPersonnes.SelectedItem.ToString());
            txtNom.Text = personne.nom;
            txtMonnaie.Text = personne.monnaie.ToString();
        }
    }
}
