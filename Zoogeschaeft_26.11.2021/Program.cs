using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoogeschaeft_26._11._2021 {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            
            // ************* Forms anzeigen ***************
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            
            Console.WriteLine("Welches Tier willst du haben?\n");
            Menue();
            bool weiterEinkaufen = true;


            while (weiterEinkaufen == true) {
                Console.Clear();
                Console.WriteLine("Ein weiteres Tier hinzufügen");
                Menue();


                string auswahl = Console.ReadLine();

                switch (auswahl) {
                    case "1":
                        ImputFisch();
                        Console.ReadKey();
                        break;
                    case "2":
                        ImputVogel();
                        Console.ReadKey();
                        break;
                    case "3":
                        ImputReptilie();
                        Console.ReadKey();
                        break;
                    case "exit":
                        weiterEinkaufen = false;
                        Console.Clear();
                        Console.WriteLine("Auf Wiedersehen");
                        Console.ReadKey();
                        break;
                    case "4":
                        Primer();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Bitte eine Zahl von 1-3 eingeben");
                        Console.ReadKey();
                        break;
                }
            }

            //Console.ReadKey();
        }



        // *** Funktionen ***


        // Menü
        public static void Menue() {
            Console.WriteLine("" +
                "[1]\tFisch\n" +
                "[2]\tVogel\n" +
                "[3]\tReptilie\n" +
                "[exit]\tBeenden");
        }



        // Standardabfragen nach Größe, Gewicht und Preis
        public static float ImputStandardGroesse() { 
            float groesse;
            Console.WriteLine("\nGröße angeben:");
            float.TryParse(Console.ReadLine(), out groesse);
            return groesse;
        }
        public static float ImputStandardGewicht() { 
            float gewicht;
            Console.WriteLine("\nGewicht angeben:");
            float.TryParse(Console.ReadLine(), out gewicht);
            return gewicht;
        }
        public static float ImputStandardPreis() {
            float preis;
            Console.WriteLine("\nPreis angeben:");
            float.TryParse(Console.ReadLine(), out preis);
            return preis;
        }



        // Eingabe und Ausgabe für Fisch
        public static void ImputFisch() {

            Console.WriteLine("Anzahl Rückenflossen:");
            int rueckenflosse = Convert.ToInt32(Console.ReadLine());

            float groesse = ImputStandardGroesse();
            float gewicht = ImputStandardGewicht();
            float preis = ImputStandardPreis();

            Fisch fisch = new Fisch(rueckenflosse, preis, groesse, gewicht);
            
            fisch.Ausgabe(preis, groesse, gewicht, rueckenflosse);
        }


        // Eingabe und Ausgabe für Vogel
        public static void ImputVogel() {
            bool    flugFaehig = false;
            float   flugReichweite = 0;

            Console.WriteLine("\nIst es Flugfähig (Ja)?");
            string flugFaehigEingabe = Console.ReadLine().ToLower();

            if (flugFaehigEingabe == "ja") {
                flugFaehig = true;
                Console.WriteLine("Wie weit ist die Flugreichweite?");
                float.TryParse(Console.ReadLine(), out flugReichweite);
            }

            float groesse = ImputStandardGroesse();
            float gewicht = ImputStandardGewicht();
            float preis = ImputStandardPreis();

            Vogel vogel = new Vogel(flugFaehig, flugReichweite, preis, groesse, gewicht);
            vogel.Ausgabe(preis, groesse, gewicht, flugFaehig, flugReichweite);
        }


        // Eingabe und Ausgabe für Reptilie
        public static void ImputReptilie() {
            bool giftig;
            bool fuehrungszeugnis;
            int alter;

            Console.WriteLine("\nIst die Reptilie giftig/gefährlich?");
            string giftigEingabe = Console.ReadLine().ToLower();


            if (giftigEingabe == "ja") {
                giftig = true;

            } else {

            }

            float groesse = ImputStandardGroesse();
            float gewicht = ImputStandardGewicht();
            float preis = ImputStandardPreis();

            //            Reptilie reptilie = new Reptilie(giftig, abAchtzehn, keinEintrag, preis, groesse, gewicht);
            //            reptilie.Ausgabe(preis, groesse, gewicht, giftig, abAchtzehn, keinEintrag);
        }





        // ***********************
        // *** Experimentieren ***
        // ***********************
        public static void Primer() {
            Console.WriteLine("Zahl eingeben");

            float start = 1;
            float end = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < end; i++, start++) {

                if (start < 2) {
                    ++start;
                } else if (start == 2) {
                    Console.WriteLine("{0}\n", start);
                } else if (start % 2 == 0) {
                    ++start;
                }
                    

                for (int count = 2; count < end; count++) {

                    float ergebnis = start % count;

                    if (ergebnis == 0 && count < start) {
                        break;
                    }
                    Console.WriteLine("{0}\n",start);
                }
            }



        }
    }
}