using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wisielec
{
    class Program
    {
        //funkcje rysujace 
        static void rys1()
        {
            Console.WriteLine("   ");
            Console.WriteLine("  * ");
            Console.WriteLine(" *   ");
            Console.WriteLine("*     ");
        }
        static void rys2()
        {
            Console.WriteLine("   * ");
            Console.WriteLine("  * * ");
            Console.WriteLine(" *   * ");
            Console.WriteLine("*     * ");
        }
        static void rys3()
        {
            Console.WriteLine("   *======^ ");
            Console.WriteLine("  * *");
            Console.WriteLine(" *   *");
            Console.WriteLine("*     *");
        }
        static void rys4()
        {
            Console.WriteLine("   *======^ ");
            Console.WriteLine("  * *    ( )");
            Console.WriteLine(" *   *");
            Console.WriteLine("*     *");
        }
        static void rys5()
        {
            Console.WriteLine("   *======^ ");
            Console.WriteLine("  * *    ( )");
            Console.WriteLine(" *   *    |  ");
            Console.WriteLine("*     *   ");
        }
        static void rys6()
        {
            Console.WriteLine("   *======^ ");
            Console.WriteLine("  * *    ( )");
            Console.WriteLine(" *   *   -|-  ");
            Console.WriteLine("*     *   ");
        }
        
        static void rys7()
        {
            Console.WriteLine(" PRZEGRALES");
            Console.WriteLine("   *======^ ");
            Console.WriteLine("  * *    ( )");
            Console.WriteLine(" *   *   -|-  ");
            Console.WriteLine("*     *  ? ? ");
        }
        //funkcja wczytujaca tekst z pliku tekstowego
        static void odczyt(string []haslo,string []kat)
        {
            FileStream fs = new FileStream("wisielec.txt",
           FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                if (nrlini % 2 == 0)
                {
                    haslo[licznik] = sr.ReadLine();
                }

                else if (nrlini % 2 == 1)
                {

                    kat[licznik] = sr.ReadLine();
                    licznik++;
                }
                nrlini++;
            }
            sr.Close();
           
        }

        static int nrlini=0,licznik=0;
        static string haslo2="";
        static char litera;
        static string napis= "";
        static int blad = 0;
        static int wybor=1;
        static bool trafiona = false;
        static bool przegrana = false;
        static void Main()
        {

            Random a = new Random();//konstruktor
            int los;
            string[] haslo1 = new string[100];//tworzenie tablicy przevhowywujacej hasla
          





            string[] kategoria = new string[100];//tworzenie tablicy przechowywujacej kategorie
            //wczytywanie hasla i kategorii z pliku
            odczyt(haslo1,kategoria);
      
            while(true)
            {
               
                los = a.Next(0, nrlini / 2);
                blad = 0;

                napis = haslo1[los];
                haslo2 = "";
                for (int i = 0; i < napis.Length; i++)
                {

                    haslo2 += "-";

                }
               // /
                while ((haslo1[los] != haslo2) && (przegrana==false))//pierwszy warunek to warunek wygranej a drugi to warunek przegranej
                {

               
                    Console.WriteLine("=====WISIELEC=====");
                    Console.WriteLine("Pamietaj nie uzywamy polskich znakow");
                    Console.Write(haslo2);
                    Console.WriteLine("         Kategoria:" + kategoria[los]);
                    Console.Write("Wpisz litere(mala): ");
                
                    bool czyLitera = Char.TryParse(Console.ReadLine(), out litera);//zmienna czyLitera sprawdza czy 
                    //zmienna litera jest typu char

                    

                    Console.Clear();
                    trafiona = false;
                      if (!czyLitera)//czyLitera==false
                    {
                        Console.WriteLine("Nie prawidlowe dane wejscia.Sprobuj jeszcze raz.Podaj Litere");
                        trafiona = true;
                    }
                    for (int i = 0; i < napis.Length; i++)
                    {

                        if (napis[i] == litera)//jesli jest litera w hasle
                        {
                            haslo2 = haslo2.Remove(i, 1);//usuwanie myslnika
                            haslo2 = haslo2.Insert(i, litera.ToString());//dodawanie litery


                            trafiona = true;
                        }
                     


                    }
                    if(trafiona==false)//jeseli nie trafiona została litera
                    {
                        blad++;
                    }
                

                    switch(blad)
                    {
                        case 1: rys1();
                            break;
                        case 2:
                            rys2();
                            break;
                        case 3:
                            rys3();
                            break;
                        case 4:
                            rys4();
                            break;
                        case 5:
                            rys5();
                            break;
                        case 6:
                            rys6();
                            break;
                        case 7:
                            rys7();
                            przegrana = true;
                            Console.ReadKey();
                
                            break;
                       
                    }
                }
               
                Console.Clear();
                Console.WriteLine("=======MENU=======");
                Console.WriteLine("[1]ZAGRAJ");
                Console.WriteLine("[2]WYJSCIE");
                Console.Write("Twoj wybor: ");

               try
                    {
                    wybor = Convert.ToInt32(Console.ReadLine());
                    przegrana = false;
                }
                catch
                {
                    
                }
                Console.Clear();
              
                    switch (wybor)
                {
                    
                    default:
                        while (wybor != 1 && wybor != 2)//opuszczamy petle kiedy wybor sie rowna 1 lub 2
                        {
                            Console.Clear();
                            Console.WriteLine("Nie ma takiej opcji w MENU");
                            Console.WriteLine("=======MENU=======");
                            Console.WriteLine("[1]ZAGRAJ");
                            Console.WriteLine("[2]WYJSCIE");
                            Console.Write("Twoj wybor: ");

                            try
                            {
                                wybor = Convert.ToInt32(Console.ReadLine());
                                przegrana = false;
                            }
                            catch
                            {

                            }
                        }
                        break;
                }
               
                if (wybor==2)Environment.Exit(0);//jezeli wybor jest rowny 2
                Console.Clear();
            } 



        }
    }
}
