using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szabo_dolgozatWPFfeladat
{
    public partial class MainWindow : Window
    {
        public class Dolgozat
        {
            public string Nev { get; set; }
            public int Eletkor { get; set; }
            public int Pontszam { get; set; }

            public Dolgozat(string nev, int eletkor, int pontszam)
            {
                Nev = nev;
                Eletkor = eletkor;
                Pontszam = pontszam;
            }

        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}