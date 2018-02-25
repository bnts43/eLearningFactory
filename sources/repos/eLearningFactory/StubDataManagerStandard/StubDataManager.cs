using Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class StubDataManager : IDataManager
    {
        public IEnumerable<Cours> ChargerCours()
        {
            List<Cours> dataList = new List<Cours>();
            Cours nomDeLaProgression = new SousCours("Apprendre le C#");
            Cours cours1chap1 = new SousCours("Fondamentaux du C#");
            Cours cours1chap1contenu = new Texte("Les tableaux",
                "DECLARATION ET ALLOCATION DYNAMIQUE DE LA MEMOIRE " +
                "int[] tab; //tab est une référence. Ici, on sait juste que tab désignera un tableau d'entiers à 1 dimension. Ce n'est pas ici " +
                "//qu'on indique la taille. tab étant une référence, il est alloué sur la pile." +
                "tab = new int[3]; //maintenant on alloue la place en mémoire (ici pour 3 entiers) sur le tas." +
                "// Il s'agit donc d'une allocation dynamique");
            cours1chap1.AjouterCours(cours1chap1contenu);

            Cours cours1chap1eval = new Evaluation("Evaluation des acquis sur les tableaux en C#","texte de l'évaluation : **");
            cours1chap1.AjouterCours(cours1chap1eval);

            nomDeLaProgression.AjouterCours(cours1chap1);
            dataList.Add(nomDeLaProgression);


            nomDeLaProgression = new SousCours("Apprendre le Java");
            Cours cours2chap1 = new SousCours("Fondamentaux du Java");
            Cours cours2chap1contenu = new Texte("Les tableaux",
                "Blabla ");
            cours2chap1.AjouterCours(cours2chap1contenu);

            Cours cours2chap1eval = new Evaluation("Evaluation des acquis en Java", "texte de l'évaluation : **");
            cours2chap1.AjouterCours(cours2chap1eval);

            nomDeLaProgression.AjouterCours(cours2chap1);
            dataList.Add(nomDeLaProgression);

            return dataList.AsEnumerable();
        }

        public IEnumerable<Utilisateur> ChargerUtilisateur()
        {
            List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
            
            
            listeUtilisateur.Add(new Utilisateur("neuts", "benoit", "b_neuts@orange.fr", "1234"));

            return listeUtilisateur.AsEnumerable();
        }
    }
}
