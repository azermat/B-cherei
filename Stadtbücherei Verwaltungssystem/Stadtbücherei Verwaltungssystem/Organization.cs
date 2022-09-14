using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryBook.BookTypes;
using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryGame.GameTypes;
using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryofCD.CDTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{
    public class Organization
    {
        [XmlAttribute("Name", DataType = "string")]
        public string Name = "Bücherei";

        [XmlElement("ID", DataType = "string")]
        public string ID = "123";

        Organization organization;

        public List<Customer> Customers { get; set; }

        public List<Media> MediaList { get; set; }

        public Organization()
        { }


        /// <summary>
        /// <para>Liest XML Datei, fügt Attribute:Elemente in CustomerList</para>
        /// <para>Generiert Backup</para>
        /// <para>Falls Liste leer, wird ein Kunde angelegt</para>
        /// </summary>
        public void ReadList()
        {
            if (File.Exists(Settings.XmlFile))
            {
                // Generiert Backup
                if (File.Exists(Settings.BackupFile))
                {
                    File.Delete(Settings.BackupFile);
                    File.Copy(Settings.XmlFile, Settings.BackupFile);
                }
                else
                {
                    File.Copy(Settings.XmlFile, Settings.BackupFile);
                }
                XmlSerializer serializer = new XmlSerializer(typeof(Organization));
                Organization dezerializedList;

                using (FileStream stream = File.OpenRead(Settings.XmlFile))
                {
                    dezerializedList = (Organization)serializer.Deserialize(stream);
                }
                organization = dezerializedList;
            }
            else
            {
                // Keine XML Datei vorhanden, neue Liste wird erstellt
                Write(Settings.XmlNotFound);

                ReadKey();

                Customers = new List<Customer>();
                if (Customers.Count == 0)
                {

                    AddNewCustomer();
                }
            }
        }


        public void TextWriter()
        {
            XMLWriter writer = new XMLWriter();
            writer.WriteXml(organization);
        }


        /// <summary>
        /// Fügt neuen Kunden hinzu
        /// </summary>
        public void AddNewCustomer()
        {
            Customer newcustomer = new Customer();
            organization.Customers.Add(newcustomer.InsertCustomerValue());
        }


        /// <summary>
        /// Bietet die Möglichkeit neues Medium anzulegen und dessen Typ auszuwählen
        /// </summary>
        public void AddMediaType()
        {
            Clear();
            Media newObject = null;
            View.NewObjectScreen();
            Service.WriteAt(Settings.AskWhichMedium, 61, 11);
            Service.WriteAt(Settings.AudioBooks, 59, 14);
            Service.WriteAt(Settings.BlurayDiscs, 89, 14);
            Service.WriteAt(Settings.Books, 59, 16);
            Service.WriteAt(Settings.DvdDiscs, 89, 16);
            Service.WriteAt(Settings.EBooks, 59, 18);
            Service.WriteAt(Settings.MusicDiscs, 89, 18);
            Service.WriteAt(Settings.VideoGames, 59, 20);
            Service.WriteAt(Settings.TabletopGames, 89, 20);
            Service.WriteAt(Settings.InputField3, 10, 24);
            SetCursorPosition(19, 24);
            CursorVisible = true;
            string mediatype = ReadLine();

            switch (mediatype)
            {
                case "1":
                    newObject = new AudioBook();
                    break;

                case "2":
                    newObject = new BlurayDisc();
                    break;

                case "3":
                    newObject = new Book();
                    break;

                case "4":
                    newObject = new DVD();
                    break;

                case "5":
                    newObject = new EBook();
                    break;

                case "6":
                    newObject = new MusicCD();
                    break;

                case "7":
                    newObject = new VideoGame();
                    break;

                case "8":
                    newObject = new TabletopGame();
                    break;

                case "0":

                    return;

                default:
                    Service.WriteAt(Settings.CheckInput, 72, 7);
                    Thread.Sleep(2000);
                    AddMediaType();
                    break;

            }
            organization.MediaList.Add(newObject.InsertMediaValue(newObject));
        }


        /// <summary>
        /// Fügt neues Medium hinzu
        /// </summary>
        public void AddNewMedia()
        {
            View.NewObjectScreen();
            AddMediaType();
        }


        /// <summary>
        /// Bietet die Möglichkeit Medium anhand dessen Eigenschaften zu suchen
        /// </summary>
        /// <param name="userinput"></param>
        /// <returns></returns>
        public Media SearchMedia(string userinput)
        {
            organization.ReadList();
            View.SearchScreenMedia();

            while (true)
            {
                CursorVisible = true;

                Media findObject = organization.MediaList.FirstOrDefault(mediaObject => mediaObject.ISBNNumber == userinput || mediaObject.Name == userinput || mediaObject.MediaType == userinput || mediaObject.MediaCategory == userinput || mediaObject.LocationPlace == userinput || mediaObject.Author == userinput || mediaObject.Director == userinput || mediaObject.Publisher == userinput);

                if (userinput == Settings.NumberZero)
                {
                    return null;
                }
                else if (findObject == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.MediumNotFound, 4, 27);
                    Thread.Sleep(2000);
                    Clear();
                    View.EmptyScreen();
                }
                else if (findObject != null)
                {
                    CursorVisible = false;
                    Clear();
                    View.SearchScreenMedia();
                    return findObject;
                }
            }
        }


        /// <summary>
        /// Bietet die Möglichkeit nach Kunden, anhand dessen Namen/Kundennummer zu suchen
        /// </summary>
        /// <returns>Gibt gefundenen Kunden zurück</returns>
        public Customer SearchCustomer()
        {
            while (true)
            {
                CursorVisible = true;
                Service.WriteAt(Settings.InputFieldSearch2, 10, 24);
                SetCursorPosition(33, 24);
                string userinput = ReadLine();

                Customer findCustomer = organization.Customers.FirstOrDefault(customer => customer.CustomerNumber == userinput || customer.Name == userinput);

                if (userinput == Settings.NumberZero)
                {
                    return null;
                }
                else if (findCustomer == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.CustomerNotFound, 10, 24);
                    Thread.Sleep(2000);
                }
                else if (findCustomer != null)
                {
                    CursorVisible = false;
                    Clear();
                    return findCustomer;
                }
            }
        }

        /// <summary>
        /// Bietet die Möglichkeit Kunden über deren Kundennummer zu entfernen
        /// </summary>
        public void DeleteCustomer()
        {
            while (true)
            {
                View.DeleteScreenCustomer();
                Customer customer = CheckCustomerID();
                ForegroundColor = ConsoleColor.Red;
                Service.WriteAt(Settings.AskIfSureCustomer1, 59, 14);
                Service.WriteAt(string.Format(Settings.AskIfSureCustomer2, customer.Name, customer.BookCardID), 59, 15);

                ForegroundColor = ConsoleColor.Cyan;
                CursorVisible = true;
                Service.WriteAt(Settings.ConfirmDelete, 10, 24);
                Settings.ConfirmInput = ReadLine();

                if (Settings.ConfirmInput == Settings.YesDelete)
                {
                    organization.Customers.Remove(customer);
                    Service.WriteAt(Settings.CustomerRemoved, 10, 24);

                    CursorVisible = false;
                    Thread.Sleep(3000);
                    Clear();
                }
                else
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.CancelDelete, 10, 24);
                    Thread.Sleep(3000);
                    Clear();
                }
                return;
            }
        }


        /// <summary>
        /// Bietet Möglichkeit Medium zu entfernen
        /// </summary>
        public void DeleteMediaObject()
        {
            while (true)
            {
                View.DeleteScreenMedia();
                Media mediaObject = CheckMediaID();
                if (mediaObject != null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    Service.WriteAt(Settings.AskIfSureObject, 59, 14);
                    Service.WriteAt(string.Format(Settings.AskIfSureObject2, mediaObject.Name, mediaObject.ISBNNumber), 59, 15);

                    ForegroundColor = ConsoleColor.Cyan;
                    CursorVisible = true;
                    Service.WriteAt(Settings.ConfirmDelete, 10, 24);
                    Settings.ConfirmInput = ReadLine();


                    if (Settings.ConfirmInput == Settings.YesDelete)
                    {

                        organization.MediaList.Remove(mediaObject);

                        Service.WriteAt(Settings.ObjectRemoved, 10, 24);

                        CursorVisible = false;
                        Thread.Sleep(3000);
                        Clear();
                    }
                    else
                    {
                        CursorVisible = false;
                        Service.WriteAt(Settings.CancelDelete, 10, 24);
                        Thread.Sleep(3000); Clear();
                    }
                }
                return;
            }
        }



        /// <summary>
        /// Entfernt Medium und fügt dieses einem neuen Eigentümer hinzu
        /// </summary>
        /// <returns>Übergibt Medium</returns>
        public Media GetLendMedium(Customer customer)
        {
            View.MainMenuOption1();
            CursorVisible = true;
            while (true)
            {
                Service.WriteAt(Settings.GetISBN1, 10, 24);
                SetCursorPosition(29, 24);
                string userinput = ReadLine();

                Media findObject = organization.MediaList.FirstOrDefault(mediaObject => mediaObject.ISBNNumber == userinput);

                if (findObject == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.MediumNotExisting, 10, 24);
                    Thread.Sleep(2000);
                }
                else if (findObject.CustomerReference == "777")
                {
                    if (findObject != null)
                    {
                        CursorVisible = false;
                        Service.WriteAt(Settings.MediumFound, 10, 24);
                        Thread.Sleep(2000);
                        organization.ReadList();
                        findObject.CustomerReference = customer.CustomerNumber;
                        customer.LendReference = findObject.Name;
                        findObject.ExpandCounter = 0;
                        findObject.LendExpiryDate = DateTime.Now;
                        customer.MediaListLend.Add(findObject);
                        Service.WriteAt(Settings.EmptyInputField, 10, 24);
                        return findObject;
                    }
                }
                else
                {
                    CursorVisible = false;
                    Service.WriteAt("Medium bereits ausgeliehen!    ", 10, 24);
                    Thread.Sleep(2800);
                    GetLendMedium(customer);
                    return null;
                }
            }
        }



        public Media GiveBackMedium(Customer customer)
        {
            View.MainMenuOption1();
            CursorVisible = true;
            while (true)
            {
                Service.WriteAt(Settings.GetISBN1, 10, 24);
                SetCursorPosition(29, 24);
                string userinput = ReadLine();

                Media findObject = organization.MediaList.FirstOrDefault(mediaObject => mediaObject.ISBNNumber == userinput);
                Media removeobject = customer.MediaListLend.FirstOrDefault(mediaObject => mediaObject.ISBNNumber == userinput);

                if (findObject == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.MediumNotExisting, 10, 24);
                    Thread.Sleep(2000);
                }
                else if (findObject.CustomerReference == customer.CustomerNumber)
                {
                    if (findObject != null)
                    {
                        CursorVisible = false;
                        Service.WriteAt(Settings.MediumFound, 10, 24);
                        Thread.Sleep(2000);
                        organization.ReadList();
                        findObject.ExpandCounter = 0;
                        findObject.CustomerReference = Settings.Available;
                        customer.LendReference = findObject.Name;
                        findObject.LendExpiryDate = DateTime.Now;
                        customer.MediaListLend.Remove(removeobject);
                        Service.WriteAt(Settings.EmptyInputField, 10, 24);
                        return findObject;
                    }
                }
                else
                {
                    CursorVisible = false;
                    Service.WriteAt("Medium aktuell nicht in Ihrem Besitz.   ", 10, 24);
                    Thread.Sleep(2800);
                    GetLendMedium(customer);
                    return null;
                }
            }
        }


        /// <summary>
        /// Prüft Kundennummer
        /// </summary>
        /// <returns>Gibt gefundenen Kunden zurück</returns>
        public Customer CheckCustomerID()
        {
            while (true)
            {
                CursorVisible = true;
                Service.WriteAt(Settings.GetBookcardID1, 10, 24);
                SetCursorPosition(30, 24);
                string userinput = ReadLine();
                Customer findCustomer = organization.Customers.FirstOrDefault(customer => customer.BookCardID == userinput);

                if (userinput == Settings.NumberZero)
                {
                    return null;
                }
                else if (findCustomer == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.WrongBookcardID1, 10, 24);
                    Thread.Sleep(2000);
                }
                else if (findCustomer != null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.InputRight1, 10, 24);
                    Thread.Sleep(2000);
                    return findCustomer;
                }
            }
        }




        /// <summary>
        /// Sucht nach ISBN Nr. und gibt zugehöriges Medium zurück
        /// </summary>
        /// <returns></returns>
        public Media CheckMediaID()
        {
            while (true)
            {
                CursorVisible = true;
                Service.WriteAt(Settings.GetISBN1, 10, 24);
                SetCursorPosition(29, 24);
                string userinput = ReadLine();
                Media findObject = MediaList.FirstOrDefault(mediaObject => mediaObject.ISBNNumber == userinput);

                if (userinput == Settings.NumberZero)
                {
                    return null;
                }
                else if (findObject == null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.MediumNotExisting, 10, 24);
                    Thread.Sleep(2000);
                }
                else if (findObject != null)
                {
                    CursorVisible = false;
                    Service.WriteAt(Settings.MediumFound, 10, 24);
                    Thread.Sleep(2000);
                    Service.WriteAt(Settings.EmptyInputField, 10, 24);
                    return findObject;
                }
            }
        }


        /// <summary>
        /// Bietet die Möglichkeit Medien auszuleihen, wird vom Admin an Kunden gegeben
        /// </summary>
        public void LendMedium()
        {
            Customer customer = CheckCustomerID();
            if (customer != null)
            {
                GetLendMedium(customer);

                Service.WriteAt(string.Format(Settings.LendMedium, customer.LendReference), 10, 24);
                Thread.Sleep(2800);

                customer.Reference.Add("Ausgeliehen am: " + DateTime.Now + "   [Medium]: " + customer.LendReference + "   Kundenreferenz: " + customer.CustomerNumber);
            }

        }

        /// <summary>
        /// Bietet die Möglichkeit Medien zurückzugeben, wird vom Kunden an Admin gegeben
        /// </summary>
        public void GiveBackMedium()
        {
            Customer customer = CheckCustomerID();
            if (customer != null)
            {
                GiveBackMedium(customer);

                Service.WriteAt(string.Format(Settings.GaveBackMedium, customer.LendReference), 10, 24);
                Thread.Sleep(2800);

                customer.Reference.Add("Rückgabe am: " + DateTime.Now + "   [Medium]: " + customer.LendReference + "   Kundenreferenz: " + customer.CustomerNumber);
            }
        }


        /// <summary>
        /// Überprüft ob MedienObjekt überfällig ist 
        /// </summary>
        public void ExpandLendMedium()
        {
            Media media = CheckMediaID();

            media.ExpandLend();
        }

        public void ExpiryChecker()
        {
            foreach (Media media in organization.MediaList)
            {
                media.ExpiryDate();
            }
        }

        public void PrintAllMedia()
        {
            int position = 0;
            Clear();
            View.ListScreen();
            foreach (Media media in organization.MediaList)
            {
                View.ListScreen();
                media.PrintMedia(position++);
            }
            SetCursorPosition(0, 0);
            ReadKey();
        }


        /// <summary>
        /// Gibt gefundenen Kunden von SearchCustomer() in Konsole aus
        /// </summary>
        public void PrintSearchedCustomer()
        {
            Customer customer = SearchCustomer();
            if (customer != null)
            {
                Clear();
                View.MainMenuEmptyScreen();
                View.SearchScreenCustomer();
                customer.PrintCustomerDetails();
                SetCursorPosition(19, 24);
                ReadKey();
                Clear();
            }
        }

        /// <summary>
        /// Gibt Kunden aufgelistet in der Konsole aus
        /// </summary>
        public void PrintCustomers()
        {
            Clear();
            View.ListScreen();
            int position = 0;
            foreach (Customer customer in organization.Customers)
            {
                View.ListScreen();
                customer.PrintCustomer(position++);
            }
            CursorVisible = true;
            Service.WriteAt(Settings.InputforDetails, 4, 2);
            Service.WriteAt(Settings.InputforBack1, 4, 3);
            Service.WriteAt(Settings.Inputfield1, 4, 0);
            SetCursorPosition(13, 0);
            string userinput = ReadLine();
            CursorVisible = false;
            switch (userinput)
            {
                case "1":
                    PrintSearchedCustomer();
                    break;

                case "0":

                    return;

                default:
                    Service.WriteAt(Settings.InputWrong1, 80, 0);
                    Thread.Sleep(2500);
                    PrintCustomers();
                    break;
            }
            SetCursorPosition(0, 0);
        }

        /// <summary>
        /// Gibt gefundenen Kunden von SearchMedia() in Konsole aus
        /// </summary>
        public void PrintSearchedObject()
        {
            Service.WriteAt(Settings.InputFieldSearch1, 10, 24);
            string userinput = ReadLine();
            View.MainMenuOption4();

            PrintSearchedMedia(userinput);

            SetCursorPosition(19, 24);
        }


        public void PrintSearchedMedia(string userinput)
        {
            foreach (Media media in organization.MediaList)
            {
                if (media.CheckMediaInput(userinput) == true)
                {
                    View.SearchScreenMedia();

                    media.PrintDetailsMedia();
                    SetCursorPosition(19, 24);
                    ReadKey();
                }
            }
        }

        public void PrintOverdues()
        {
            int position = 0;
            Clear();
            foreach (Media media in organization.MediaList)
            {
                if (media.OverdueLend == Settings.IsOverdue && media.CustomerReference != Settings.Available)
                {
                    View.ListScreen();
                    media.PrintOverdue(position++);
                }
            }
            SetCursorPosition(0, 0);
            ReadKey();
        }

        public void PrintAvailable()
        {
            int position = 0;
            Clear();
            foreach (Media media in organization.MediaList)
            {
                if (media.CustomerReference == Settings.Available)
                {
                    View.ListScreen();
                    media.PrintAvailableMedia(position++);
                }
            }
            ReadKey();
        }
    }
}
