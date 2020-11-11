using System;
using System.Linq.Expressions;

namespace Notenrechner {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Green;

            // Punkte eingeben max 60 Punkte möglich
            // 60P. = Note 1 -> 59P. = Note 1.1 usw.
            // 20P. <= Note 5
            // Augabe bissl hübsch machen
            // Zusatzaufgabe: ab Note .33 Minus (-) und ab .66 Plus (+) der nächsten Note

            // ***************************************************************************
            // # Bitte geben Sie Ihre Punktezahl ein : ___
            // ***************************************************************************
            // Console.Clear(); (Clear Screen)

            // ****************************
            //  Punkte  |   Note
            // -------------------
            //  60      |   1
            //  50      |   2
            //  40      |   3
            //  30      |   4
            //  20      |   5
            // ****************************
            // Mit deiner Punktzahl von __ Bekommst du die Note __
            //
            // Console.ReadKey(); (AnyKey)

            // Punkte eingeben -> Formel für "Punkte in Note" -> Note Modulo 1 = moduloNote -> mit Case "moduloNote > oder < dann (+) oder (-) UND WENN >=.66 DANN noteGekuerzt +1 + (+) WENN >=.33 DANN noteGekuerzt + (-)


            // #####################################################################################
            // CODE START
            // #####################################################################################

            // Solange BOOL auf TRUE steht wird das Programm wiederholt
            bool wiederholung = true;

            while (wiederholung == true) {

                // Deklaration der Variablen
                double punkte = -1;
                double note;
                double moduloNote;
                int noteGekuerzt;
                string ausgabeNote;
                int noteTemp;
                string noteGeschrieben;

                // Eingabe der Punkte und erste Ausgabe von Text
                // WHILE Punkte >60 ODER Punkte auf Startwert -1
                while (punkte > 60 || punkte < 0) {
                    Console.Write("********************************************\n" +
                        "**\n" +
                        "** Die maximal zu erreichenden Punkte sind 60\n" +
                        "** Gib deine Punkte ein: ");
                    
                    // Check ob eine Eingabe getätigt wurde
                    // wenn keine Eingabe oder keine Zahlen dann werden "punkte" auf "0" gesetzt und das Programm weiter ausgeführt
                    // wenn eine Eingabe erkannt wurde und es sich um eine Zahl handelt dann wird sie im zweiten Schritt (else if) in Double Converted
                    string userInput = Console.ReadLine();
                    Console.WriteLine("**");
                    //punkte = Convert.ToDouble(Console.ReadLine());
                    if (string.IsNullOrEmpty(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("** Keine Eingabe erkannt!\n** 0 Punkte - Try again!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("**");
                        punkte = 0;
                    } else if (double.TryParse(userInput, out double result)) {
                        punkte = Convert.ToDouble(userInput);
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("** Gib eine Zahl ein, du Vogel ! ! !\n** 0 Punkte - Try again!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("**");
                        punkte = 0;
                    }

                    // Abfrage ob der Punktebereich zwischen 0 und 60 liegt mit entsprechender Meldung
                    if (punkte > 60) {
                        Console.Write("**\n" +
                            "********************************************\n" +
                            "**\n" +
                            "** {0} ist über der maximal zu erreichenden Punktezahl.\n" +
                            "** Bitte gib deine korrekte Punkte ein.\n" +
                            "**\n" +
                            "** Beliebige Taste zum Fortfahren...\n" +
                            "**\n" +
                            "********************************************", punkte);
                        Console.ReadKey();
                        Console.Clear();
                    } else if (punkte < 0) {
                        Console.Write("**\n" +
                            "********************************************\n" +
                            "**\n" +
                            "** {0} ist unter der minimal zu erreichenden Punktezahl.\n" +
                            "** Bitte gib deine korrekte Punkte ein.\n" +
                            "**\n" +
                            "** Beliebige Taste zum Fortfahren...\n" +
                            "**\n" +
                            "********************************************", punkte);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                // #####################################################################################
                // AFTER INPUT CHECK
                // #####################################################################################

                // Berechnung der benötigten Werte und Initialisierung der Variablen
                note = (60 - punkte) / 10 + 1;
                moduloNote = note % 1;
                noteGekuerzt = (int)note;

                // Fallunterscheidung ob ohne oder mit (+) / (-)
                // IF >60 dann TEXT && nochmal eingeben // IF <=13 dann 6 = ungenügend und fertig // while für die Punkteeingabe bzgl Falscheingaben...
                if (punkte <= 13) {
                    ausgabeNote = "6";
                    noteTemp = 6;
                } else {
                    if (moduloNote >= 0.66) {
                        ausgabeNote = noteGekuerzt + 1 + "+";
                        noteTemp = noteGekuerzt + 1;

                    } else if (moduloNote >= 0.33) {
                        ausgabeNote = noteGekuerzt + "-";
                        noteTemp = noteGekuerzt;
                    } else {
                        ausgabeNote = Convert.ToString(noteGekuerzt);
                        noteTemp = noteGekuerzt;
                    }
                }


                // Note ausgeschrieben 
                switch (noteTemp) {
                    case 1:
                        noteGeschrieben = "(sehr gut)";
                        break;
                    case 2:
                        noteGeschrieben = "(gut)";
                        break;
                    case 3:
                        noteGeschrieben = "(befriedigend)";
                        break;
                    case 4:
                        noteGeschrieben = "(ausreichend)";
                        break;
                    case 5:
                        noteGeschrieben = "(mangelhaft)";
                        break;
                    case 6:
                        noteGeschrieben = "(ungenügend)";
                        break;
                    default:
                        noteGeschrieben = "fail";
                        break;
                }

                // Ausgabe
                Console.Write("**\n" +
                    "********************************************\n" +
                    "**\n" +
                    "** Du hast {0} Punkte erreicht\n" +
                    "** damit erhälst du die\n" +
                    "**\n" +
                    "** Note: {1} {2}\n" +
                    "**\n" +
                    "********************************************\n"
                    , punkte, ausgabeNote, noteGeschrieben);


                // Abfrage ob noch eine Note errechnet werden soll
                // im Falle von "nein" wird der bool-Wert auf false gestellt
                Console.WriteLine("" +
                    "** Um noch eine Note zu berechnen gib \"y\" ein oder drücke Enter.\n" +
                    "** Um das Programm zu beenden gib \"n\" ein");
                String whileChar = Console.ReadLine();
                switch (whileChar) {
                    case "y":
                        wiederholung = true;
                        Console.Clear();
                        break;
                    case "n":
                        wiederholung = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
