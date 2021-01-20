using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturRechner {
    class Functions {
        private const float NULL_KELVIN = 273.15f;
        // FUNKTIONSSAMMLUNG
        public static void mainUmrechner(float convInKelvin) {
            float convInCelsius = convInKelvin - NULL_KELVIN;
            float convInFahrenheit = convInKelvin * 1.8f - 459.67f;
            float convInReaumur = (convInKelvin - 273.15f) * 0.8f;
            /*Console.WriteLine("Kelvin " + convInKelvin);
            Console.WriteLine("Celsius " + convInCelsius);
            Console.WriteLine("Fahrenheit " + convInFahrenheit);
            Console.WriteLine("Reaumur " + convInReaumur);*/

            Console.Write("" +
                "***********************************************************************\n" +
                "** \tEinheit\t\t|\tTemperatur\n" +
                "** -------------------------------------------\n" +
                "** \tKelvin\t\t|\t{0:f2}\n" +
                "** \tCelsius\t\t|\t{1:f2}\n" +
                "** \tFahrenheit\t|\t{2:f2}\n" +
                "** \tRéaumur\t\t|\t{3:f2}\n" +
                "** \n" +
                "** \n" +
                "** \n",
                convInKelvin, convInCelsius, convInFahrenheit, convInReaumur);
        }

        public static void tempKelvin(float tempWert) {

            mainUmrechner(tempWert);
        }
        public static void tempCelsius(float tempWert) {
            float convInKelvin = tempWert + NULL_KELVIN;
            mainUmrechner(convInKelvin);
        }
        public static void tempFahrenheit(float tempWert) {
            float convInKelvin = (tempWert + 459.67f) * 5 / 9;
            mainUmrechner(convInKelvin);
        }
        public static void tempReaumur(float tempWert) {
            float convInKelvin = tempWert * 1.25f + 273.15f;
            mainUmrechner(convInKelvin);
        }



    }
}
