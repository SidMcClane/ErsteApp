using System;

namespace _4_1__Kassenbon {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("LalaLand\n");

            // PDF4 Einführung Variablen
            // Aufgabe I - Erstelle einen Kassenbon

            // *********************************************
                        
            float bargeld = 50.00f;

            int anzWurst = 0;
            int anzKaese = 0;
            int anzBrot = 0;
            int anzDvd = 0;

            float preisWurst = 4.19f;
            float preisKaese = 2.29f;
            float preisBrot = 2.10f;
            float preisDvd = 12.99f;

            Console.Write("AnyKey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Erstelle einen Kassenbon\n");
            Console.WriteLine("Ich packe meinen Koffer und gehe Einkaufen...\n" +
                "Ich brauche Wurst, Käse, Brot und nen geilen Film auf DVD!\n" +
                "Für das alles hab ich noch {0:f2} EUR einstecken.", bargeld);

            Console.Write("AnyKey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Die Wurst kostet {0:f2} EUR - wieviel soll ich mitnehmen?", preisWurst);
            Console.Write("Anzahl eingeben: ");
            anzWurst = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Der Käse kostet {0:f2} EUR - wieviel soll ich mitnehmen?", preisKaese);
            Console.Write("Anzahl eingeben: ");
            anzKaese = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Das Brot kostet {0:f2} EUR - wieviel soll ich mitnehmen?", preisBrot);
            Console.Write("Anzahl eingeben: ");
            anzBrot = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Die DVD kostet {0:f2} EUR - wieviel soll ich mitnehmen?", preisDvd);
            Console.Write("Anzahl eingeben: ");
            anzDvd = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            float gesWurst = preisWurst * anzWurst;
            float gesKaese = preisKaese * anzKaese;
            float gesBrot = preisBrot * anzBrot;
            float gesDvd = preisDvd * anzDvd;

            float gesBon = gesWurst + gesKaese + gesBrot + gesDvd;
            float rueckgeld = bargeld - gesBon;

            while (gesBon > bargeld) {
                Console.WriteLine("Der Einkauf würde {0:f2} EUR kosten und ich hab leider nur {1:f2} EUR einstecken.\n" +
                    "Ich muss mein Einkauf anpassen.", gesBon, bargeld);

                Console.Write("AnyKey");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Die Wurst kostet {0:f2} EUR und ich wollte {1} Stück mitnehmen", preisWurst, anzWurst);
                Console.Write("Anzahl ändern auf: ");
                anzWurst = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Der Käse kostet {0:f2} EUR und ich wollte {1} Stück mitnehmen", preisKaese, anzKaese);
                Console.Write("Anzahl eingeben: ");
                anzKaese = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Das Brot kostet {0:f2} EUR und ich wollte {1} Stück mitnehmen", preisBrot, anzBrot);
                Console.Write("Anzahl eingeben: ");
                anzBrot = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Die DVD kostet {0:f2} EUR und ich wollte {1} Stück mitnehmen", preisDvd, anzDvd);
                Console.Write("Anzahl eingeben: ");
                anzDvd = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            
                gesWurst = preisWurst * anzWurst;
                gesKaese = preisKaese * anzKaese;
                gesBrot = preisBrot * anzBrot;
                gesDvd = preisDvd * anzDvd;

                gesBon = gesWurst + gesKaese + gesBrot + gesDvd;
                rueckgeld = bargeld - gesBon;
            }

            Console.WriteLine("\n\n\n" +
                "************************************\n" +
                "* Kassenbon\n*\n" +
                "* -------------------------------- \n" +
                "* Wurst\t{0} x {1,-6:f2} EUR\n* \t\t\t{2,-6:f2} EUR\n" +
                "* Käse\t{3} x {4,-6:f2} EUR\n* \t\t\t{5,-6:f2} EUR\n" +
                "* Brot\t{6} x {7,-6:f2} EUR\n* \t\t\t{8,-6:f2} EUR\n" +
                "* DVD\t{9} x {10,-6:f2} EUR\n* \t\t\t{11,-6:f2} EUR\n" +
                "* -------------------------------- \n" +
                "* Gesamt\t\t{12,-6:f2} EUR\n" +
                "* Gegeben\t\t{13,-6:f2} EUR\n*\n" +
                "* Zurück\t\t{14,-6:f2} EUR\n" +
                "************************************\n\n",
                anzWurst, preisWurst, gesWurst,
                anzKaese, preisKaese, gesKaese,
                anzBrot, preisBrot, gesBrot,
                anzDvd, preisDvd, gesDvd,
                gesBon, bargeld, rueckgeld);


            

        }
    }
}
