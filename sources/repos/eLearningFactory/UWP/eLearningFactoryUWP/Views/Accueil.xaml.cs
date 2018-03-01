using eLearningFactoryUWP.ViewModels;
using Windows.UI.Xaml.Controls;
using static eLearningFactoryUWP.Views.NavigationTools;

namespace eLearningFactoryUWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Accueil : Page
    {
        FacadeVM FVM
        {
            get
            {
                return (App.Current as App).FacadeVM;
            }
        }

        public Accueil()
        {
            this.InitializeComponent();
        }


        private void LessonDetail(object sender, ItemClickEventArgs e)
        {
            FVM.SelectedLesson = (LessonVM)e.ClickedItem;
            
            FVM.SelectedIndex = FVM.LessonsListVM.IndexOf(FVM.SelectedLesson);
            GoToPage(e, typeof(Lesson));
        }

    }
}
