using System;

namespace PDF_7 {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            bool mainMenueLoop = true;
            while (mainMenueLoop) {

                Title();
                MenueList();

                switch (Console.ReadLine()) {
                    case "1":
                        SinnDesLebens();
                        break;
                    case "2":
                        Rechner();
                        break;

                    case "x":
                        mainMenueLoop = false;
                        break;
                    default:
                        Title();
                        Console.Write("\n\tFalscheingabe");
                        Console.ReadKey();
                        break;
                }





            }
        }








        // #################################################################################
        //
        // ____________________________________Methoden_____________________________________
        //
        // #################################################################################


        //
        // Aufgabe 1 - Fehlersuche und Beschreibung des Fehlers
        // Die Variable int derSinnDesLebens kann in der IF-Anweisung nicht in ein bool-Wert konvertiert werden
        // Sie muss in der IF-Anweisung etwas zum abgleichen haben
        // 
        // Die Methode muss mit "static" anfangen, damit sie eindeutig der Klasse als Methode zugewiesen wird und nicht als Objekt
        static void SinnDesLebens() {

            Title();                                                            // Titelbild

            int derSinnDesLebens = DerSinnDesLebensRechner();
            if (derSinnDesLebens == 42) {
                Console.Write("\n\tDer Sinn des Lebens ist: " + derSinnDesLebens);
                Console.ReadKey();
            }
        }
        static int DerSinnDesLebensRechner() {
            return 6 * 7;
        }


        // 
        // Aufgabe 2
        // 
        static void Rechner() {

            bool rechnerLoop = true;

            while (rechnerLoop) {
                Title();                                                        // Titelbild
                RechnerMenue();                                                 // Auswahl-Menü Rechner

                double zahl01;
                double zahl02;
                double zahl0X;
                ushort zahl03;

                switch (Console.ReadLine()) {
                    case "1":
                        Title();
                        Multiplizieren();                                       // Überladung - Textausgabe - Void Methode
                        Console.Write("\tDie erste Zahl: ");
                        zahl01 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\tMultipliziert mit: ");
                        zahl02 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\n\t" +
                            "Das Ergebnis lautet: " + 
                            Multiplizieren(zahl01, zahl02));                    // Methode mit Rückgabewert
                        Console.ReadKey();
                        break;
                    case "2":
                        Title();
                        Dividieren();                                           // Überladung - Textausgabe - Void Methode
                        Console.Write("\tDie erste Zahl: ");
                        zahl01 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\tDividiert durch: ");
                        zahl02 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\n\t" +
                            "Das Ergebnis lautet: " +
                            Dividieren(zahl01, zahl02));                        // Methode mit Rückgabewert
                        Console.ReadKey();
                        break;
                    case "3":
                        Title();
                        Fakultaet();                                            // Überladung - Textausgabe - Void Methode
                        Console.Write("\tSag Zahl: ");
                        zahl03 = Convert.ToUInt16(Console.ReadLine());
                        
                        Console.Write("\n\t" +
                            "Das Ergebnis lautet: " +
                            Fakultaet(zahl03));                                 // Methode mit Rückgabewert
                        Console.ReadKey();
                        break;
                    case "4":
                        Title();
                        Console.Write("\tDie erste Zahl: ");
                        zahl01 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\tmultipliziert mit: ");
                        zahl02 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\tmultipliziert mit: ");
                        zahl0X = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\n\t" +
                            "Das Ergebnis lautet: " +
                            Multiplizieren(zahl01, zahl02, zahl0X));            // Überladung *drei Zahlen multiplizieren
                        Console.ReadKey();
                        break;

                    case "x":
                        rechnerLoop = false;
                        break;
                    default:
                        Title();
                        Console.Write("\n\tFalscheingabe");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Berechnungen
        static double Multiplizieren(double zahl01, double zahl02) {
            return zahl01 * zahl02;
        }
        static double Dividieren(double zahl01, double zahl02) {
            return zahl01 / zahl02;
        }
        static ulong Fakultaet(ulong fak) {
            ulong fakSum = 1;
            for (ulong i = 1; i <= fak; i++) {    
                fakSum *= i;
            }
            return fakSum;
        }

        // Überladungen
        static void Multiplizieren() {
            Console.WriteLine("\tBeim multiplizieren, wir eine Zahl um eine bestimmte Zahl vervielfacht\n");
        }
        static void Dividieren() {
            Console.WriteLine("\tBei der division wird eine Zahl durch eine andere geteilt\n");
        }
        static void Fakultaet() {
            Console.WriteLine("\tDie Fakultät ist das Produkt aller Zahlen von 1 bis n\n");
        }
        static double Multiplizieren(double zahl01, double zahl02, double zahl03) {
            return zahl01 * zahl02 * zahl03;
        }




        // #################################################################################
        //
        // _____________________________________Menue_______________________________________
        //
        // #################################################################################

        // Titelbild
        static void Title() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n" +
                "\t ██▓███  ▓█████  ▄▄▄▄    ▄▄▄▄    ██▓    ▓█████   ██████ \n" +
                "\t▓██░  ██▒▓█   ▀ ▓█████▄ ▓█████▄ ▓██▒    ▓█   ▀ ▒██    ▒ \n" +
                "\t▓██░ ██▓▒▒███   ▒██▒ ▄██▒██▒ ▄██▒██░    ▒███   ░ ▓██▄   \n" +
                "\t▒██▄█▓▒ ▒▒▓█  ▄ ▒██░█▀  ▒██░█▀  ▒██░    ▒▓█  ▄   ▒   ██▒\n" +
                "\t▒██▒ ░  ░░▒████▒░▓█  ▀█▓░▓█  ▀█▓░██████▒░▒████▒▒██████▒▒\n" +
                "\t▒▓▒░ ░  ░░░ ▒░ ░░▒▓███▀▒░▒▓███▀▒░ ▒░▓  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░\n" +
                "\t░▒ ░      ░ ░  ░▒░▒   ░ ▒░▒   ░ ░ ░ ▒  ░ ░ ░  ░░ ░▒  ░ ░\n" +
                "\t░░          ░    ░    ░  ░    ░   ░ ░      ░   ░  ░  ░  \n" +
                "\t            ░  ░ ░       ░          ░  ░   ░  ░      ░  \n" +
                "\t                      ░       ░                         \n" +
                "\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        // Hauptmenü
        static void MenueList() {
            Console.Write("" +
                "\t[1] Sinn des Lebens(A1)\t\t[2] Rechner(A2)\t\t[x] Quit\n\n\t" +
                "");
        }

        // Auswahl-Menü - Rechner
        static void RechnerMenue() {
            Console.Write("" +
                "\t[1] Multiplizieren\t\t[2] Dividieren\t\t[3] Fakultät\t\t[x] Back\n" +
                "\t[4] Überladung_01 (3 Zahlen multiplizieren)\n\n" +
                "\tweitere Überladungen finden sich im Quelltext (Void Methoden)\n"+
                "\t");
        }

    }
}
