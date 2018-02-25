using eLearningFactoryUWP.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using static eLearningFactoryUWP.Views.NavigationTools;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace eLearningFactoryUWP
{
    public sealed partial class UserInfoAndLog : UserControl
    {

        FacadeVM FVM
        {
            get
            {
                return (App.Current as App).FacadeVM;
            }
        }

        public UserInfoAndLog()
        {
            this.InitializeComponent();
        }

        private void GoToLogin(object sender, RoutedEventArgs e)
        {
            // TODO : manage an authentification process
            GoToPage(e, typeof(MainPage));
        }

        private void EditPersonalInfo(object sender, RoutedEventArgs e)
        {
            // TODO
        }

 
    }
}
