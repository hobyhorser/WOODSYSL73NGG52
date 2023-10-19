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
using System.IO;

namespace Praktika1
{
    public class Test
    {
        public Test(string Name, string Type, string Price, string Colvo)
        {
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;
            this.Colvo = Colvo;

        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Colvo { get; set; }
    }

    public partial class Balenci : Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["IVP"].ConnectionString;

        private SqlConnection connection = null;
        int rowCount = 0;
        public Balenci()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string command = $"select * from Tovari";

            SqlDataReader sqlDataReader = null;
            SqlCommand cmd = new SqlCommand(command, connection);

            string[] list = new string[5];
            sqlDataReader = cmd.ExecuteReader();
          
            int j = 1;
            while (sqlDataReader.Read())
            {
                for (int i = 1; i < 5; i++)
                {
                    list[i] = sqlDataReader[i].ToString();
                }
                

                var data = new Test(list[1], list[2], list[3], list[4]);
                DataGridTest.Items.Add(data);
                
                j++;
            }

        }


        private void DataGridTest_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test path = DataGridTest.SelectedItem as Test;
            try
            {
                if (DataGridTest.SelectedItem is null)
                {

                    throw new Exception("Нет значений");

                }

                else
                {

                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string command = $"delete from [Tovari] where name like N'{path.Name}' ";


                    SqlCommand cmd = new SqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                    string comman = $"select * from Tovari";

                    SqlDataReader sqlDataReader = null;
                    SqlCommand cm = new SqlCommand(comman, connection);

                    string[] list = new string[5];
                    sqlDataReader = cm.ExecuteReader();
                    DataGridTest.Items.Clear();
                    int j = 1;
                    while (sqlDataReader.Read())
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            list[i] = sqlDataReader[i].ToString();
                        }


                        var data = new Test(list[1], list[2], list[3], list[4]);
                        DataGridTest.Items.Add(data);

                        j++;
                    }

                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            
        }

        private void Zapisat(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string command = $"insert into [Tovari] (name,tipe,cost,kolvo) values (N'{name1.Text}','{tipe1.Text}','{cost1.Text}','{kolvo1.Text}')";

         
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            string comman = $"select * from Tovari";

            SqlDataReader sqlDataReader = null;
            SqlCommand cm = new SqlCommand(comman, connection);

            string[] list = new string[5];
            sqlDataReader = cm.ExecuteReader();
            DataGridTest.Items.Clear();
            int j = 1;
            while (sqlDataReader.Read())
            {
                for (int i = 1; i < 5; i++)
                {
                    list[i] = sqlDataReader[i].ToString();
                }


                var data = new Test(list[1], list[2], list[3], list[4]);
                DataGridTest.Items.Add(data);

                j++;
            }
        }
    }
}
