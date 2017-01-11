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

namespace Kolokwium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Podroz NowaPodroz = new Podroz();
       
        public MainWindow()
        {
            InitializeComponent();
            Wyswietlacz.Text = "Podroz: \n";
        }

        private void dodajAutobus(object sender, RoutedEventArgs e)
        {
            
            if(string.IsNullOrEmpty(pobierzIloscMiejsc.Text))
            {
                MessageBox.Show("Prosze uzupelnic pole wartoscia");
            }
            else
            {
                try
                {
                   
                    NowaPodroz.DodajAutobus(Convert.ToInt32(pobierzIloscMiejsc.Text));
                    Wyswietlacz.Text = NowaPodroz.ToString();
                }
                catch(Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
        }

        private void pokazDodajAutobus(object sender, RoutedEventArgs e)
        {
            ramka1.Visibility = Visibility.Visible;
            Ramk2.Visibility = Visibility.Hidden;
            ramka3.Visibility = Visibility.Hidden;
        }

        private void pokazDodajPociag(object sender, RoutedEventArgs e)
        {
            ramka1.Visibility = Visibility.Hidden;
            Ramk2.Visibility = Visibility.Visible;
            ramka3.Visibility = Visibility.Hidden;
        }

        private void dodajPociag(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(pobierzIloscMiejsc2.Text) || string.IsNullOrEmpty(pobierzDlugosctrasy.Text))
            {
                MessageBox.Show("Prosze uzupelnic pole wartoscia");
            }
            else
            {
                try
                {
                 
                    NowaPodroz.DodajPociag(Convert.ToInt32(pobierzIloscMiejsc2.Text), Convert.ToInt32(pobierzDlugosctrasy.Text));
                    Wyswietlacz.Text = NowaPodroz.ToString();


                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
        }

        private void usunOstatni(object sender, RoutedEventArgs e)
        {
            NowaPodroz.UsunOstatni();
            Wyswietlacz.Text = NowaPodroz.ToString();
        }

        private void Wyczysc(object sender, RoutedEventArgs e)
        {
            NowaPodroz.Wyczysc();
            Wyswietlacz.Text = "";
        }

        private void sprawdzDostepnosc(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(pobierzDate.Text))
            {
                MessageBox.Show("Wpisz wartosc do pola");
            }
            else
            {
                try
                {
                    DateTime data=(Convert.ToDateTime(pobierzDate.Text));
                    NowaPodroz.UstawDate(data);
                    if (NowaPodroz.SprawdzDate() == true)
                    {
                        MessageBox.Show("Mozna jechac");
                    }
                    else
                        MessageBox.Show("Nie mozna jechac");
                }
                catch(Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
        }

        private void ustawDate(object sender, RoutedEventArgs e)
        {
            ramka1.Visibility = Visibility.Hidden;
            Ramk2.Visibility = Visibility.Hidden;
            ramka3.Visibility = Visibility.Visible;
        }

        private void Wyjscie(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

      
    }
}
