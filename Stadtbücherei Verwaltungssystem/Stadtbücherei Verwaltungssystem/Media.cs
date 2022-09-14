using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryBook.BookTypes;
using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryGame.GameTypes;
using Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryofCD.CDTypes;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;
using System.Linq;

namespace Stadtbücherei_Verwaltungssystem
{
    [XmlInclude(typeof(AudioBook))]
    [XmlInclude(typeof(BlurayDisc))]
    [XmlInclude(typeof(Book))]
    [XmlInclude(typeof(DVD))]
    [XmlInclude(typeof(EBook))]
    [XmlInclude(typeof(MusicCD))]
    [XmlInclude(typeof(TabletopGame))]
    [XmlInclude(typeof(VideoGame))]
    public abstract class Media
    {
        [XmlAttribute("MediaType", DataType = "string")]
        public abstract string MediaType { get; }

        [XmlElement("Name", DataType = "string")]
        public string Name { get; set; }

        [XmlElement("MediaCategory", DataType = "string")]
        public abstract string MediaCategory { get; }

        [XmlElement("LocationPlace", DataType = "string")]
        public string LocationPlace { get; set; }

        [XmlElement("ISBNNumber", DataType = "string")]
        public string ISBNNumber { get; set; }

        [XmlElement("Author", DataType = "string")]
        public string Author { get; set; }

        [XmlElement("Director", DataType = "string")]
        public string Director { get; set; }

        [XmlElement("Publisher", DataType = "string")]
        public string Publisher { get; set; }

        public string CustomerReference { get; set; }

        public DateTime PrintDate { get; set; }

        public DateTime LendExpiryDate { get; set; }

        public int ExpandCounter { get; set; }
        public string OverdueLend { get; set; }

        private readonly List<string> mediaCollection = new List<string>();



        public abstract void PrintDetailsMedia();


        /// <summary>
        /// Generiert zufällige 11 stellige Nummer
        /// </summary>
        /// <returns>Gibt generierte Nummer zurück</returns>
        private string GenerateNumber()
        {
            Random random = new Random();
            string x = "";
            int i;
            for (i = 1; i < 12; i++)
            {
                x += random.Next(1, 9).ToString();
            }
            return x;
        }

        

        /// <summary>
        /// Bietet die Möglichkeit neues Medium per Nutzereingabe Eigenschaften zu geben
        /// </summary>
        /// <param name="newobject"></param>
        /// <returns>Gibt neues Medium zurück</returns>
        public Media InsertMediaValue(Media newobject)
        {
            Clear();
            CursorVisible = true;
            View.NewObjectScreen();
            Service.WriteAt("Titel: ", 59, 11);
            newobject.Name = ReadLine();
            Service.WriteAt("Stellplatz: ", 59, 13);
            newobject.LocationPlace = ReadLine();

            switch (MediaCategory)
            {
                case "Bücher":
                    Service.WriteAt("Autor: ", 59, 15);
                    newobject.Author = ReadLine();
                    break;

                case "Discs":
                    Service.WriteAt("Regisseur: ", 59, 15);
                    newobject.Director = ReadLine();
                    break;
            }
            Service.WriteAt("Publisher: ", 59, 17);
            newobject.Publisher = ReadLine();

            CursorVisible = false;

            newobject.ISBNNumber = GenerateNumber();
            Service.WriteAt($"ISBN Nummer: {ISBNNumber}", 59, 19);
            Thread.Sleep(2000);

            CustomerReference = Settings.Available;

            newobject.PrintDate = DateTime.Now;

            CursorVisible = false;

            Clear();

            return newobject;
        }

        /// <summary>
        /// Gibt Medien in Konsole aus
        /// </summary>
        /// <param name="position"></param>
        /// <param name="customer"></param>
        public void PrintMedia(int position)
        {
            ForegroundColor = ConsoleColor.Green;
            Service.WriteAt(Settings.AllMedias, 53, 1);
            ResetColor();
            Service.WriteAt($"Name: {Name}", 6, 5 + (position * 5));
            Service.WriteAt($"ISBN: {ISBNNumber}", 6, 6 + (position * 5));
            Service.WriteAt($"Kategorie: {MediaCategory}", 6, 7 + (position * 5));
            if (CustomerReference == Settings.Available)
            {
                ForegroundColor = ConsoleColor.Green;
                Service.WriteAt(Settings.IsAvailable, 6, 4 + (position * 5));
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                Service.WriteAt(Settings.NotAvailable, 6, 4 + (position * 5));
                ResetColor();
            }
            SetCursorPosition(0, 30 + (position * 5));
        }

        /// <summary>
        /// Gibt verfügbare Medien in Konsole aus
        /// </summary>
        /// <param name="position"></param>
        /// <param name="customer"></param>
        public void PrintAvailableMedia(int position)
        {              
                ForegroundColor = ConsoleColor.Green;
                Service.WriteAt(Settings.AvailableMedias, 49, 1);
                ResetColor();
                Service.WriteAt($"Titel: {Name}", 6, 5 + (position * 5));
                Service.WriteAt($"ISBN: {ISBNNumber}", 6, 6 + (position * 5));
                Service.WriteAt($"Kategorie: {MediaCategory}", 6, 7 + (position * 5));
                SetCursorPosition(0, 25 + (position * 5));
        }

        /// <summary>
        /// Überprüft ob Medium überfällig oder noch Latent ist
        /// </summary>
        public void ExpiryDate()
        {
            if (DateTime.Now < LendExpiryDate)
            {
                this.OverdueLend = Settings.IsOverdue;
            }
            else if (DateTime.Now >= LendExpiryDate)
            {
                this.OverdueLend = Settings.NotOverdue;
            }
        }

        /// <summary>
        /// Bietet Möglichkeit Medium Rückgabefrist zu verlängern
        /// </summary>
        public void ExpandLend()
        {
            View.ExtendScreen();
            CursorVisible = true;
            string userinput = ReadLine();
            CursorVisible = false;

            if (OverdueLend == Settings.IsOverdue)
            {
                Service.WriteAt(Settings.ExpiryOverdue, 10, 24);
                Thread.Sleep(2000);
            }
            else if (ExpandCounter >= 1)
            {
                Service.WriteAt(Settings.ExpiryOnlyOnce, 10, 24);
                Thread.Sleep(2000);
            }
            else if (ExpandCounter == 0 && OverdueLend == Settings.NotOverdue)
            {
                switch (userinput)
                {
                    case "1":
                        LendExpiryDate = LendExpiryDate.AddDays(7);
                        ExpandCounter++;
                        Service.WriteAt($"Rückgabefrist wurde um 7 Tage verlängert. Rückgabe fällig am:[{LendExpiryDate:dd/MM/yyyy}]", 10, 24);
                        Thread.Sleep(3500);
                        break;


                    case "2":
                        LendExpiryDate = LendExpiryDate.AddDays(14);
                        ExpandCounter++;
                        Service.WriteAt($"Rückgabefrist wurde um 14 Tage verlängert. Rückgabe fällig am:[{LendExpiryDate:dd/MM/yyyy}]", 10, 24);
                        Thread.Sleep(3500);
                        break;

                    case "0":
                        break;


                    default:
                        Service.WriteAt(Settings.WrongInputExpiryDays, 10, 24);
                        Thread.Sleep(3400);
                        ExpandLend();
                        break;
                }
            }
        }

        /// <summary>
        /// Gibt überfällige Medien in Konsole aus
        /// </summary>
        /// <param name="position"></param>
        /// <param name="customer"></param>
        public void PrintOverdue(int position)
        {
                ForegroundColor = ConsoleColor.Green;
                Service.WriteAt(Settings.OverdueMedias, 49, 1);
                ResetColor();
                Service.WriteAt($"Titel: {Name}", 6, 5 + (position * 5));
                Service.WriteAt($"ISBN: {ISBNNumber}", 6, 6 + (position * 5));
                Service.WriteAt($"Kategorie: {MediaCategory}", 6, 7 + (position * 5));
                ForegroundColor = ConsoleColor.Red;
                Service.WriteAt($"[Verliehen an: {CustomerReference}]", 6, 8 + (position * 5));
                ResetColor();
                SetCursorPosition(0, 25 + (position * 5));
        }

        
  
        private void AddRangeMediaCollection()
        {
            mediaCollection.AddRange(new List<string> { Name, Author, LocationPlace, ISBNNumber, Publisher, Director, MediaCategory, MediaType });
        }

        public bool CheckMediaInput(string userinput)
        {
            AddRangeMediaCollection();
            
            if (mediaCollection.Any(s => !string.IsNullOrEmpty(s) && s.Contains(userinput)))
            { 
                return true; 
            }    
            else
            { 
                return false; 
            }            
        }
    }
}
