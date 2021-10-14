using System;
using System.Windows;

namespace Taschenrechner_grafisch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string zahl1 { get; set; }
        public string zahl2 { get; set; }
        public bool zahl2aktiv { get; set; }
        public bool plus { get; set; }
        public bool minus { get; set; }
        public bool mal { get; set; }
        public bool dividiert { get; set; }
        public bool hoch { get; set; }
        public bool gleichgedrueckt { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            zahl1 = "";
            zahl2 = "";
            zahl2aktiv = false;
            plus = false;
            minus = false;
            mal = false;
            dividiert = false;
            hoch = false;
            gleichgedrueckt = false;
        }
        public void addnumber(string zahl)
        {
            if (zahl2aktiv == false)
            {
                zahl1 += zahl;
                ausgabe_fenster.Content = zahl1;
            }
            else if (zahl2aktiv == true)
            {
                zahl2 += zahl;
                ausgabe_fenster.Content = zahl2;
            }
        }

        public void alleszurücksetzen()
        {
            zahl1 = "";
            zahl2 = "";
            gleichgedrueckt = false;
            zahl2aktiv = false;
            plus = false;
            minus = false;
            mal = false;
            dividiert = false;
            hoch = false;
        }

        private void Zahl_1_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }

            addnumber("1");

        }

        private void Zahl_2_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("2");
        }

        private void Zahl_3_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("3");
        }

        private void Zahl_4_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("4");
        }

        private void Zahl_5_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("5");
        }

        private void Zahl_6_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("6");
        }

        private void Zahl_7_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("7");
        }

        private void Zahl_8_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("8");
        }

        private void Zahl_9_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("9");
        }

        private void Zahl_0_Click(object sender, RoutedEventArgs e)
        {
            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }
            addnumber("0");
        }

        private void Zeichen_komma_Click(object sender, RoutedEventArgs e)
        {

            if (gleichgedrueckt == true)
            {
                alleszurücksetzen();
            }

            if (zahl2aktiv == false && (plus || minus || mal || dividiert || hoch == true))
            {
                zahl2aktiv = true;
            }

            if (zahl2aktiv == false && !zahl1.Contains(","))
            {
                if (zahl1 == "")
                {
                    zahl1 += "0,";
                }
                else
                {
                    zahl1 += ",";
                }
                ausgabe_fenster.Content = zahl1;
            }
            else if (zahl2aktiv == true && !zahl2.Contains(","))
            {
                if (zahl2 == "")
                {
                    zahl2 += "0,";
                }
                else
                {
                    zahl2 += ",";
                }
                ausgabe_fenster.Content = zahl2;
            }
        }

        private void Operator_plus_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 != "" && zahl2 != "")
            {
                if (zahl1 == "" && zahl2 != "")
                {
                    zahl1 = zahl2;
                    zahl2 = "";
                }
                else if (zahl1 != "" && zahl2 == "")
                {

                }
                else if (plus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
                }
                else if (minus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
                }
                else if (mal == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
                }
                else if (dividiert == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
                }
                else if (hoch == true)
                {
                    zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
                }
                ausgabe_fenster.Content = zahl1;
                zahl2 = "";
            }

            plus = true;
            minus = false;
            mal = false;
            dividiert = false;
            hoch = false;
            zahl2aktiv = true;
            gleichgedrueckt = false;
        }

        private void Operator_minus_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 != "" && zahl2 != "")
            {
                if (zahl1 == "" && zahl2 != "")
                {
                    zahl1 = zahl2;
                    zahl2 = "";
                }
                else if (zahl1 != "" && zahl2 == "")
                {

                }
                else if (plus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
                }
                else if (minus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
                }
                else if (mal == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
                }
                else if (dividiert == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
                }
                else if (hoch == true)
                {
                    zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
                }
                ausgabe_fenster.Content = zahl1;
                zahl2 = "";
            }

            plus = false;
            minus = true;
            mal = false;
            dividiert = false;
            hoch = false;
            zahl2aktiv = true;
            gleichgedrueckt = false;
        }

        private void Operator_mal_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 != "" && zahl2 != "")
            {
                if (zahl1 == "" && zahl2 != "")
                {
                    zahl1 = zahl2;
                    zahl2 = "";
                }
                else if (zahl1 != "" && zahl2 == "")
                {

                }
                else if (plus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
                }
                else if (minus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
                }
                else if (mal == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
                }
                else if (dividiert == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
                }
                else if (hoch == true)
                {
                    zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
                }
                ausgabe_fenster.Content = zahl1;
                zahl2 = "";
            }

            plus = false;
            minus = false;
            mal = true;
            dividiert = false;
            hoch = false;
            zahl2aktiv = true;
            gleichgedrueckt = false;
        }

        private void Operator_dividiert_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 != "" && zahl2 != "")
            {
                if (zahl1 == "" && zahl2 != "")
                {
                    zahl1 = zahl2;
                    zahl2 = "";
                }
                else if (zahl1 != "" && zahl2 == "")
                {

                }
                else if (plus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
                }
                else if (minus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
                }
                else if (mal == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
                }
                else if (dividiert == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
                }
                else if (hoch == true)
                {
                    zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
                }
                ausgabe_fenster.Content = zahl1;
                zahl2 = "";
            }

            plus = false;
            minus = false;
            mal = false;
            dividiert = true;
            hoch = false;
            zahl2aktiv = true;
            gleichgedrueckt = false;
        }

        private void Operator_hoch_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 != "" && zahl2 != "")
            {
                if (zahl1 == "" && zahl2 != "")
                {
                    zahl1 = zahl2;
                    zahl2 = "";
                }
                else if (zahl1 != "" && zahl2 == "")
                {

                }
                else if (plus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
                }
                else if (minus == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
                }
                else if (mal == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
                }
                else if (dividiert == true)
                {
                    zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
                }
                else if (hoch == true)
                {
                    zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
                }
                ausgabe_fenster.Content = zahl1;
                zahl2 = "";
            }

            plus = false;
            minus = false;
            mal = false;
            dividiert = false;
            hoch = true;
            zahl2aktiv = true;
            gleichgedrueckt = false;
        }



        private void Operator_gleichheitszeichen_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 == "" && zahl2 != "")
            {
                zahl1 = zahl2;
                zahl2 = "";
            }
            else if (zahl1 != "" && zahl2 == "")
            {

            }
            else if (plus == true)
            {
                zahl1 = Convert.ToString(Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2));
            }
            else if (minus == true)
            {
                zahl1 = Convert.ToString(Convert.ToDouble(zahl1) - Convert.ToDouble(zahl2));
            }
            else if (mal == true)
            {
                zahl1 = Convert.ToString(Convert.ToDouble(zahl1) * Convert.ToDouble(zahl2));
            }
            else if (dividiert == true)
            {
                zahl1 = Convert.ToString(Convert.ToDouble(zahl1) / Convert.ToDouble(zahl2));
            }
            else if (hoch == true)
            {
                zahl1 = Convert.ToString(Math.Pow(Convert.ToDouble(zahl1), Convert.ToDouble(zahl2)));
            }
            ausgabe_fenster.Content = zahl1;

            zahl2 = "";
            zahl2aktiv = false;
            gleichgedrueckt = true;
        }

        private void Option_Clear_all_Click(object sender, RoutedEventArgs e)
        {
            alleszurücksetzen();
            ausgabe_fenster.Content = "";
        }

        private void Option_Clear_active_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 == "" && zahl2 == "")
            {

            }
            else if (zahl2aktiv == false)
            {
                zahl1 = "";
                ausgabe_fenster.Content = zahl1;
            }
            else if (zahl2aktiv == true)
            {
                zahl2 = "";
                ausgabe_fenster.Content = zahl2;
            }
        }

        private void Option_Clear_one_Click(object sender, RoutedEventArgs e)
        {
            if (zahl1 == "" && zahl2 == "")
            {

            }
            else if (zahl2aktiv == false)
            {
                zahl1 = zahl1.Remove(zahl1.Length - 1);
                ausgabe_fenster.Content = zahl1;


            }
            else if (zahl2aktiv == true)
            {
                zahl2 = zahl2.Remove(zahl2.Length - 1);
                ausgabe_fenster.Content = zahl2;
            }
        }
    }


}
