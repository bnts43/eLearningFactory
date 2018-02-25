using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace eLearningFactoryUWP
{
    public sealed partial class ItemSubLessonDetail : UserControl
    {
        public ItemSubLessonDetail()
        {
            this.InitializeComponent();
        }

        public string SubLessonTitle
        {
            get { return (string)GetValue(SubLessonTitleProperty); }
            set { SetValue(SubLessonTitleProperty, value); }
        }

        public static readonly DependencyProperty SubLessonTitleProperty =
            DependencyProperty.Register("SubLessonTitle",
                                typeof(string),
                                typeof(ItemSubLessonDetail),
                                new PropertyMetadata("Cours non créé"));

        public string SubLessonContent
        {
            get { return (string)GetValue(SubLessonContentProperty); }
            set  { SetValue(SubLessonContentProperty, value); }
        }

        public static readonly DependencyProperty SubLessonContentProperty =
            DependencyProperty.Register("SubLessonContent",
                                typeof(string),
                                typeof(ItemSubLessonDetail),
                                new PropertyMetadata("Cours non créé"));
    }
}
