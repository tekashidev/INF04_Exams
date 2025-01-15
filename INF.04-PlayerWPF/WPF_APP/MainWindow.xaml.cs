using System.IO;
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

namespace WPF_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Piosenka> utwor;
        public int index = 0;

        public MainWindow()
        {
            InitializeComponent();
            utwor = WczytajPlik();
            WyswietlUtwor(index);
        }

        public List<Piosenka> WczytajPlik()
        {
            List < Piosenka > utwor = new List<Piosenka > ();

            string link = "Data.txt";
            var linijki = File.ReadAllLines(link);

            for(int i = 0; i < linijki.Length; i = i+6)
            {
                utwor.Add(new Piosenka(linijki[i], linijki[i+1], linijki[i+2], linijki[i+3], linijki[i+4]));
            }

            return utwor;
        }
        

        public void WyswietlUtwor(int index)
        {
            Tytul.Content = utwor[index].Tytul;
            Album.Content = utwor[index].Album;
            NumUtwor.Content = utwor[index].LiczbaUtworow;
            RokWydania.Content = utwor[index].RokWydania;
            NumPobran.Content = utwor[index].LiczbaPobran;

        }

        private void Nastepna_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= utwor.Count-1)
            {
                index = 0;
            }
            WyswietlUtwor(index);
        }

        private void Poprzednia_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if(index < 0)
            {
                index = utwor.Count-1;
            }
            WyswietlUtwor(index);
        }

        private void Pobierz_Click(object sender, RoutedEventArgs e)
        {

            int Pobrania = int.Parse(utwor[index].LiczbaPobran);
            Pobrania++;
            utwor[index].LiczbaPobran = Pobrania.ToString();
            WyswietlUtwor(index); 
        }
    }
}