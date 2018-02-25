using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using static eLearningFactoryUWP.Views.NavigationTools;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace eLearningFactoryUWP
{
    public sealed partial class ActionBar : UserControl
    {
        public ActionBar()
        {
            this.InitializeComponent();
        }

        private void GoToHome(object sender, RoutedEventArgs e)
        {
            GoToPage(e, typeof(Accueil));
        }

        private void GoToMyAccount(object sender, RoutedEventArgs e)
        {
            GoToPage(e,typeof(MonCompte));
        }
    }
}
