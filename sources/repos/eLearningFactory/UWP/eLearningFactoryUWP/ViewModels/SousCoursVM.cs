using Core.Model;
using MyMVVMToolkit;
using System.Collections.ObjectModel;

namespace eLearningFactoryUWP.ViewModels
{
    class SousCoursVM : BaseViewModel<SousCours>
    {
        public SousCoursVM(SousCours sc)
        {
            Model = sc;
            SubLessonsVM = FactoryMToVM.SubLessons(Model.ListeSousCoursROC);
        }

        private ObservableCollection<LessonVM> subLessonsVM = new ObservableCollection<LessonVM>();
        public ObservableCollection<LessonVM> SubLessonsVM
        {
            get { return subLessonsVM; }
            private set { subLessonsVM = value; }
        }



    }
}
