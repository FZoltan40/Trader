using System.Windows;
using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly DatabaseStatements _databaseStatements = new DatabaseStatements();
        private readonly MainWindow _mainWindow;
        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new
            {
                Name = userNameTextBox.Text,
                Pass = userPasswordTextBox1.Password
            };
            MessageBox.Show(_databaseStatements.LoginUser(user).ToString());
        }

        private void regLink_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.StartWindow.Navigate(new RegisterPage(_mainWindow));
        }
    }
}
