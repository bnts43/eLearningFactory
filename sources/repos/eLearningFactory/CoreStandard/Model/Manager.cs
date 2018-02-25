using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Manager
    {
        public IDataManager DataManager { get;private set; }

        public IEnumerable<Cours> ChargerCours()
        {
            return DataManager.ChargerCours();  
        }

        public IEnumerable<Utilisateur> ChargerUtilisateurs()
        {
            return DataManager.ChargerUtilisateur();
        }

        public Manager(IDataManager dataManager)
        {
            DataManager = dataManager;
        }



    }
}
