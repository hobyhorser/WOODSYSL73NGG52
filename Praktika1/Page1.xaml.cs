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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["IVP"].ConnectionString;

        private SqlConnection connection = null;
        public Page1()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            if (Password.Text == Password2.Text)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string command = $"insert into [Table] (login,password) values (N'{Login.Text}','{Password.Text}')";

                SqlDataReader sqlDataReader = null;
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Вы успешно зарегистрированы!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                
            }
            else MessageBox.Show("Пароли не совпадают");
           
        }
    }
}
