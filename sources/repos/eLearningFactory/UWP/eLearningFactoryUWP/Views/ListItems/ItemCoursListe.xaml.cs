using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace eLearningFactoryUWP
{
    public sealed partial class ItemCoursListe : UserControl
    {
        public ItemCoursListe()
        {
            this.InitializeComponent();
        }

        public string LessonTitle
        {
            get { return (string)GetValue(LessonTitleProperty); }
            set { SetValue(LessonTitleProperty, value); }
        }

        public static readonly DependencyProperty LessonTitleProperty =
            DependencyProperty.Register("LessonTitle",
                                typeof(string),
                                typeof(ItemCoursListe),
                                new PropertyMetadata("Cours non créé"));
    }
}
