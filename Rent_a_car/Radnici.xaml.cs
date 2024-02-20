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

namespace Rent_a_car.Windows
{
    /// <summary>
    /// Interaction logic for Radnici.xaml
    /// </summary>
    public partial class Radnici : UserControl
    {
       
        public Radnici()
        {
            InitializeComponent();
            List<ZZaRaspored> ZRaspored = new List<ZZaRaspored>();
            List<ZZaPlatu> ZPlatu = new List<ZZaPlatu>();
            List<ZSve> Sve = new List<ZSve>();
            ZRaspored.Add(new ZZaRaspored()
            {
                Puno_ime = "Ivisa Misinski",
                Radnik_ID = 1,
                Nedeljna_satnica = 40,
                Broj_slobodnih_dana = 20,
                Uloga = "Prodavac"


            }) ; ;
            ZRaspored.Add(new ZZaRaspored()
            {
                Puno_ime = "Krkic Spasoje",
                Radnik_ID = 2,
                Nedeljna_satnica = 40,
                Broj_slobodnih_dana = 20,
                Uloga = "Terenska podrska",


            }); ;


           RadniciSve.ItemsSource = Sve;
            RadniciRaspored.ItemsSource = ZRaspored;
           RadniciPlate.ItemsSource = ZPlatu;
        }

       
    }


 

    public class ZZaRaspored 
    {
        public String Puno_ime;
        public int Radnik_ID;
        public int Nedeljna_satnica;
        public int Broj_slobodnih_dana;
        public String Uloga;
    }
    
    public class ZZaPlatu 
    {
        public String Puno_ime;
        public int Radnik_ID;
        public String Datum_zaposlenja;
        public int Plata;
        public double Tekuci_racun;
    }
    public class ZSve 
    {
        public String Puno_ime;
        public int Radnik_ID;
        public int Nedeljna_satnica;
        public int Broj_slobodnih_dana;
        public String Datum_zaposlenja;
        public String Datum_rodjenja;
        public int Plata;
        public String Grad;
        public String Ulica_i_br;
        public int Radno_vreme;
        public String Opis_posla;
        public String Uloga;
        public String Vrsta_radnog_odnosa;
        public double Tekuci_racun;
        
    }
    

}
