using System;

namespace Core.Model
{
    public abstract class Cours : IEquatable<Cours>
    {
     

        public String Titre { get; internal set; }



        public abstract String AfficherContenu();

        public virtual void AjouterCours(Cours cours)
        {
            throw new Exception("Vous ne pouvez ajouter un cours dans une feuille");

        }


        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return 4000 % 31;
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

            return this.Equals(right as Cours);
        }

        /// <summary>
        /// checks if this Nounours is equal to the other Nounours
        /// </summary>
        /// <param name="other">the other Nounours to be compared with</param>
        /// <returns>true if equals</returns>
        public bool Equals(Cours other)
        {
            return (this.Titre == other.Titre);
        }
    }
}
