﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDF_6_Aufgabe_1 {
    class Functions {

        // Farbnummer -> Farbname (alte Version mit Ref Variablen)
        /*public static void FigureColor(string colorNum, ref string colorText) {
            
            switch (colorNum) {
                case "1":
                    colorText = "black";
                    break;
                case "2":
                    colorText = "darkgray";
                    break;
                case "3":
                    colorText = "gray";
                    break;
                case "4":
                    colorText = "darkblue";
                    break;
                case "5":
                    colorText = "blue";
                    break;
                case "6":
                    colorText = "darkgreen";
                    break;
                case "7":
                    colorText = "green";
                    break;
                case "8":
                    colorText = "darkcyan";
                    break;
                case "9":
                    colorText = "cyan";
                    break;
                case "10":
                    colorText = "darkred";
                    break;
                case "11":
                    colorText = "red";
                    break;
                case "12":
                    colorText = "darkmagenta";
                    break;
                case "13":
                    colorText = "magenta";
                    break;
                case "14":
                    colorText = "darkyellow";
                    break;
                case "15":
                    colorText = "yellow";
                    break;
                case "16":
                    colorText = "white";
                    break;

                default:
                    colorText = "white";
                    break;
            }
        }*/

        // Farbnummer -> Farbname
        public static string FigureColor(string colorNum) {
            string colorText;

            switch (colorNum) {
                case "1":
                    colorText = "black";
                    return colorText;
                case "2":
                    colorText = "darkgray";
                    return colorText;
                case "3":
                    colorText = "gray";
                    return colorText;
                case "4":
                    colorText = "darkblue";
                    return colorText;
                case "5":
                    colorText = "blue";
                    return colorText;
                case "6":
                    colorText = "darkgreen";
                    return colorText;
                case "7":
                    colorText = "green";
                    return colorText;
                case "8":
                    colorText = "darkcyan";
                    return colorText;
                case "9":
                    colorText = "cyan";
                    return colorText;
                case "10":
                    colorText = "darkred";
                    return colorText;
                case "11":
                    colorText = "red";
                    return colorText;
                case "12":
                    colorText = "darkmagenta";
                    return colorText;
                case "13":
                    colorText = "magenta";
                    return colorText;
                case "14":
                    colorText = "darkyellow";
                    return colorText;
                case "15":
                    colorText = "yellow";
                    return colorText;
                case "16":
                    colorText = "white";
                    return colorText;

                default:
                    colorText = "white";
                    return colorText;
            }
        }

        // Schriftfarben
        public static void FG_color(string fg_color) {
            switch (fg_color) {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkgreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkcyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkred":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkmagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkyellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "darkgray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    break;
            }
        }

        // Hintergrundfarben
        public static void BG_color(string bg_color) {
            switch (bg_color) {
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "darkblue":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkgreen":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkcyan":
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkred":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkmagenta":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkyellow":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case "darkgray":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;

                default:
                    break;
            }
        }

        // Welcome-Titelbild
        public static void Welcome(string defaultColor) {
            Functions.FG_color("darkred");
            Console.WriteLine("\n\n\n" +
                "       █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████                                     \n" +
                "      ▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀                                     \n" +
                "      ▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███                                       \n" +
                "      ░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄                                     \n" +
                "      ░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒                                    \n" +
                "      ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░                                    \n" +
                "        ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░                                    \n" +
                "        ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░                                       \n" +
                "          ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                                    \n" +
                "                              ░                                                                       \n");
            // Quelle : https://patorjk.com/software/taag/#p=display&h=0&w=%20&f=Bloody&t=welcome

            Functions.FG_color(defaultColor);
        }

        // Menue-Titelbild
        public static void Menue(string defaultColor) {
            Functions.FG_color("darkred");
            Console.WriteLine("\n\n\n" +
                "       ███▄ ▄███▓▓█████  ███▄    █  █    ██ ▓█████                                                    \n" +
                "      ▓██▒▀█▀ ██▒▓█   ▀  ██ ▀█   █  ██  ▓██▒▓█   ▀                                                    \n" +
                "      ▓██    ▓██░▒███   ▓██  ▀█ ██▒▓██  ▒██░▒███                                                      \n" +
                "      ▒██    ▒██ ▒▓█  ▄ ▓██▒  ▐▌██▒▓▓█  ░██░▒▓█  ▄                                                    \n" +
                "      ▒██▒   ░██▒░▒████▒▒██░   ▓██░▒▒█████▓ ░▒████▒                                                   \n" +
                "      ░ ▒░   ░  ░░░ ▒░ ░░ ▒░   ▒ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░                                                   \n" +
                "      ░  ░      ░ ░ ░  ░░ ░░   ░ ▒░░░▒░ ░ ░  ░ ░  ░                                                   \n" +
                "      ░      ░      ░      ░   ░ ░  ░░░ ░ ░    ░                                                      \n" +
                "             ░      ░  ░         ░    ░        ░  ░                                                   \n");
            // Quelle : https://patorjk.com/software/taag/#p=display&h=0&w=%20&f=Bloody&t=menue

            Functions.FG_color(defaultColor);
        }

        // Bilder malen-Titelbild
        public static void Title(string defaultColor) {
            Functions.FG_color("darkred");
            Console.WriteLine("\n\n\n" +
                "       ▄▄▄▄    ██▓ ██▓    ▓█████▄ ▓█████  ██▀███      ███▄ ▄███▓ ▄▄▄       ██▓    ▓█████  ███▄    █   \n" +
                "      ▓█████▄ ▓██▒▓██▒    ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒   ▓██▒▀█▀ ██▒▒████▄    ▓██▒    ▓█   ▀  ██ ▀█   █   \n" +
                "      ▒██▒ ▄██▒██▒▒██░    ░██   █▌▒███   ▓██ ░▄█ ▒   ▓██    ▓██░▒██  ▀█▄  ▒██░    ▒███   ▓██  ▀█ ██▒  \n" +
                "      ▒██░█▀  ░██░▒██░    ░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄     ▒██    ▒██ ░██▄▄▄▄██ ▒██░    ▒▓█  ▄ ▓██▒  ▐▌██▒  \n" +
                "      ░▓█  ▀█▓░██░░██████▒░▒████▓ ░▒████▒░██▓ ▒██▒   ▒██▒   ░██▒ ▓█   ▓██▒░██████▒░▒████▒▒██░   ▓██░  \n" +
                "      ░▒▓███▀▒░▓  ░ ▒░▓  ░ ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░   ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░▓  ░░░ ▒░ ░░ ▒░   ▒ ▒   \n" +
                "      ▒░▒   ░  ▒ ░░ ░ ▒  ░ ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░   ░  ░      ░  ▒   ▒▒ ░░ ░ ▒  ░ ░ ░  ░░ ░░   ░ ▒░  \n" +
                "       ░    ░  ▒ ░  ░ ░    ░ ░  ░    ░     ░░   ░    ░      ░     ░   ▒     ░ ░      ░      ░   ░ ░   \n" +
                "       ░       ░      ░  ░   ░       ░  ░   ░               ░         ░  ░    ░  ░   ░  ░         ░   \n" +
                "            ░              ░                                                                          \n");
            // Quelle : https://patorjk.com/software/taag/#p=display&h=0&w=%20&f=Bloody&t=bilder malen

            Functions.FG_color(defaultColor);
        }

        // Blutiger Mittelfinger
        public static void Fuckfinger(string defaultColor) {
            Functions.FG_color("darkred");
            Console.WriteLine(" " +
                "                     ▓▓                    \n" +
                "                    ███                    \n" +
                "                    ███                    \n" +
                "                    ███                    \n" +
                "                    ███                    \n" +
                "             ░▒  ▓▓ ███  ▓▓                \n" +
                "            ░▒█ ███ ███ ███                \n" +
                "            ▓██ ███ ███ ███  ▓▓            \n" +
                "            ▓██████████████████            \n" +
                "            ▓██████████████████            \n" +
                "            ▓█████████████████             \n" +
                "             ▓███████████████              \n" +
                "             ▓███████████████              \n" +
                "             ▓██████████████               \n" +
                "              ▓█▓█▓██▓█▓▓█▓▓               \n" +
                "              ▒▒▓▒ ▓▓▓ ▓▒▒ ▒               \n" +
                "               ░▒   ▒   ▒ ░                \n" +
                "               ░    ░   ░                  \n" +
                "               ░    ▒   ░                  \n" +
                "               ░    ▓   ▒                  \n" +
                "               ▒    █   ▓                  \n" +
                "               ▓        █                  \n" +
                "               █                           \n");
            // Quelle : http://www.buchstabenbildchen.de/hande/mittelfinger-3/
            // Nachträglich angepasst

            Functions.FG_color(defaultColor);
        }


        // FORMEN
        //
        // Quadrat (mittels zweier Schleifen)
        public static void Quadrat(string defaultColor, string colorText, int size, char zeichen) {

            Functions.FG_color(colorText);
            

            // for-Schleife
            for (int x = 0; x < size; x++) {

                Console.Write("\t");

                for (int y = 0; y < size; y++) {
                    Console.Write(zeichen + " ");
                }
                Console.Write("\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Dreieck RECHTS 
        public static void Dreieck_rechts(string defaultColor, string colorText, int size, char zeichen) {

            Functions.FG_color(colorText);

            // for-Schleife (Höhe Reihe)
            for (int x = 0; x < size; x++) {

                Console.Write("\t");

                // Anzahl Spalten
                for (int y = 0; y <= x; y++) {
                    Console.Write(zeichen + " ");
                }

                Console.Write("\n");
            }

            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Dreieck LINKS
        public static void Dreieck_links(string defaultColor, string colorText, int size, char zeichen) {
            Functions.FG_color(colorText);
            int x1, x2, x3, x4;

            // for-Schleife die in zwei Richtungen zählt
            // max->min und min->max
            for (x1 = size, x3 = 0; x1 > 0 || x3 <= size; x1--, x3++) { //                  (x3 <= size für die volle Größe)

                Console.Write("\t");

                // for-Schleife von max->min (fügt Leerzeichen ein bis Zähler auf max)
                for (x2 = x1; x2 > 0; x2--) {
                    Console.Write(" " + " ");
                }
                // for-Schleife von min->max (fügt Füllzeichen ein bis Zähler auf max)      (x4<=x3 für die volle Größe)
                for (x4 = 0; x4 <= x3; x4++) {
                    Console.Write(zeichen + " ");
                }
                // neue Zeile
                Console.Write("\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Pyramide
        public static void Pyramide(string defaultColor, string colorText, int size, char zeichen) {
            Functions.FG_color(colorText);
            int x1, x2, x3, x4, x5;

            // Dreieck links und rechts werden in einer Schleife zusammengefasst
            for (x1 = size, x3 = 0; x1 > 0 || x3 < size; x1--, x3++) {

                Console.Write("\t");

                // Leerzeichen bis zum ersten Füllzeichen
                for (x2 = x1; x2 > 0; x2--) {
                    Console.Write(" " + " ");
                }

                // Füllzeichen linkes Dreieck
                for (x4 = 0; x4 < x3; x4++) {
                    Console.Write(zeichen + " ");
                }

                // einzelnes Füllzeichen zwischen den Dreiecken
                Console.Write(zeichen + " ");

                //füllzeichen rechtes Dreieck
                for (x5 = 0; x5 < x3; x5++) {
                    Console.Write(zeichen + " ");
                }
                Console.Write("\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Pyramide gespiegelt
        public static void Pyramide_gespiegelt(string defaultColor, string colorText, int size, char zeichen) {
            Functions.FG_color(colorText);
            int x1, x2, x3, x4, x5;

            // Haupt for-Schleife
            for (x1 = 0, x3 = size; x1 < size +1 || x3 > 0; x1++, x3--) {

                Console.Write("\t");

                // Leerzeichen bis zum ersten Füllzeichen
                for (x2 = x1; x2 > 0; x2--) {
                    Console.Write(" " + " ");
                }

                // linkes Dreieck gespiegelt
                for (x4 = x3; x4 > 0; x4--) {
                    Console.Write(zeichen + " ");
                }

                // einzelnes Füllzeichen zwischen den Dreiecken
                Console.Write(zeichen + " ");

                // rechtes Dreieck gespiegelt
                for (x5 = 0; x5 <x3; x5++) {
                    Console.Write(zeichen + " ");
                }
                Console.Write("\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Slash (mittels zweier Schleifen)
        public static void Slash(string defaultColor, string colorText, int size, char zeichen) {
            Functions.FG_color(colorText);
            int x1, x2;

            // rtretertrete
            for (x1 = size ; x1 > 0; x1--) {

                Console.Write("\t");

                for (x2 = x1; x2 > 0; x2-- ) {
                    Console.Write(" " + " ");
                }
                Console.Write(zeichen + "\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }

        // Backslash (mittels zweier Schleifen)
        public static void Backslash(string defaultColor, string colorText, int size, char zeichen) {
            Functions.FG_color(colorText);
            int x1, x2;

            // rtretertrete
            for (x1 = 0; size > x1; x1++) {

                Console.Write("\t");

                for (x2 = 0; x1 > x2; x2++) {
                    Console.Write(" " + " ");
                }
                Console.Write(zeichen + "\n");
            }
            //Console.Write("\n\n");
            Functions.FG_color(defaultColor);
        }









    }
}
