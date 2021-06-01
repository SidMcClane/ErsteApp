using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bedingte_Formatierung {
    class Program {
        static void Main(string[] args) {


            int a = 5;
            int b = 8;
            if (a==b) {
                Console.WriteLine("true");
            }




            Console.WriteLine("Zum fortfahren \"y\" oder \"n\" eingeben");
            String whileChar = Console.ReadLine();
            switch (whileChar) {
                case "y":
                    break;    
                case "n":
                    break;
                default:
                    break;
            }




            /*while (true) {

            }*/





            // Erste Aufgabe
            int zahl_A = 3;
            int zahl_B = 5;
            Console.WriteLine("Erste Zahl lautet " + zahl_A + " / die zweite Zahl lautet " + zahl_B);

            if (zahl_A < zahl_B) {
                Console.WriteLine("Die erste Zahl ist kleiner");

            } else if (zahl_A > zahl_B) {
                Console.WriteLine("Fuck, die erste Zahl ist größer als die Zweite... ! ! ! ALAAARM ! ! !");

            } else {
                Console.WriteLine("Die Zahlen sind ja gleich - Das ist ja der Hammer!!!");

            }
            // Aufgabe II [a] - Einlesen von Werten ( Console.ReadLine(); )
            // Eingabe mul, add, sub und div sollen die zwei Zahlen multiplizieren, addieren usw...
            Console.WriteLine("add, sub, mul, div");
            String eingelesenerWert = Console.ReadLine();

            if (eingelesenerWert == "mul") {
                Console.WriteLine("Zahl eins mit Zahl zwei multipliziert ergibt: " + (zahl_A * zahl_B));

            } else if (eingelesenerWert == "add") {
                Console.WriteLine("Zahl eins mit Zahl zwei addiert ergibt: " + (zahl_A + zahl_B));

            } else if (eingelesenerWert == "sub") {
                Console.WriteLine("Zahl eins mit Zahl zwei subtrahiert ergibt: " + (zahl_A - zahl_B));

            } else if (eingelesenerWert == "div") {
                Console.WriteLine("Zahl eins mit Zahl zwei dividiert ergibt: " + (zahl_A / zahl_B));

            }
            // Aufgabe II [b] - Auswahl der größten Zahl aus drei
            // Convertierung von String in Int
            Console.WriteLine("5 Zahlen eingeben und die größte der ersten drei wird angezeigt - die vierte und fünfte brauchen wir später");
            String zahl_eins = Console.ReadLine();
            String zahl_zwei = Console.ReadLine();
            String zahl_drei = Console.ReadLine();
            String zahl_vier = Console.ReadLine();
            String zahl_fuenf = Console.ReadLine();

            int zahl_1 = Convert.ToInt16(zahl_eins);
            int zahl_2 = Int16.Parse(zahl_zwei);
            int zahl_3 = Int32.Parse(zahl_drei);
            float zahl_4 = (float)Double.Parse(zahl_vier);
            float zahl_5 = (float)Double.Parse(zahl_fuenf);



            if (zahl_1 > zahl_2 && zahl_1 > zahl_3) {
                Console.WriteLine("Die erste Zahl ist die größte mit: " + zahl_1);

            } else if (zahl_2 > zahl_1 && zahl_2 > zahl_3) {
                Console.WriteLine("Die zweite Zahl ist die größte mit: " + zahl_2);

            } else if (zahl_3 > zahl_1 && zahl_3 > zahl_2) {
                Console.WriteLine("Die dritte Zahl ist die größte mit: " + zahl_3);

            }
            
            // Switch Cases
            // Eingabe mul, add, sub und div sollen die zwei Zahlen multiplizieren, addieren usw...
            // Aufgabe III - nutze nur swich KEIN if
            Console.WriteLine("Switch Case - add, sub, mul, div");
            Console.WriteLine("Zahl 4 ist = " + zahl_4 + " / und Zahl 5 ist = " + zahl_5);
            String switchText = Console.ReadLine();
            float ergebnis = 0;

            switch (switchText) {
                case "add":
                    ergebnis = zahl_4 + zahl_5;
                    Console.WriteLine(ergebnis);
                    break;
                case "sub":
                    ergebnis = zahl_4 - zahl_5;
                    Console.WriteLine(ergebnis);
                    break;
                case "mul":
                    ergebnis = zahl_4 * zahl_5;
                    Console.WriteLine(ergebnis);
                    break;
                case "div":
                    ergebnis = zahl_4 / zahl_5;
                    Console.WriteLine(ergebnis);
                    break;
                default:
                    break;
            }
            // PDF3_2 Formatierte Ausgabe WriteLine
            int i = 42; int j = 1337;
            Console.WriteLine("i hat den Wert " + i);
            Console.WriteLine("Testaufgabe mit NewLine und Tabulator:\n\t" + i + "\n\t" + j);
            Console.WriteLine("Feste Breite:\n {0,20}\n {1,10}" + "\nTabulatoren:\n\t {2}\n\t {3}", i, j, i, j);

            Console.ReadKey();
        }
    }
}
