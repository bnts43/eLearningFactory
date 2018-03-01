using eLearningFactoryUWP.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using static eLearningFactoryUWP.Views.NavigationTools;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace eLearningFactoryUWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Lesson : Page
    {
        FacadeVM FVM
        {
            get
            {
                return (App.Current as App).FacadeVM;
            }
        }
        public Lesson()
        {
            this.InitializeComponent();
        }


        public Visibility SubLessonsVisibility
        {
            get { return (Visibility)GetValue(SubLessonsVisibilityProperty); }
            set { SetValue(SubLessonsVisibilityProperty, value); }
        }

        public static readonly DependencyProperty SubLessonsVisibilityProperty =
            DependencyProperty.Register("SubLessonsVisibility",
                                typeof(Visibility),
                                typeof(ItemCoursListe),
                                new PropertyMetadata(Visibility.Collapsed));

        private void LessonDetail(object sender, ItemClickEventArgs e)
        {
            FVM.SelectedLesson = (LessonVM)e.ClickedItem;
            FVM.SelectedLesson.SelectedIndex = FVM.SelectedLesson.LessonsPlanVM.IndexOf(FVM.SelectedLesson);
            GoToPage(e, typeof(Lesson));
        }
    }
}
