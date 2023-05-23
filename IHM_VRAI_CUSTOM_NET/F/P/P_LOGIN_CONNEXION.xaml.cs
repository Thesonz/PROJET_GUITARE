using IHM_VRAI_CUSTOM_NET.C;
using NS_WS;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour P_LOGIN_CONNEXION.xaml
    /// </summary>
    public partial class P_LOGIN_CONNEXION : Page
    {
        public P_LOGIN_CONNEXION()
        {
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
        }
        private void TB_Email_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                TB_Email.Visibility = Visibility.Collapsed;
            }
            else
            {
                TB_Email.Visibility = Visibility.Visible;
            }
        }

        private void TB_MotDePasse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMotDePasse.Focus();
        }

        private void txtMotDePasse_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMotDePasse.Password) && txtMotDePasse.Password.Length > 0)
            {
                TB_MotDePasse.Visibility = Visibility.Collapsed;
            }
            else
            {
                TB_MotDePasse.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMotDePasse.Password) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                try
                {
                    var MdpHacher = C_COORDINATION.Instance.Ma_base.HashPasswordAsync(txtMotDePasse.Password).Result;

                    var resultat = C_COORDINATION.Instance.Ma_base.VerifAuthentificationAsync(new C_AUTHENTIFICATION() { AdresseMailAuth = txtEmail.Text, PasswordAuth = MdpHacher.Hachage }).Result;

                    if (resultat >= 1)
                    {
                        try
                        {
                            var Auth = C_COORDINATION.Instance.Ma_base.GetAuthentificationByEmailAsync(txtEmail.Text).Result;
                            var client = C_COORDINATION.Instance.Ma_base.GetClientByAuthIdAsync(Auth.IdAuth).Result;
                            C_COORDINATION.Instance.LeClient = client;
                            C_COORDINATION.Instance.exit = true;
                        }
                        catch
                        {

                        }
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Email/Mot de Passe Incorrect !");
                }

            }
        }

        
    }
}
