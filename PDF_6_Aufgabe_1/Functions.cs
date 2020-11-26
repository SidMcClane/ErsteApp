using System;
using System.Collections.Generic;
using System.Text;

namespace PDF_6_Aufgabe_1 {
    class Functions {

        // Farbnummer -> Farbname
        public static void figureColor(string colorNum, ref string colorText) {
            
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
                    break;
            }
        }

        // Schriftfarben
        public static void fg_color(string fg_color) {
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
        public static void bg_color(string bg_color) {
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
        public static void welcome(string defaultColor) {
            Functions.fg_color("darkred");
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

            Functions.fg_color(defaultColor);
        }

        // Menue-Titelbild
        public static void menue(string defaultColor) {
            Functions.fg_color("darkred");
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

            Functions.fg_color(defaultColor);
        }

        // Bilder malen-Titelbild
        public static void title(string defaultColor) {
            Functions.fg_color("darkred");
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

            Functions.fg_color(defaultColor);
        }

        // Blutiger Mittelfinger
        public static void fuckfinger(string defaultColor) {
            Functions.fg_color("darkred");
            Console.WriteLine("\n\n\n" +
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

            Functions.fg_color(defaultColor);
        }

        public static void quadrat(string defaultColor, string colorText) {

            Functions.fg_color(colorText);
            int size = 10;

            // for-Schleife
            for (int x = 0; x < size; x++) {

                for (int y = 0; y < size; y++) {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Functions.fg_color(defaultColor);
        }

        public static void dreieck_rechts(string defaultColor, string colorText) {

            Functions.fg_color(colorText);
            int size = 10;

            // for-Schleife (Höhe Reihe)
            for (int x = 0; x < size; x++) {
                // Anzahl Spalten
                for (int y = 0; y <= x; y++) {
                    Console.Write("* ");
                }

                Console.Write("\n");
            }

            Console.Write("\n");

            Functions.fg_color(defaultColor);
        }









    }
}
