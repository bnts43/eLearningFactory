using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core.Model
{
    public class SousCours : Cours
    {
        private List<Cours> listeSousCours = new List<Cours>();

        public ReadOnlyCollection<Cours> ListeSousCoursROC
        {
            get;
            private set;
        }


        public SousCours(string titreSaisi) 
        {
            Titre = titreSaisi;
            ListeSousCoursROC = new ReadOnlyCollection<Cours>(listeSousCours);
        }

        public SousCours(string titreDefini,List<Cours> listeDefinie) 
        {
            Titre = titreDefini;
            ListeSousCoursROC = new ReadOnlyCollection<Cours>(listeSousCours);
            listeDefinie.ForEach(souscours => listeSousCours.Add(souscours));
        }

        public override String AfficherContenu()
        {
            StringBuilder sb = new StringBuilder();
           
            listeSousCours.ForEach(item =>
            {
                sb.AppendLine(item.Titre);
                sb.AppendLine(item.AfficherContenu());
                sb.AppendLine("");
            });
            return sb.ToString();
        }

        public override void AjouterCours(Cours cours)
        {
            if (!SousCoursDejaExistant(cours))
            {
                listeSousCours.Add(cours);
            }
           
        }

        public bool SousCoursDejaExistant(Cours cours)
        {
            return listeSousCours.Contains(cours);
        }
    }
}
