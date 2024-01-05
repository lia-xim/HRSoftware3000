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
                                       Data Source=C:\Users\ZeroLogOn\Documents\GitHub\HRSoftware3000\HRSoftware3000\Projekte1 neu.accdb";
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
                while (datenleser.Read())
                {
                    for (int i = 1; i <= 4; ++i)
                    {
                        var column = new DataGridTextColumn();
                        column.Header = "Column" + i;
                        column.Binding = new Binding("Column" + i);
                        employeeDataGrid.Columns.Add(column);
                    }

                    // Erstellen und Hinzufügen von zwei Zeilen mit gefälschten Daten, die angezeigt werden sollen
                    employeeDataGrid.Items.Add(new DataItem { Column1 = "a.1", Column2 = "a.2", Column3 = "a.3", Column4 = "a.4" });
                    employeeDataGrid.Items.Add(new DataItem { Column1 = "b.1", Column2 = "b.2", Column3 = "b.3", Column4 = "b.4" });

                    //MessageBox.Show(datenleser.GetString(1));
                    //MessageBox.Show("Erste Spalte: " + datenleser.GetInt32(0));
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
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
    }


}
