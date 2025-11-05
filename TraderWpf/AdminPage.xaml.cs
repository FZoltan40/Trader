using System.Windows;
using System.Windows.Controls;

namespace TraderWpf
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private readonly DatabaseStatements _databaseStatements = new DatabaseStatements();
        private readonly MainWindow _mainWindow;
        public AdminPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            userDataGrid.ItemsSource = _databaseStatements.UserList();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var id = idTextBox.Text;

            var userId = new
            {
                Id = id
            };

            MessageBox.Show(_databaseStatements.DeleteUser(userId).ToString());
            userDataGrid.ItemsSource = _databaseStatements.UserList();
        }
    }
}
