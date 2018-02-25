using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Evaluation : Cours
    {
        public String Eval { get; internal set; }

        public Evaluation(String titre, String eval) 
        {
            Titre = titre;
            Eval = eval;
        }
        



        public override String AfficherContenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titre);
            sb.AppendLine(Eval);
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
