namespace Stadtbücherei_Verwaltungssystem
{
    public class Settings
    {
        public const string XmlFile = "CustomerFile.xml";
        public const string BackupFile = "Backup.xml";
        public const string XmlNotFound = " Fehlgeschlagen - Keine lesbare Datei im angegebenen Pfad gefunden! \n\n Beliebige Taste drücken um eine neue Datei anzulegen...";


        public const string InputField = "Eingabe: ";
        public const string IdFound = "ID Check erfolgreich!  Weiterleitung erfolgt in kürze...";
        public const string IdCheckHeadline = "[ID Check]";
        public const string IdCheckNote = "Bitte geben Sie Ihre ID im Eingabefeld ein um fortzufahren.";
        public const string IdNotFound = "ID konnte nicht gefunden werden.Bitte prüfen Sie die Eingabe und versuchen es erneut.";
        public const string ConsoleTitle = "Stadtbücherei Verwaltungssystem Frankfurt";

        public const string ConfirmDelete = "'Ja' bestätigen | Enter abbrechen: ";
        public const string YesDelete = "Ja";
        public const string CustomerRemoved = "Kunde wurde erfolgreich Entfernt.             ";
        public const string CancelDelete = "Vorgang abgebrochen. Kehre zurück...   ";
        public const string AskIfSureCustomer = "!! Sind Sie sicher dass Sie den Kunden mit der ID:{0} löschen möchten? !!";
        public const string DeleteScreenHeadCustomer = "[Kunden entfernen]";
        public const string DeleteScreenInputCustomer = "Geben Sie die zugehörige ID des Kunden, den Sie entfernen möchten im unteren Eingabefeld ein.";
        public const string DeleteScreenConfirm = "Bestätigen Sie anschließend Ihre Eingabe mit der Eingabetaste.";
        public const string DelteScreenWarning = "WARNUNG: Dieser Vorgang kann nicht rückgängig gemacht werden!";
        public static string ConfirmInput;
        public const string GaveBackMedium = "[{0}] wurde Erfolgreich zurückgegeben. Vielen Dank!";
        public const string LendMedium = "[{0}] wurde Erfolgreich ausgeliehen. Viel Spaß!";

        public const string AskWhichMedium = "Welcher Kategorie möchten Sie etwas hinzufügen?";
        public const string AudioBooks = "1 :  Hörbucher";
        public const string BlurayDiscs = "2 :  BlurayDiscs";
        public const string Books = "3 :  Bücher";
        public const string DvdDiscs = "4 :  DVDs";
        public const string EBooks = "5 :  E-Books";
        public const string MusicDiscs = "6 :  Musik-CDs";
        public const string VideoGames = "7 :  Software Spiele";
        public const string TabletopGames = "8 :  Tabletop Spiele";
        public const string InputField3 = "Eingabe:     ";

        public const string ObjectRemoved = "Medium wurde erfolgreich Entfernt.      ";
        public const string AskIfSureObject = "  !!   Sind Sie sicher dass Sie das Medium   !!";
        public const string AskIfSureObject2 = "  [{0}] ISBN:{1} löschen möchten?  ";
        public const string AskIfSureCustomer1 = "  !!   Sind Sie sicher dass Sie den Kunden   !!";
        public const string AskIfSureCustomer2 = "  [{0}] Buchausweis:{1} löschen möchten?  ";
        public const string DeleteScreenHeadObject = "[Mietobjekt entfernen]";
        public const string DeleteScreenInputCustomerObject = "Geben Sie die zugehörige ID des Kunden, dessen Mietobjekt Sie entfernen möchten im unteren Eingabefeld ein.";
        public const string DeleteScreenInputObject = "Geben Sie die zugehörige ID des Mietobjekts, welches Sie entfernen möchten im unteren Eingabefeld ein.";


        public const string InputFieldSearch1 = "[Suche]  Abbrechen[0]: ";
        public const string InputFieldSearch2 = "[Suche]  Abbrechen[0]:                                      ";
        public const string CustomerNotFound = "Kunde konnte nicht gefunden werden, bitte erneut versuchen. ";
        public const string MediumNotExisting = "Medium nicht vorhanden. Bitte erneut versuchen.";
        public const string MediumNotFound = "Medium konnte nicht gefunden werden, bitte erneut versuchen. ";

        public const string MediumFound = "Medium gefunden! Weiterleitung erfolgt...            ";
        public const string NumberZero = "0";

        public const string InputforDetails = "Details [1]";
        public const string InputforBack1 = "Zurück  [0]";
        public const string InputforBack = "Zurück [0]";
        public const string Inputfield1 = "Eingabe:             ";
        public const string InputWrong1 = "Eingabe Ungültig!";
        public const string CheckInput = "Bitte Eingabe Prüfen! ";
        public const string InputWrong2 = "Inkorrektes Passwort.";
        public const string InputRight1 = "Eingabe Erfolgreich.                                        ";

        public const string WrongInputExpiryDays = "Ungültige Eingabe. Geben Sie (1) für [7 Tage] oder (2) für [14 Tage] ein.";
        public const string ExpiryOnlyOnce = "Sie können ein Medium nur einmal Verlängern!";
        public const string ExpiryOverdue = "Die Rückgabe des Medium ist bereits fällig, bitte umgehend zurückgeben!";

        public const string IsOverdue = "Überfällig";
        public const string NotOverdue = "Latent";
        public const string Available = "Available";

        public const string NotAvailable = "[Nicht verfügbar]";
        public const string IsAvailable = "[Verfügbar]";
        public const string AvailableMedias = "[VERFÜGBARE MEDIEN]";
        public const string AllMedias = "[ALLE MEDIEN]";
        public const string OverdueMedias = "[ÜBERFÄLLIGE MEDIEN]";
        public const string EmptyInputField = "                                                       ";

        public const string AdminPin = "Admin Passwort:                              ";
        public const string AdminName = "Admin";
        public const string WelcomeAdmin = "Eingabe Erfolgreich. Hallo Admin!";


        public const string GetBookcardID1 = "Büchereiausweis Nr:                                                ";
        public const string GetISBN1 = "ISBN Nr. Eingeben:                                         ";

        public const string WrongBookcardID1 = "Ihr Büchereiausweis ist ungültig. Bitte erneut versuchen.";


        public const string MediaTypeAudioBook = "AudioBook";
        public const string MediaTypeTabletopgame = "TableTopGame";
        public const string MediaTypeBluraydisc = "BlurayDisc";
        public const string MediaTypeBook = "Book";
        public const string MediaTypeDvd = "DVD";
        public const string MediaTypeEbook = "Ebook";
        public const string MediaTypeMusicdisc = "MusicCD";
        public const string MediaTypeVideogame = "VideoGame";
        public const string MediaCategoryDiscs = "Discs";
        public const string MediaCategoryGames = "Spiele";
        public const string MediaCategoryBooks = "Bücher";
    }
}
