using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace HRSoftware3000.Pages
{
    /// <summary>
    /// Interaktionslogik für employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        public Boolean addEmplyeeBtnClicked;
        DataTable dt = new DataTable();
        Grid MainGrid;
        public employees()
        {
            InitializeComponent();
            string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                       Data Source=./Projekte1 neu.accdb";
            System.Data.OleDb.OleDbConnection dBVerbindung = null;
            System.Data.OleDb.OleDbCommand befehl = null;
            System.Data.OleDb.OleDbDataReader datenleser = null;
            bool offen = false;
            try
            {
                dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();
                befehl.CommandText = "SELECT * FROM Mitarbeiter";
                datenleser = befehl.ExecuteReader();

                var column = new DataGridTextColumn();
                column.Header = "Name";
                column.Binding = new Binding("Name");
                employeeDataGrid.Columns.Add(column);

                var column2 = new DataGridTextColumn();
                column2.Header = "Vorname";
                column2.Binding = new Binding("Vorname");
                employeeDataGrid.Columns.Add(column2);

                var column3 = new DataGridTextColumn();
                column3.Header = "Abteilung";
                column3.Binding = new Binding("Abteilung");
                employeeDataGrid.Columns.Add(column3);

                var column4 = new DataGridTextColumn();
                column4.Header = "Telefon";
                column4.Binding = new Binding("Telefon");
                employeeDataGrid.Columns.Add(column4);

                while (datenleser.Read())
                {
                    //MessageBox.Show("Erste Value: " + datenleser.GetValue(0) + " Zweite Value: " + datenleser.GetValue(1) + " Dritte Value: " + datenleser.GetValue(2) + " Vierte Value: " + datenleser.GetValue(3) + " Fuenfte Value: " + datenleser.GetValue(4));
                    employeeDataGrid.Items.Add(new DataItem { Name = datenleser.GetValue(1).ToString(), Vorname = datenleser.GetValue(2).ToString(), Abteilung = datenleser.GetValue(3).ToString(), Telefon = datenleser.GetValue(4).ToString() });
                }
            }
            catch (Exception ausnahme)
            {
                MessageBox.Show("Datenbankfehler: " + ausnahme.Message);
            }
            finally
            {
                if (offen == true) dBVerbindung.Close();
            }
        }

        private void goToEmployeesAddPage(object sender, RoutedEventArgs e)
        {
            Window window = new employeesAddPage();  
            window.Show();

        }

        private void goToEmployeesUpdatePage(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                MainWindow main = new MainWindow();
                main.MainWindowFrame.Source = new Uri("Pages/employeesUpdatePage.xaml", UriKind.Relative);
            }
        }
    }

    public class DataItem
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Abteilung { get; set; }
        public string Telefon { get; set; }
    }
}
