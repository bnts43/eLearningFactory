using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
   
   public class Utilisateur : IEquatable<Utilisateur>
    {
        private string id;

        public String Nom { get; private set; } = null;

        public String Prenom { get; private set; } = null;

        public String EMail { get; private set; } = null;

        public String PassWord { get; private set; } = null;
       
        

        public Utilisateur(string nom, string prenom, string eMail, string passWord)
        {
            Nom = nom;
            Prenom = prenom;
            EMail = eMail;
            PassWord = passWord;
        }

        public Utilisateur(string email, string password)
        {
            this.EMail = email;
            PassWord = password;
        }

        public virtual String DonnerCoordonnees()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nom);
            sb.AppendLine(Prenom);
            sb.AppendLine(EMail);
            return sb.ToString();
        }

        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return 2542  % 31;
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

            return this.Equals(right as Utilisateur);
        }

        /// <summary>
        /// checks if this Nounours is equal to the other Nounours
        /// </summary>
        /// <param name="other">the other Nounours to be compared with</param>
        /// <returns>true if equals</returns>
        public bool Equals(Utilisateur other)
        {
            return (this.EMail == other.EMail && this.PassWord == other.PassWord);
        }
    }
}
