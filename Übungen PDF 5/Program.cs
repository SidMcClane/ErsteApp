using System;

namespace Übungen_PDF_6 {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;


            // While Aufgabe a) und b)
            // Gib alle Zahlen von 0 - 100 aus und bau eine Schleife um die Schleife wiederholen zu können
            Console.WriteLine("Weiter mit Taste\n" +
                "while-Schleife und Wiederholung des Programms\n" +
                "mithilfe einer weiteren while-Schleife\n");
            Console.ReadKey();

            bool nochmal = true;
            while (nochmal == true) {
                int i = 0;
                while (i <= 100) {
                    Console.Write(i + " ");
                    i++;
                }
                Console.WriteLine("\nNochmal? Y oder N");
                string abfrage = Console.ReadLine();
                
                if (abfrage == "y" || abfrage == "Y") {
                    nochmal = true;
                } else if (abfrage == "n" || abfrage == "N") {
                    nochmal = false;
                }
            }

            
            // DO-While Aufgabe a)
            // Gib alle ungeraden Zahlen von 1 - 100 aus
            Console.WriteLine("\n\nWeiter mit Taste\n" +
                "do-while-Schleife\n");
            Console.ReadKey();

            int ungerade = 0;
            do {
                if (ungerade % 2 > 0) {
                    Console.Write(ungerade +" ");
                }
                ungerade++;
            } while (ungerade < 100);


            // for-Schleife
            //
            Console.WriteLine("\n\nWeiter mit Taste\n" +
                "for-Schleife\n");
            Console.ReadKey();

            for (int i = 1; i <= 100; i++) {
                Console.Write(i + " ");
            }


            //for-Schleife Quadrat mit einer Schleife
            //
            Console.WriteLine("\n\nWeiter mit Taste\n" +
                "for-Schleife - Quadrat mit einer Schleife\n");
            Console.ReadKey();

            for (int i = 1; i < 6; i++) {
                Console.WriteLine("XXXXXXXXXX");
            }




            Console.WriteLine("\n\nZum Beenden Taste drücken\n");
            Console.ReadKey();
        }
    }
}
