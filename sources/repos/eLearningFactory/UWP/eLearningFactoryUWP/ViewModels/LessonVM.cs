using Core.Model;
using MyMVVMToolkit;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;

namespace eLearningFactoryUWP.ViewModels
{
    class LessonVM : BaseViewModel<Cours>
    {
        public LessonVM(Cours l)
        {
            Model = l;
            if (Model.GetType() == typeof(SousCours))
            {
                LessonsPlanVM = FactoryMToVM.SubLessons(((SousCours)Model).ListeSousCoursROC);
            }

        }

        public string Titre
        {
            get { return Model.Titre; }
        }


        public ObservableCollection<LessonVM> LessonsPlanVM
        {
            get
            {
                return lessonsPlanVM;
            }
            private set
            { lessonsPlanVM = value;
            }
        }

        public ObservableCollection<LessonVM> lessonsPlanVM = new ObservableCollection<LessonVM>();

        public Visibility HasChildToDisplay
        {
            get
            {
                if (Model.GetType() == typeof(SousCours))
                {
                    return Visibility.Visible;
                } else {
                    return Visibility.Visible;
                }
            }
        }

        public Visibility HasContent
        {
            get
            {
                if (Model.GetType() == typeof(Texte))
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }

        public String SubLessonTitle
        {
            get
            {
                if (Model.GetType() == typeof(Texte) || Model.GetType() == typeof(Evaluation) )
                {
                    return Model.Titre;
                } else
                {
                    return null;
                }
            }
        }

        public String SubLessonContent
        {
            get {
                if (Model.GetType() == typeof(Texte)) {
                    return ((Texte)Model).Contenu;
                }
                else {
                    if (Model.GetType() == typeof(Evaluation))
                    {
                        return ((Evaluation)Model).Eval;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
}
}