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
    /// Interaktionslogik für projectAddPage.xaml
    /// </summary>
    public partial class projectAddPage : Window
    {
            string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                       Data Source=./Projekte1 neu.accdb";
            System.Data.OleDb.OleDbConnection dBVerbindung = null;
            System.Data.OleDb.OleDbCommand befehl = null;
            bool offen = false;
            public projectAddPage()
            {
                InitializeComponent();

                Button saveButton = new Button();
                saveButton.Name = "addProjectBtn";
                saveButton.Click += addProject_Click;

            }
            private void addProject_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                    dBVerbindung.Open();
                    offen = true;
                    befehl = dBVerbindung.CreateCommand();
                    befehl.CommandText = "INSERT INTO Projekte ([id],[projektbezeichnung],[startdatum],[enddatum],[startphase], [verantwortlicher]) VALUES(?, ?, ?, ?, ?,? ); ";
                    int id = 26;
                    string nachn = "Nachname";
                    string vorn = "Vorname";
                    string abteilung = "Abteilung";
                    string telefon = "5555";
                    befehl.Parameters.AddWithValue("id", Id_Text.Text);
                    befehl.Parameters.AddWithValue("projektbezeichnung", Bezeichnung_Text.Text);
                    befehl.Parameters.AddWithValue("startdatum", DateTime.Parse(Startdatum_Text.Text));
                    befehl.Parameters.AddWithValue("enddatum", DateTime.Parse(Enddatum_Text.Text));
                    befehl.Parameters.AddWithValue("startphase", Startphase_Text.Text);
                    befehl.Parameters.AddWithValue("verantwortlicher", Verantwortlicher_Text.Text);

                    befehl.ExecuteNonQuery();
                    MessageBox.Show("Projekt erfolgreich eingefügt." + Environment.NewLine + "Projekte neu laden um Änderung zu sehen");
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
