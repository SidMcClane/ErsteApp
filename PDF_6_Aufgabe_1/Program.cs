using System;

namespace PDF_6_Aufgabe_1 {
    class Program {
        static void Main(string[] args) {
            // Notizen:
            // [1]Black - [2]DarkGray - [3]Gray - [4]DarkBlue - [5]Blue - [6]DarkGreen - [7]Green - [8]DarkCyan - [9]Cyan - [10]DarkRed - [11]Red - [12]DarkMagenta - [13]Magenta - [14]DarkYellow - [15]Yellow - [16]White

            // Functions.title();
            // Functions.fuckfinger();
            // Console.ResetColor();

            // ###################################################################################################
            // ###################################################################################################
            // ###################################################################################################
            // Start Code
            // ###################################################################################################



            // SetColor - Programm
            string defaultColor = "darkgreen";                                  // Programm-Schriftfarbe
            string colorNum;                                                    // Nummer der (Form)Farbe
            string colorText = "";                                              // Name der (Form)Farbe
            int size;                                                           // Größe der Form
            char zeichen;                                                       // Füllzeichen der Form

            // Welcome - Bild
            Functions.welcome(defaultColor);
            Console.WriteLine("\n\n\n" +
                "\tHallo und Herzlich Willkommen bei malen nach Zahlen");
            Console.ReadKey();
            Console.Clear();


            // Menue - Bild
            Functions.menue(defaultColor);
            
            // Menue
            Console.WriteLine("\tWähle eine Farbe für deine Form aus\n" +
                "\t[1]Black\t\t[2]DarkGray\t\t[3]Gray\t\t\t[4]DarkBlue\n" +
                "\t[5]Blue\t\t\t[6]DarkGreen\t\t[7]Green\t\t[8]DarkCyan\n" +
                "\t[9]Cyan\t\t\t[10]DarkRed\t\t[11]Red\t\t\t[12]DarkMagenta\n" +
                "\t[13]Magenta\t\t[14]DarkYellow\t\t[15]Yellow\t\t[16]White\n");

            // Eingabeaufforderung der Farb-Nummer
            Console.Write("\tBitte entsprechende Nummer eingeben: ");
            colorNum = Console.ReadLine();                                      // Farbnummer (string)
            // Nummereingabe in ausgeschriebenen Farbnamen umwandeln (string)
            Functions.figureColor(colorNum, ref colorText);                     // Farbname (string)

            // Eingabeaufforderung des Füllzeichens
            Console.Write("\n\tFüllzeichen der Form eingeben: ");
            zeichen = Convert.ToChar(Console.ReadLine());                       // Füllzeichen (Char)

            // Eingabeaufforderung Formgröße
            Console.Write("\n\tGröße der Form eingeben: ");
            size = Convert.ToInt32(Console.ReadLine());                         // Größe (size) (int)


            // Menue
            Console.WriteLine("\n\tWähle die gewünschte Form aus\n" +
                "\t[1]Quadrat\t[2]Dreieck links\t[3]Dreieck rechts\t[4]Pyramide\t[5]Pyramide gespeigelt\t\n" +
                "\t# #       \t  #             \t#                \t #         \t# #                     \n" +
                "\t# #       \t# #             \t# #              \t# #        \t #                    \n\n" +
                "\t[6]Slash  \t[7]Backslash                                                              \n" +
                "\t  #       \t#                                                                         \n" +
                "\t#         \t  #");




            Functions.quadrat(defaultColor, colorText, size, zeichen); 

            Functions.dreieck_rechts(defaultColor, colorText, size, zeichen);

            Functions.dreieck_links(defaultColor, colorText, size, zeichen);

            Functions.pyramide(defaultColor, colorText, size, zeichen);

            Functions.pyramide_gespiegelt(defaultColor, colorText, size, zeichen);

            Functions.slash(defaultColor, colorText, size, zeichen);

            Functions.backslash(defaultColor, colorText, size, zeichen);

            Functions.fuckfinger(defaultColor);
        }
    }
}
