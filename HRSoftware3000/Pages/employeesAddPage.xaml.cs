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
    public partial class employeesAddPage : Window
    {
        string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                       Data Source=./Projekte1 neu.accdb";
        System.Data.OleDb.OleDbConnection dBVerbindung = null;
        System.Data.OleDb.OleDbCommand befehl = null;
        System.Data.OleDb.OleDbDataReader datenleser = null;
        bool offen = false;
        string nachname = null;
        public employeesAddPage()
        {
            InitializeComponent();

            Button saveButton = new Button();
            saveButton.Name = "SaveAddEmployeeBtn";
            saveButton.Click += addEmployee_Click;
            string nachname = null;

        }
        private void addEmployee_Click(object sender, RoutedEventArgs e)
        {
            //inserted ids 4; 10; 20; 21; 22; 23; 24; 25; 26
            //MessageBox.Show("ID: " + Id_Text.Text);
            nachname = Nachname_Text.Text;
            try
            {
                dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();
                befehl.CommandText = "INSERT INTO Mitarbeiter ([id],[nachname],[vorname],[abteilung],[telefon]) VALUES(?, ?, ?, ?, ? ); ";
                int id = 26;
                string nachn = "Nachname";
                string vorn = "Vorname";
                string abteilung = "Abteilung";
                string telefon = "5555";
                befehl.Parameters.AddWithValue("id", Id_Text.Text);
                befehl.Parameters.AddWithValue("nachname", Nachname_Text.Text);
                befehl.Parameters.AddWithValue("vorname", Vorname_Text.Text);
                befehl.Parameters.AddWithValue("abteilung", Abteilung_Text.Text);
                befehl.Parameters.AddWithValue("telefon", Telefon_Text.Text);
                befehl.ExecuteNonQuery();
                MessageBox.Show("Mitarbeiter erfolgreich eingefügt." + Environment.NewLine + "Mitarbeiter neu laden um Änderung zu sehen");
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
