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
using System.Windows.Shapes;

namespace PetsHotel
{
    /// <summary>
    /// Interaction logic for FelvetelWindow.xaml
    /// </summary>
    public partial class FelvetelWindow : Window
    {
        public FelvetelWindow()
        {
            InitializeComponent();
        }

        private void Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNev.Text) ||
                string.IsNullOrWhiteSpace(tbxFaj.Text) ||
                string.IsNullOrWhiteSpace(tbxFajta.Text) ||
                string.IsNullOrWhiteSpace(tbxNem.Text) ||
                string.IsNullOrWhiteSpace(tbxSzin.Text) ||
                string.IsNullOrWhiteSpace(dpSzulDatum.Text) ||
                string.IsNullOrWhiteSpace(tbxSuly.Text))
            {
                MessageBox.Show("Kérlek, tölts ki minden kötelező mezőt!", "Hiányzó adat", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DateTime szulDatum;
            int suly;
            if (!DateTime.TryParse(dpSzulDatum.Text, out szulDatum))
            {
                MessageBox.Show("Hibás születési dátum formátum!", "Érvénytelen adat", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(tbxSuly.Text, out suly))
            {
                MessageBox.Show("Hibás súly érték! Kérlek, egész számot adj meg.", "Érvénytelen adat", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Pet ujKedvenc = new Pet(tbxNev.Text, tbxFaj.Text, tbxFajta.Text, tbxNem.Text, tbxSzin.Text, DateTime.Parse(dpSzulDatum.Text), int.Parse(tbxSuly.Text), tbxEtel.Text, tbxJatek.Text);

            MainWindow.pets.Add(ujKedvenc);
            MessageBox.Show("Sikeres felvétel.");
            Close();
        }
    }
}
