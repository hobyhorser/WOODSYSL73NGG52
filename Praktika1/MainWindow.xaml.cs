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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["IVP"].ConnectionString;

        private SqlConnection connection = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string command = $"select * from [Table]";

            
            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                if (sqlDataReader[1].ToString() == Login.Text && sqlDataReader[2].ToString() == Password.Text)
                {
                    MessageBox.Show($"Вы вошли в аккаунт {sqlDataReader[1]}");
                }
            } 
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
        }
    }
}
