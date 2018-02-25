using System;
using System.Collections.Generic;
using Core.Model;
using MyMVVMToolkit;

namespace eLearningFactoryUWP.ViewModels
{
    internal class UserVM : BaseViewModel<Utilisateur>
    {
        public UserVM(Utilisateur e)
        {
            this.Model = e;
        }

        public UserVM(String id, String password)
        {
            Model = new Utilisateur(id, password);
        }

        public string Nom
        {
            get { return Model.Nom; }
        }

        public string Prenom
        {
            get { return Model.Prenom; }
        }
    }
}