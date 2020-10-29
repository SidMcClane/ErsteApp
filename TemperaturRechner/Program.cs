using System;

namespace TemperaturRechner {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

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
            // **       Réumur        |   -218,52
            // ** 
            // ** 
            // ** 





        }
    }
}
