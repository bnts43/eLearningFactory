using MyMVVMToolkit;
using System;
using Core.Facade;
using Core.Model;
using System.Collections.ObjectModel;

namespace eLearningFactoryUWP.ViewModels
{
    class FacadeVM : BaseViewModel<FacadeApplication>
    {

        public ObservableCollection<UserVM> UsersListVM
        { get { return usersListVM;  }
            private set { usersListVM = value; }

        }

        private ObservableCollection<UserVM> usersListVM = new ObservableCollection<UserVM>();

        public ObservableCollection<LessonVM> LessonsListVM
        { get { return lessonsListVM; }
            private set { lessonsListVM = value; }
        }

        private ObservableCollection<LessonVM> lessonsListVM = new ObservableCollection<LessonVM>();


        public UserVM CurrentUserVM
            { get ; set; }

        public LessonVM MatiereCourante
            { get; set; }


        public FacadeVM(IDataManager dataManager)
        {
            Model = new FacadeApplication(dataManager);
            UsersListVM = FactoryMToVM.Users(Model.ListeUtilisateursROC);
            LessonsListVM = FactoryMToVM.Lessons(Model.ListeCoursROC);
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

        public UserVM UserAuth(UserVM u)
        {
            return FactoryMToVM.User(Model.SeConnecter(u.Model));
        }

        private int selectedIndex = -1;

        public LessonVM SelectedLesson
        {
            get;/*
            {
                // SelectedIndex is always -1 due to setproperty not working properly (not even called)
                //return (SelectedIndex != -1) ? LessonsListVM[SelectedIndex] : null;
            }*/
            set;/*
            {
                this.SelectedLesson = value;
            }*/
        }


        
    }
}
