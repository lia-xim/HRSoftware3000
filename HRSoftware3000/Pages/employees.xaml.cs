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
    /// Interaktionslogik für employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        public employees()
        {
            InitializeComponent();
            string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                       Data Source=C:\Users\Nikolas\source\repos\HRSoftware3000\HRSoftware3000\Projekte1 neu.accdb";
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
                    MessageBox.Show(datenleser.GetString(1));
                    MessageBox.Show("Erste Spalte: " + datenleser.GetInt32(0));
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
    }
}
