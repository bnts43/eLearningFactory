using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using static eLearningFactoryUWP.Views.NavigationTools;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace eLearningFactoryUWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Inscription : Page
    {
        public Inscription()
        {
            this.InitializeComponent();
        }

        private void ValidateInscription(object sender, RoutedEventArgs e)
        {
            //TODO 
        }


        private void BackToLogin(object sender, RoutedEventArgs e)
        {
            GoToPage(e, typeof(MainPage));
        }
    }
}
