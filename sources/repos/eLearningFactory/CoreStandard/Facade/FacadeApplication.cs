using Core.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Core.Facade
{
    public class FacadeApplication
    {
        private List<Utilisateur> ListeUtilisateurs = new List<Utilisateur>();

        public ReadOnlyCollection<Utilisateur> ListeUtilisateursROC
        {
            get;
            private set;
        }

        
        private List<Cours> ListeCours = new List<Cours>();
        private IDataManager dataManager;

        public ReadOnlyCollection<Cours> ListeCoursROC
        {
            get;
            private set;
        }

        
    public Utilisateur UtilisateurCourant { get; private set; } = null;

        public Cours MatiereCourante { get; private set; } = null;

        public Manager Manager { get; set; } = null;

        public void CreationManager()
        {
            
        }

        public void ChargerListeCours(IEnumerable<Cours> liste)
        {
            foreach (Cours item in liste)
            {
                ListeCours.Add(item);
            }
        }

        public void ChargerListeUtilisateurs(IEnumerable<Utilisateur> list)
        {
            foreach (Utilisateur item in list)
            {
                ListeUtilisateurs.Add(item);
            }
        }

        public bool SInscrire(String nom, String prenom, String email, String mdp)
        {
            Utilisateur utilisateur = CreerUtilisateur(nom, prenom, email, mdp);
            if (UtilisateurExiste(utilisateur)==null)
            {
                ListeUtilisateurs.Add(utilisateur);
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public Utilisateur SeConnecter(Utilisateur utilisateur)
        {
            return UtilisateurCourant = UtilisateurExiste(utilisateur);
        }

        public Utilisateur UtilisateurExiste(Utilisateur utilisateur)
        {
            if (ListeUtilisateursROC.Contains(utilisateur))
            {
                // ListeUtilisateursROC.IndexOf(utilisateur);
                return ListeUtilisateursROC.ElementAt(ListeUtilisateursROC.IndexOf(utilisateur));

            }
            else
            {
                return null;
            }
             
        }

        public void SeDeconnecter()
        {
            UtilisateurCourant = null;  
        }

        

        public Utilisateur CreerUtilisateur(String nom, String prenom, String email, String passWord)
        {
            return new Utilisateur(nom, prenom, email, passWord);
            
            
        }

         public FacadeApplication()
        {
           ListeUtilisateursROC = new ReadOnlyCollection<Utilisateur>(ListeUtilisateurs);
           ListeCoursROC = new ReadOnlyCollection<Cours>(ListeCours);
        }

        public FacadeApplication(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            ListeUtilisateursROC = new ReadOnlyCollection<Utilisateur>(ListeUtilisateurs);
            ListeCoursROC = new ReadOnlyCollection<Cours>(ListeCours);
            ChargerListeCours(dataManager.ChargerCours());
            ChargerListeUtilisateurs(dataManager.ChargerUtilisateur());
        }

        public void Remove(Cours cours)
        {
            if (ListeCours.Contains(cours))
            {
                // TODO : partage de l'instance du Manager entre VM et Façade
                ListeCours.Remove(cours);
            }
        }

    }
}
