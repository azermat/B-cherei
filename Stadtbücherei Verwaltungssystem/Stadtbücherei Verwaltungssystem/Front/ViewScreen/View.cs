using System.Threading;
using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{
    class View
    {
        public static void EmptyScreen()
        {
            ForegroundColor = System.ConsoleColor.Green;
            CursorVisible = false;
            WriteLine("┌────────────────────────────────────────────┬────────────────────────────┬───────────────────────────────────────────┐");
            WriteLine("│░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ Bücherei - Verwaltungssystem ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░│");
            WriteLine("│░░┌─────────────────────────────────────────┴────────────────────────────┴────────────────────────────────────────┐░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░└───────────────────────────────────────────────────────────────────────────────────────────────────────────────┘░░│");
            WriteLine("│░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░│");
            WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
            ResetColor();
        }

        public static void MainMenuEmptyScreen()
        {
            ForegroundColor = System.ConsoleColor.Green;
            WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ Bücherei - Verwaltungssystem ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            WriteLine("║░░┌─────────────────────────────────────────┴────────────────────────────┴────────────────────────────────────────┐░░║");
            WriteLine("║░░│                                                                                                               │░░║");
            WriteLine("║░░│                                                                                                               │░░║");
            WriteLine("║░░│   ╔═══════════════════════════════════════════╗    ╔══════════════════════════════════════════════════════╗   │░░║");
            WriteLine("║░░│   ║░░░░░░░░░░░░░░░░           ░░░░░░░░░░░░░░░░║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║┌─────────────────────────────────────────┐║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║├                                         ┤║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║│                                         │║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ║└─────────────────────────────────────────┘║    ║                                                      ║   │░░║");
            WriteLine("║░░│   ╚═══════════════════════════════════════════╝    ╚══════════════════════════════════════════════════════╝   │░░║");
            WriteLine("║░░│   ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗   │░░║");
            WriteLine("║░░│   ║░                                                                                                     ░║   │░░║");
            WriteLine("║░░│   ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝   │░░║");
            WriteLine("║░░└───────────────────────────────────────────────────────────────────────────────────────────────────────────────┘░░║");
            WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            ResetColor();
        }

        public static void ListScreen()
        {
            ForegroundColor = System.ConsoleColor.Green;
            CursorVisible = false;
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            WriteLine("│░░│                                                                                                               │░░│");
            ResetColor();
        }

        public static void MainMenuScreen()
        {
            Clear();
            CursorVisible = true;
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 2   Verwaltung", 9, 12);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            Service.WriteAt(" 0 Speichern", 23, 20);
            Service.WriteAt("Eingabe:     ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void MainMenuOption1()
        {
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt(" 1  [Ausleihe │ Rückgabe │ Verlängerung]", 9, 10);
            Service.WriteAt("AUSLEIHE │ RÜCKGABE │ VERLÄNGERUNG", 67, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("1  Medium Ausleihen", 59, 12);
            Service.WriteAt("2  Medium Zurückgeben", 59, 15);
            Service.WriteAt("3  Verlängern", 59, 18);
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void MainMenuOption2()
        {
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("VERWALTUNG", 79, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("1  Alle Kunden Anzeigen", 59, 11);
            Service.WriteAt("2  Alle Medien Anzeigen", 86, 11);
            Service.WriteAt("3  Überfällige Medien", 59, 14);
            Service.WriteAt("4  Verfügbare Medien", 86, 14);
            Service.WriteAt("5  Neuer Kunde", 59, 17);
            Service.WriteAt("6  Neues Medium", 86, 17);
            Service.WriteAt("7  Kunden Entfernen", 59, 20);
            Service.WriteAt("8  Medien Entfernen", 86, 20);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt(" 2  [Verwaltung]", 9, 12);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void MainMenuOption3()
        {
            SearchScreenCustomer();
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("SUCHE: KUNDEN                                 ", 59, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("1  Suche nach Namen / Kundenummer", 59, 12);
            Service.WriteAt("2  Alle Kunden Anzeigen", 59, 15);
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void MainMenuOption4()
        {
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("SUCHE: MEDIEN", 59, 7);
            Service.WriteAt(" 4  [Suche nach Medien]", 9, 16);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("  [Suche nach]", 76, 10);
            Service.WriteAt("  'Titel'", 62, 12);
            Service.WriteAt("  'Autor'", 92, 12);
            Service.WriteAt("  'Kategorie'", 62, 15);
            Service.WriteAt("  'Publisher'", 92, 15);
            Service.WriteAt("  'Regisseur'", 62, 18);
            Service.WriteAt("  'ISBN-Nr.'", 92, 18);
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void ExtendScreen()
        {
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt(" 1  [Ausleihe │ Rückgabe │ Verlängerung]", 9, 10);
            Service.WriteAt("AUSLEIHE │ RÜCKGABE │ VERLÄNGERUNG", 67, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("1  Um 7 Tage Verlängern", 59, 12);
            Service.WriteAt("2  Um 14 Tage Verlängern", 59, 15);
            Service.WriteAt("                              ", 59, 18);
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:                                                                      ", 10, 24);
            SetCursorPosition(19, 24);
        }

        public static void NewCustomerScreen()
        {
            Clear();
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt(" 2  [Verwaltung]", 9, 12);
            Service.WriteAt("NEUER KUNDE", 78, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            SetCursorPosition(19, 24);
        }

        public static void NewObjectScreen()
        {
            Clear();
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt(" 2  [Verwaltung]", 9, 12);
            Service.WriteAt("NEUES MEDIUM", 78, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            SetCursorPosition(19, 24);
        }

        public static void SearchScreenCustomer()
        {
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 2   Verwaltung", 9, 12);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt("KUNDEN SUCHE", 78, 7);
            Service.WriteAt(" 3  [Suche nach Kunden]", 9, 14);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            CursorVisible = true;
        }

        public static void SearchScreenMedia()
        {
            Clear();
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 2   Verwaltung", 9, 12);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt("MEDIEN SUCHE", 78, 7);
            Service.WriteAt(" 4  [Suche nach Medien]", 9, 16);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            Service.WriteAt("Eingabe:     ", 10, 24);
            CursorVisible = true;
        }

        public static void DeleteScreenMedia()
        {
            Clear();
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt(" 2  [Verwaltung]", 9, 12);
            Service.WriteAt("MEDIUM ENTFERNEN", 76, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            SetCursorPosition(19, 24);
        }

        public static void DeleteScreenCustomer()
        {
            Clear();
            MainMenuEmptyScreen();
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt(" 1   Ausleihe │ Rückgabe │ Verlängerung", 9, 10);
            Service.WriteAt(" 3   Suche nach Kunden", 9, 14);
            Service.WriteAt(" 4   Suche nach Medien", 9, 16);
            Service.WriteAt(" 5   Beenden", 9, 18);
            ForegroundColor = System.ConsoleColor.Yellow;
            Service.WriteAt("HAUPTMENÜ", 25, 6);
            Service.WriteAt(" 2  [Verwaltung]", 9, 12);
            Service.WriteAt("KUNDEN ENTFERNEN", 76, 7);
            ForegroundColor = System.ConsoleColor.Green;
            Service.WriteAt("----------------------------------------------------", 58, 9);
            ForegroundColor = System.ConsoleColor.Cyan;
            Service.WriteAt("Zurück [0]", 99, 24);
            SetCursorPosition(19, 24);
        }
    }
}
