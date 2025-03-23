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
    public partial class KijelentkezesWindow : Window
    {
        public KijelentkezesWindow()
        {
            InitializeComponent();
        }

        private void btnIgen_Click(object sender, RoutedEventArgs e)
        {
            // Kijelentkezés logika (pl. alkalmazás bezárása)
            Application.Current.Shutdown();
        }

        private void btnMegse_Click(object sender, RoutedEventArgs e)
        {
            // Ablak bezárása, ha nem szeretne kijelentkezni
            this.Close();
        }
    }
}
