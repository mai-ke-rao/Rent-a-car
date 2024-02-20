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
    /// Interaction logic for Vozila.xaml
    /// </summary>
    public partial class Vozila : UserControl
    {
        public Vozila()
        {
            InitializeComponent();

            List<Mahine> Masine = new List<Mahine>();

            Masine.Add(new Mahine()
            {
                Marka = "Mercedes",
                Kilometri = 420000,
                Godiste = 2015,
                
                Broj_vrata = 5,
                Tip = tip.Limuzina,
                Snaga = 145,
                Menjac = menjac.Manuelni,
                Pogon = pogon.Dizel,
                Mehanicko_ostecenje = "Nema",
                Kozmeticko_ostecenje = "Nema",
                ID_Vozila = 1,


            }); ;
            Masine.Add(new Mahine()
            {
                Marka = "BMW",
                Kilometri = 221000,
                Godiste = 2017,
                Broj_sedista = 5,
                Broj_vrata = 5,
                Tip = tip.Limuzina,
                Snaga = 135,
                Menjac = menjac.Automacki,
                Pogon = pogon.Dizel,
                Mehanicko_ostecenje = "Nema",
                Kozmeticko_ostecenje = "Nema",
                ID_Vozila = 2,


            }); ;
            Masine.Add(new Mahine()
            {
                Marka = "Hyundai",
                Kilometri = 281000,
                Godiste = 2016,
                Broj_sedista = 5,
                Broj_vrata = 5,
                Tip = tip.Dzip,
                Snaga = 155,
                Menjac = menjac.Manuelni,
                Pogon = pogon.Dizel,
                Mehanicko_ostecenje = "Nema",
                Kozmeticko_ostecenje = "Nema",
                ID_Vozila = 3,


            }); ;

            vozilaDGrid.ItemsSource = Masine;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeCreate newWindow = new EmployeCreate();
            newWindow.ShowDialog();
            //Close();
        }


    }

    public enum pogon { Dizel, Benzin, Plin, Struja }
    public enum tip { Limuzina, Karavan, Hecbeg, Motor, Kabriolet, Kvad, Dzip }
    public enum menjac { Automacki, Manuelni}
    public class Mahine
    {
        public String Marka { get; set; }
        public int Kilometri { get; set; }
        public int Godiste { get; set; }
        public int Broj_vrata { get; set; }
        public int Broj_sedista { get; set; }


        public int Snaga { get; set; }
       public pogon Pogon { get; set; }
       public tip Tip { get; set; }

        public menjac Menjac { get; set; }
        public String Mehanicko_ostecenje { get; set; }
        public String Kozmeticko_ostecenje { get; set; }
        /* DateTime Vreme_zazueca { get; set; }
         DateTime Vreme_vracanja { get; set; }*/
        public int ID_Vozila;
        //Ne znam kako bi sliku dodao.
    }

}


