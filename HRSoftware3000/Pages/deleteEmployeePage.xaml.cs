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

namespace HRSoftware3000.Pages
{
    /// <summary>
    /// Interaktionslogik für employeesAddPage.xaml
    /// </summary>
    public partial class deleteEmployeePage : Window
    {
        string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                       Data Source=./Projekte1 neu.accdb";
        System.Data.OleDb.OleDbConnection dBVerbindung = null;
        System.Data.OleDb.OleDbCommand befehl = null;
        bool offen = false;
        public deleteEmployeePage()
        {
            InitializeComponent();

            Button saveButton = new Button();
            saveButton.Name = "DeleteEmployeeBtn";
            saveButton.Click += deleteEmployee_Click;

        }
        private void deleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();
                befehl.CommandText = "DELETE FROM Mitarbeiter Where [Id]=?; ";
                befehl.Parameters.AddWithValue("?", Id_Text.Text);
                befehl.ExecuteNonQuery();
                MessageBox.Show("Mitarbeiter erfolgreich gelöscht." + Environment.NewLine + "Mitarbeiter neu laden um Änderung zu sehen");
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
    }
}

