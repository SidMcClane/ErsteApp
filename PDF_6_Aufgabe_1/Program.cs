using System;

namespace PDF_6_Aufgabe_1 {
    class Program {
        static void Main(string[] args) {
            // Notizen:
            // [1]Black - [2]DarkGray - [3]Gray - [4]DarkBlue - [5]Blue - [6]DarkGreen - [7]Green - [8]DarkCyan - [9]Cyan - [10]DarkRed - [11]Red - [12]DarkMagenta - [13]Magenta - [14]DarkYellow - [15]Yellow - [16]White
            
            // Functions.title();
            // Functions.fuckfinger();
            // Console.ResetColor();

            // SetColor - Programm
            string defaultColor = "darkgreen";
            string colorText = "";
            string colorNum;

            // Welcome - Bild
            Functions.welcome(defaultColor);
            Console.WriteLine("\n\n\n" +
                "\tHallo und Herzlich Willkommen bei malen nach Zahlen");
            Console.ReadKey();
            Console.Clear();


            // Menue - Bild
            Functions.menue(defaultColor);
            
            // Menue
            Console.WriteLine("\tWähle eine Farbe für deine Figur aus\n" +
                "\t[1]Black\t\t[2]DarkGray\t\t[3]Gray\t\t\t[4]DarkBlue\n" +
                "\t[5]Blue\t\t\t[6]DarkGreen\t\t[7]Green\t\t[8]DarkCyan\n" +
                "\t[9]Cyan\t\t\t[10]DarkRed\t\t[11]Red\t\t\t[12]DarkMagenta\n" +
                "\t[13]Magenta\t\t[14]DarkYellow\t\t[15]Yellow\t\t[16]White\n");

            // Nummereingabe in ausgeschriebenen Farbnamen umwandeln 
            colorNum = Console.ReadLine();
            Functions.figureColor(colorNum, ref colorText);

            // Füllzeichen (fuellzeichen)

            // Größe (size)


            Functions.quadrat(defaultColor, colorText); //fuellzeichen und size noch einfügen

            Functions.dreieck_rechts(defaultColor, colorText);











            Console.WriteLine("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
            










        }
    }
}
