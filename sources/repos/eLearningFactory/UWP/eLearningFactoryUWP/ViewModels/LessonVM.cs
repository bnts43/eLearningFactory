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
                    return Visibility.Collapsed;
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
                    return Visibility.Collapsed;
                }
            }
        }

        public String SubLessonTitle
        {
            get
            {
                    return Model.Titre;
            }
        }

        public String SubLessonContent
        {
            get {
                if (Model.GetType() == typeof(Texte)) {
                    if (((Texte)Model).Contenu != "" && ((Texte)Model).Contenu != null)
                    {
                        return ((Texte)Model).Contenu;
                    } else
                    {
                        return "Aucun contenu renseigné pour cette rubrique";
                    }
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


        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return 4000 % 31;
        }

        /// <summary>
        /// checks if the "right" object is equal to this Cours or not
        /// </summary>
        /// <param name="right">the other object to be compared with this Cours</param>
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

            return this.Equals(right as LessonVM);
        }

        /// <summary>
        /// checks if this Cours is equal to the other Cours
        /// </summary>
        /// <param name="other">the other Cours to be compared with</param>
        /// <returns>true if equals</returns>
        public bool Equals(LessonVM other)
        {
            return (this.Model == other.Model);
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                // TODO : set is not called - there's a problem
                SetProperty(ref selectedIndex, value);
                OnPropertyChanged(nameof(SelectedLesson));
                // TODO OnPropertyChanged(nameof(DeleteCommand));
            }
        }

        private int selectedIndex = -1;

        public LessonVM SelectedLesson
        {
            get
            {
                // SelectedIndex is always -1 due to setproperty not working properly (not even called)

                return (SelectedIndex != -1) ? LessonsPlanVM[SelectedIndex] : null;
            }
            set
            {
                this.SelectedLesson = value;
            }
        }

    }
}