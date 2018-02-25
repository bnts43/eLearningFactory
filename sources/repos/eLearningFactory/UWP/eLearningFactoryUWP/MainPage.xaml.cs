using eLearningFactoryUWP.ViewModels;
using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using static eLearningFactoryUWP.Views.NavigationTools;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace eLearningFactoryUWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        FacadeVM FVM {
            get
            {
                return (App.Current as App).FacadeVM;
            }
        }


        public MainPage()
        {
            this.InitializeComponent();
            FillTextBoxes();
        }

        [Conditional("DEBUG")]
        private void FillTextBoxes()
        {
            email.Text = "b_neuts@orange.fr";
            password.Text = "1234";
        }
        
        private void UserAuthentification(object sender, RoutedEventArgs e)
        {
            String email = this.email.Text;
            String password = this.password.Text;
            UserVM u = new UserVM(email, password);
            UserVM PotentialCurrentUserVM = FVM.UserAuth(u);
            if (PotentialCurrentUserVM != null)
            {
                FVM.CurrentUserVM = PotentialCurrentUserVM;
                GoToPage(e,typeof(Accueil));
            }
        }

        private void Inscription(object sender, RoutedEventArgs e)
        {
            GoToPage(e, typeof(Inscription));
        }
    }
}
