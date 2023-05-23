using IHM_VRAI_CUSTOM_NET.C;
using NS_WS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM_VRAI_CUSTOM_NET.F.P
{
    /// <summary>
    /// Logique d'interaction pour P_LOGIN_INSCRIPTION.xaml
    /// </summary>
    public partial class P_LOGIN_INSCRIPTION : Page
    {
        public P_LOGIN_INSCRIPTION()
        {
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxN.Text) &&
                !string.IsNullOrEmpty(TextBoxP.Text) &&
                !string.IsNullOrEmpty(TextBoxA.Text) &&
                !string.IsNullOrEmpty(TextBoxCP.Text) &&
                !string.IsNullOrEmpty(TextBoxPh.Text) &&
                !string.IsNullOrEmpty(TextBoxAm.Text) &&
                !string.IsNullOrEmpty(TextBoxMdp.Text) &&
                !string.IsNullOrEmpty(TextBoxVMdp.Text))
            {
                if ( TextBoxMdp.Text == TextBoxVMdp.Text)
                {
                    try
                    {
                        var mdphacher = C_COORDINATION.Instance.Ma_base.HashPasswordAsync(TextBoxMdp.Text).Result;
                        C_AUTHENTIFICATION Nouveau_Auth = new C_AUTHENTIFICATION()
                        {
                            AdresseMailAuth = TextBoxAm.Text,
                            PasswordAuth = mdphacher.Hachage,
                        };
                        var Id = C_COORDINATION.Instance.Ma_base.AddAuthentificationAsync(Nouveau_Auth).Result;

                        int CodePostal = Convert.ToInt32(TextBoxCP.Text);
                        C_CLIENT Nouveau_Client = new C_CLIENT()
                        {
                            NomClient = TextBoxN.Text,
                            PrenomClient = TextBoxP.Text,
                            AdresseClient = TextBoxA.Text,
                            CpClient = $"{CodePostal}",
                            PhotoClient = TextBoxPh.Text,
                            AuthId = Id,
                        };
                        var IdC = C_COORDINATION.Instance.Ma_base.AddClientAsync(Nouveau_Client).Result;
                        MessageBox.Show($"Votre compte a était crée");
                    }
                    catch
                    {
                        MessageBox.Show("Erreur dans la création du compte");
                    }
                }
                else
                {
                    MessageBox.Show("Le Mot de Passe n'est pas le même");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les cases");
            }
           

            
            
        }
    }

    public class TextBoxToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
