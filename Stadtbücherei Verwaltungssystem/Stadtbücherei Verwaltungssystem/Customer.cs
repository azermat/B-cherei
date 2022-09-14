using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;
using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{

    [XmlRoot]
    public class Customer
    {
        [XmlAttribute("Name", DataType = "string")]
        public string Name { get; set; }


        [XmlElement("Street", DataType = "string")]
        public string Street { get; set; }


        [XmlElement("HouseNumber", DataType = "int")]
        public int HouseNumber { get; set; }


        [XmlElement("ZipCode", DataType = "int")]
        public int ZipCode { get; set; }


        [XmlElement("CustomerID", DataType = "string")]
        public string CustomerNumber { get; set; }


        [XmlElement("BookCardID", DataType = "string")]
        public string BookCardID { get; set; }


        public DateTime CardExpiryDate { get; set; }

        [XmlIgnore]
        public string LendReference { get; set; }

        public List<Media> MediaListLend;
        public List<string> Reference;


        public Customer()
        { }


        /// <summary>
        /// Bietet die Möglichkeit neuen Kunden per Nutzereingabe deren Eigenschaften zu geben
        /// </summary>
        /// <returns>Gibt neuen Kunden zurück</returns>
        public Customer InsertCustomerValue()
        {
            Customer newCustomer = new Customer();

            View.NewCustomerScreen();

            Service.WriteAt("Name: ", 59, 11);
            newCustomer.Name = ReadLine();

            Service.WriteAt("Straße: ", 59, 13);
            newCustomer.Street = ReadLine();

            Service.WriteAt("Hausnummer: ", 59, 15);
            newCustomer.HouseNumber = Convert.ToInt32(ReadLine());

            Service.WriteAt("Postleitzahl: ", 59, 17);
            newCustomer.ZipCode = Convert.ToInt32(ReadLine());
            Service.WriteAt("       Bitte Warten...            ", 70, 21);
            newCustomer.CustomerNumber = GenerateNumber();
            CursorVisible = false;
            Thread.Sleep(1000);
            Service.WriteAt($"Kundennummer: {newCustomer.CustomerNumber}", 59, 19);
            Thread.Sleep(600);
            Service.WriteAt("      Fast geschafft...            ", 70, 21);
            Thread.Sleep(500);
            newCustomer.BookCardID = GenerateNumber();
            Service.WriteAt($"Buchausweisnummer:{newCustomer.BookCardID}", 80, 11);
            newCustomer.CardExpiryDate = DateTime.Now.AddYears(2);
            Thread.Sleep(1000);
            ForegroundColor = ConsoleColor.Green;
            Service.WriteAt("Kunde Erfolgreich angelegt.", 70, 21);
            Thread.Sleep(2500);

            Clear();

            return (newCustomer);
        }

        /// <summary>
        /// Generiert zufällige 10 Stellige Nummer
        /// </summary>
        /// <returns>Gibt generierte Nummer zurück</returns>
        private string GenerateNumber()
        {
            Random random = new Random();
            string x = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                x += random.Next(1, 9).ToString();
            }
            return x;
        }





        /// <summary>
        /// Gibt Alle Kunden in der Konsole aus
        /// </summary>
        /// <param name="position"></param>
        public void PrintCustomer(int position)
        {
            ForegroundColor = ConsoleColor.Green;
            Service.WriteAt("[ALLE KUNDEN]", 54, 1);
            ResetColor();
            Service.WriteAt($"Name: {Name}", 53, 5 + (position * 4));
            Service.WriteAt($"Kundennummer: {CustomerNumber}", 53, 6 + (position * 4));
            SetCursorPosition(0, 30 + (position * 5));
        }

        /// <summary>
        /// Gibt Kundendetails auf abruf in der Konsole aus
        /// </summary>
        public void PrintCustomerDetails()
        {
            Service.WriteAt($"Name: {Name}", 59, 11);
            Service.WriteAt($"Straße: {Street} {HouseNumber}", 59, 13);
            Service.WriteAt($"Postleitzahl: {ZipCode}", 59, 15);
            Service.WriteAt($"Kundennummer: {CustomerNumber}", 59, 17);
            Service.WriteAt($"Bücherausweis ID: {BookCardID}", 59, 19);
        }


        

        

        

        
    }
}
