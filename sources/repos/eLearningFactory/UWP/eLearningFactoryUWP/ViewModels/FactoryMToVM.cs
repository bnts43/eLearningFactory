using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.Model;

namespace eLearningFactoryUWP.ViewModels
{
    internal class FactoryMToVM
    {
        internal static ObservableCollection<UserVM> Users(IEnumerable<Utilisateur> chargerUtilisateurs)
        {
            List<UserVM> SVM = new List<UserVM>();
            foreach (var e in chargerUtilisateurs)
            {
                SVM.Add(new UserVM(e));
            }
            return new ObservableCollection<UserVM>(SVM);
        }

        internal static ObservableCollection<LessonVM> SubLessons(ReadOnlyCollection<Cours> listeSousCours)
        {
            List<LessonVM> SLVM = new List<LessonVM>();
            foreach (var s in listeSousCours)
            {
                SLVM.Add(new LessonVM(s));
            }
            return new ObservableCollection<LessonVM>(SLVM);
        }

        internal static ObservableCollection<LessonVM> Lessons(IEnumerable<Cours> enumerable)
        {
            List<LessonVM> LVM = new List<LessonVM>();
            foreach (var l in enumerable)
            {
                LVM.Add(new LessonVM(l));
            }
            return new ObservableCollection<LessonVM>(LVM);
        }

        internal static UserVM User(Utilisateur u)
        {
            if (u != null)
            {
                return new UserVM(u);
            } else
            {
                return null;
            }
        }
    }
}