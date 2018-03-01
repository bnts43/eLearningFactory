using Core.Model;
using MyMVVMToolkit;
using System.Collections.ObjectModel;

namespace eLearningFactoryUWP.ViewModels
{
    class SubLessonVM : LessonVM
    {
        public SubLessonVM(Cours l)
            : base(l)
        {
            SubLessonsVM = FactoryMToVM.SubLessons(((SousCours)Model).ListeSousCoursROC);
        }

        private ObservableCollection<LessonVM> subLessonsVM = new ObservableCollection<LessonVM>();
        public ObservableCollection<LessonVM> SubLessonsVM
        {
            get { return subLessonsVM; }
            private set { subLessonsVM = value; }
        }



    }
}
