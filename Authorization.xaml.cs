using Apteka.Core;
using Apteka.Core.Database;
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

namespace Apteka
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(EmployeeCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя!", "Внимание!");
                return;
            }
            UserContext.AuthorizedPerson = EmployeeCB.SelectedItem as Employee;
            MessageBox.Show("Вход выполнен успешно!", "Успешно!");
        }
    }
}
