using System;
using System.Linq.Expressions;

namespace TemperaturRechner {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;

            // Console.WriteLine("Hello World!");



            // Funktionen schreiben für jede Ausgangseinheit (Bspw. Ausgangseinheit: Celsius -> Function -> Fahrenheit -> Function -> Ausgabe alle anderen Werte)
            // Um es besser Erweiterbar zu gestalten wandelt die Function für C aus dem Bsp. die Temperatur nur in Kelvin um und eine weitere Function berechnet daraus alles andere.
            // Bei einer Erweiterung um eine weitere Temperatureinheit muss dessen Funktion es nur in Kelvin umrechnen und in die "Verteilerfunktion" muss die Formel für die neue Einheit hinterlegt werden.
            // Damit muss man nicht alle Funktionen bearbeiten und die neue Einheit hinzufügen

            // ***********************************************************************
            // **                      Temperatur-Umrechner
            // ***********************************************************************
            // ** Bitte gib die Zahl an um welche Ausgangstemperatur es sich handelt.
            // ** [1] Kelvin
            // ** [2] Celsius
            // ** [3] Fahrenheit
            // ** [4] Réaumur
            // ***********************************************************************
            // ** Nummer eingeben: 1
            // ** Temperatur eingeben: 0
            // ***********************************************************************
            // **       Einheit       |   Temperatur
            // **   ------------------------------------
            // **       Kelvin        |   0
            // **       Celsius       |   -273,15
            // **       Fahrenheit    |   -459,67
            // **       Réaumur       |   -218,52
            // ** 
            // ** 
            // ** 
            

            Console.Write(
                "***********************************************************************\n" +
                "**\t\t\tTemperatur-Umrechner\n" +
                "***********************************************************************\n" +
                "** Bitte gib die Zahl an um welche Ausgangstemperatur es sich handelt.\n" +
                "** [1] Kelvin\n" +
                "** [2] Celsius\n" +
                "** [3] Fahrenheit\n" +
                "** [4] Réaumur\n" +
                "***********************************************************************\n");
            string tempEinheit;
            float tempWert;

            Console.Write("** Nummer eingeben: ");
            tempEinheit = Console.ReadLine();
            Console.Write("** Temperatur eingeben: ");
            tempWert = (float) Convert.ToDouble(Console.ReadLine());

            switch (tempEinheit) {
                case "1":
                    Functions.tempKelvin(tempWert);

                    break;
                case "2":
                    Functions.tempCelsius(tempWert);

                    break;
                case "3":
                    Functions.tempFahrenheit(tempWert);

                    break;
                case "4":
                    Functions.tempReaumur(tempWert);

                    break;
                default:
                    break;

            }
            Console.ReadKey();





            



        }
    }
}
