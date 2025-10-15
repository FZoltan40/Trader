using System.Windows;
using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("✔Login");
        }
    }
}
