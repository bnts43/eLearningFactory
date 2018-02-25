using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Texte : Cours
    {

        public Texte(String titre, String contenu) 
        {
            Titre = titre;
            Contenu = contenu;
        }

        public String Contenu { get; private set; }

        public override String AfficherContenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titre);
            sb.AppendLine(Contenu);
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
