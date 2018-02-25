using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Etudiant : Utilisateur, IEquatable<Etudiant>
    {
        public Cours CoursActuel { get; private set; } = null;

        private List<Cours> coursTermine = new List<Cours>();

        public ReadOnlyCollection<Cours> CoursTermineROC
        {
            get;
            private set;
        }
        private List<Cours> coursEnCours = new List<Cours>();

        public ReadOnlyCollection<Cours> CoursEnCoursROC
        {
            get;
            private set;
        }




        public Etudiant(string nom, string prenom, string eMail, string passWord) : base(nom, prenom, eMail, passWord)
        {
            CoursTermineROC = new ReadOnlyCollection<Cours>(coursTermine);
            CoursEnCoursROC = new ReadOnlyCollection<Cours>(coursEnCours);
        }
        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return 2542 % 31;
        }

        /// <summary>
        /// checks if the "right" object is equal to this Nounours or not
        /// </summary>
        /// <param name="right">the other object to be compared with this Nounours</param>
        /// <returns>true if equals, false if not</returns>
        public override bool Equals(object right)
        {
            //check null
            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Etudiant);
        }

        /// <summary>
        /// checks if this Nounours is equal to the other Nounours
        /// </summary>
        /// <param name="other">the other Nounours to be compared with</param>
        /// <returns>true if equals</returns>
        public bool Equals(Etudiant other)
        {
            return (this.EMail == other.EMail);
        }

        public void AjouterCoursTermine(Cours cours)
        {
            coursTermine.Add(cours);

        }

        public void AjouterCoursEnCours(Cours cours)
        {
            coursEnCours.Add(cours);
        }

        public override String DonnerCoordonnees()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nom);
            sb.AppendLine(Prenom);
            sb.AppendLine(EMail);
            return sb.ToString();
        }


    }
}
