using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    
    public partial class Form1 : Form
    {
        string pojemnik;
        public static float liczba1;
        public static float liczba2;
        public static float wynik;
        public static char znak;
        //działania kalkulatora funkcje
        public static float Dodawanie(float x, float y)
        {
            float wynik;
            wynik = (x + y);
            return wynik;
        }

        public static float Odejmowanie(float x, float y)
        {
            float wynik;
            wynik = (x - y);

            return wynik;

        }
        public static float Mnozenie(float x, float y)
        {
            float wynik;
            wynik = x * y;

            return wynik;

        }
        public static float Dzielenie(float x, float y)
        {
            float wynik;
            wynik = x / y;

            return wynik;

        }
        public void wyczysc()
        {
            pole.Text = "";
            informacja.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        //wprowadzanie danych poprzez kliknięcie przycisku
        private void button1_Click(object sender, EventArgs e)
        {
            pole.Text += "1";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pole.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pole.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pole.Text += "4";
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            pole.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pole.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pole.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            pole.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            pole.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pole.Text += "0";
        }
        //obdługa kliknięć dla przycisków po których pobieramy dane
        private void button12_Click(object sender, EventArgs e)
        {
          znak = '+';
            try//instrukcja try catch nie zapisuje liczby 1 jesli nie jest liczba
            {
                pojemnik = pole.Text;//pobieranie liczby do zmiennej typu string
                liczba1 = float.Parse(pojemnik);//przekonwertowanie na float
            }
            catch
            {

            }
            wyczysc();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            znak= '-';

            try
            {
                pojemnik = pole.Text;
                liczba1 = float.Parse(pojemnik);
            }
            catch
            {

            }
          
            wyczysc();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            znak = ':';
            try
            {
                pojemnik = pole.Text;
                liczba1 = float.Parse(pojemnik);
            }
            catch
            {

            }
            wyczysc();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            znak = 'x';
            try
            {
                pojemnik = pole.Text;
                liczba1 = float.Parse(pojemnik);
            }
            catch
            {

            }
            wyczysc();
        }
      //obsługa przycisku '='
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                pojemnik = pole.Text;
                liczba2 = float.Parse(pojemnik);

            }
            catch
            {
              
            }
            if(znak=='+')
            {
                wynik = Dodawanie(liczba1, liczba2);
               
             
            }
            else if (znak == '-')
            {
                wynik =Odejmowanie(liczba1, liczba2);

            }
            else if (znak == ':')
            {
                if (liczba2 != 0)
                {
                    wynik = Dzielenie(liczba1, liczba2);//jesli liczba jest rózna od zero wykonuj normalnie
                }
                else
                {
                    pole.Text= "";
                    informacja.Visible = true;//jeśli nie pokaże nam pierwszą liczbe na kalklatorze i pokaze nam informacje ze nie można dzielić przez zero
                }

            }
            else if (znak == 'x')
            {
                wynik = Mnozenie(liczba1 , liczba2);

            }
            else
            {
                
                   wynik = liczba1;
                



            }
            pole.Text = wynik.ToString();
        }
        //obsługa przycisku 'C'
        private void button16_Click(object sender, EventArgs e)
        {
            //czyszczenie danych
            wyczysc();
            liczba1 = 0;
            liczba2 = 0;
            wynik = 0;
        }
        //wstawianie przecinku
        private void button17_Click(object sender, EventArgs e)
        {
            pole.Text += ",";
        }

        private void informacja_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
             AboutBox1 box = new AboutBox1();
            
            box.Show();
        }
    }
}
