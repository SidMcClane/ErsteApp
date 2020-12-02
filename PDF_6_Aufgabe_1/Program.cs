using System;

namespace PDF_6_Aufgabe_1 {
    class Program {

        // Hauptmenü
        static void Main(string[] args) {
            bool mainLoop = true;

            while (mainLoop) {
                Console.Clear();

                // Menue
                Console.Write("\n\n\n\tHauptmenü\n\n" +
                    "\t[1]ShapeDrawer\t\t[2]QuadKubRechner\n\n" +
                    "\t[3]BasisPotenz\t\t[4]Beenden\n\n\t");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.Clear();
                        Program.ShapeDrawer();
                        break;

                    case "2":
                        Console.Clear();
                        Program.QuadKubRechner();
                        break;

                    case "3":
                        Console.Clear();
                        Program.BasisPotenz();
                        break;

                    case "4":
                        mainLoop = false;
                        break;

                    default:
                        mainLoop = false;
                        break;
                }
            }
        }

        // [Aufgabe 1] Formen zeichnen mit Schleifen
        public static void ShapeDrawer() {
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
            string defaultColor = "darkgreen";                                  // Programm-Schriftfarbe (default)
            string colorNum;                                                    // (Form)Farben Nummer
            string colorText = "";                                              // (Form)Farben Name
            int size;                                                           // Form Größe z.B. 5, 10 oder 20
            char zeichen;                                                       // Form Füllzeichen z.B. #, +, *, ...
            string shapeNum;                                                    // Form Nummer
            bool shapeLoop = true;                                              // ProgramLoop till false

            // ###################################################################################################

            Console.Clear();


            // Welcome - Bild
            Functions.Welcome(defaultColor);
            Console.Write("\n\n\n" +
                "\tHallo und Herzlich Willkommen bei malen nach Zahlen");
            Console.ReadKey();
            Console.Clear();


            while (shapeLoop) {

                // Menue - Bild
                Functions.Menue(defaultColor);
            
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
                Functions.FigureColor(colorNum, ref colorText);                     // Farbname (string)

                // Eingabeaufforderung des Füllzeichens
                Console.Write("\n\tFüllzeichen der Form eingeben: ");
                zeichen = Convert.ToChar(Console.ReadLine());                       // Füllzeichen (Char)

                // Eingabeaufforderung Formgröße
                Console.Write("\n\tGröße der Form eingeben: ");
                size = Convert.ToInt32(Console.ReadLine());                         // Größe (size) (int)
                Console.Clear();


                // Menue - Bild
                Functions.Title(defaultColor);

                // Menue
                Console.WriteLine("\n\tWähle die gewünschte Form aus\n" +
                    "\t[1]Quadrat\t[2]Dreieck links\t[3]Dreieck rechts\t[4]Pyramide\t[5]Pyramide gespiegelt\t\n" +
                    "\t# #       \t  #             \t#                \t #         \t# #                     \n" +
                    "\t# #       \t# #             \t# #              \t# #        \t #                    \n\n" +
                    "\t[6]Slash  \t[7]Backslash                                                              \n" +
                    "\t  #       \t#                                                                         \n" +
                    "\t#         \t  #");

                // Eingabeaufforderung der Form-Nummer
                Console.Write("\tBitte entsprechende Nummer eingeben: ");
                shapeNum = Console.ReadLine();
                Console.Clear();
                Functions.Title(defaultColor);
                Console.Write("\n");


                // Aufruf der entsprechender Form
                switch (shapeNum) {
                    case "1":
                        Functions.Quadrat(defaultColor, colorText, size, zeichen);
                        break;

                    case "2":
                        Functions.Dreieck_links(defaultColor, colorText, size, zeichen);
                        break;

                    case "3":
                        Functions.Dreieck_rechts(defaultColor, colorText, size, zeichen);
                        break;

                    case "4":
                        Functions.Pyramide(defaultColor, colorText, size, zeichen);
                        break;

                    case "5":
                        Functions.Pyramide_gespiegelt(defaultColor, colorText, size, zeichen);
                        break;

                    case "6":
                        Functions.Slash(defaultColor, colorText, size, zeichen);
                        break;

                    case "7":
                        Functions.Backslash(defaultColor, colorText, size, zeichen);
                        break;

                    default:
                        Functions.Fuckfinger(defaultColor);
                        break;
                }

                Console.ReadKey();
                Console.Clear();

                // Welcome - Bild (Abfrage ob man eine weitere Form zeichnen möchte...)
                Functions.Welcome(defaultColor);
                Console.Write("\n\n\n" +
                    "\tMöchtest du eine weitere Form zeichnen? (y oder n): ");

                if (Console.ReadLine() == "n") {
                    shapeLoop = false;
                }

                Console.Clear();
            }
        }

        // [Aufgabe 2] Quadrat und Kubik Rechner
        public static void QuadKubRechner() {
            double basisNum;
            double quadNum;
            double kubNum;
            bool quadkubLoop = true;


            while (quadkubLoop) {
                Console.Clear();

                Console.Write("\n\n\n\tGib eine Basis ein: ");
                basisNum = Convert.ToDouble(Console.ReadLine());

                quadNum = basisNum * basisNum;
                kubNum = quadNum * basisNum;

                Console.WriteLine("\n" +
                    "\tQuadrat:\t{0,-6:f2}\n"+
                    "\tKubik:\t\t{1,-6:f2}\n\n", quadNum, kubNum);

                Console.Write("\tWillste noch eine machen? (y/n) ");
                switch (Console.ReadLine()) {
                    case "n":
                        quadkubLoop = false;
                        break;
                    default:
                        break;
                }

            }



        }

        // [Aufgabe 3] Basis Potenz Rechner
        public static void BasisPotenz() {
            double basis;
            double potenz;
            double ergebnis;
            bool basisPotenzLoop = true;

            while (basisPotenzLoop) {
                Console.Clear();

                Console.Write("\n\n\n\tGib eine Basis ein: ");
                basis = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tGib eine Potenz ein: ");
                potenz = Convert.ToDouble(Console.ReadLine());

                ergebnis = basis;

                for (double i = potenz; i > 1; i--) {
                    ergebnis *= basis; 
                }


                Console.WriteLine("\n\tErgebnis: {0,-6:f2}\n\n\n", ergebnis);

                Console.Write("\tWillste noch eine machen? (y/n) ");
                switch (Console.ReadLine()) {
                    case "n":
                        basisPotenzLoop = false;
                        break;
                    default:
                        break;
                }

            }
        }






        // [ = Sandbox = ]
        public static void Prime() {
            bool primeLoop = true;

            while (primeLoop) {

                Console.WriteLine("\n\n\n\tLos gehts - Wieviel durchläufe schaffst du? - ");
                int loops = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < loops; i++) {
                    if (true) {

                    }

                }












                Console.Write("\tWillste weiter machen? (y/n) ");
                switch (Console.ReadLine()) {
                    case "n":
                        primeLoop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
