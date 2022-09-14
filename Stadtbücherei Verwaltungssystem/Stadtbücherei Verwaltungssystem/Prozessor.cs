using System;
using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{
    class Prozessor
    {
        /// <summary>
        /// Hauptmenü Cases, bietet verschiedene Funktionen an die ausgeführt werden können
        /// </summary>
        /// <param name="organization"></param>
        public void MainMenu(Organization organization)
        {
            organization.ReadList();
            organization.ExpiryChecker();

            while (true)
            {
                View.MainMenuScreen();

                string input = ReadLine();

                switch (input)
                {
                    case "1":
                        View.MainMenuOption1();
                        SubMenuLend(organization);
                        break;

                    case "2":
                        View.MainMenuOption2();
                        SubMenuManagement(organization);
                        break;

                    case "3":
                        View.MainMenuOption3();
                        SubMenuSearchCustomer(organization);
                        break;

                    case "4":
                        View.MainMenuOption4();
                        organization.PrintSearchedObject();             //Mediensuche
                        break;

                    case "5":
                        organization.TextWriter();                      //Programm beenden und Datensatz in XML speichern    
                        Environment.Exit(1);
                        break;

                    case "0":
                        organization.TextWriter();                      //Datensatz in XML speichern
                        break;
                }
            }
        }


        private void SubMenuLend(Organization organization)
        {
            string option1 = ReadLine();

            switch (option1)
            {
                case "1":
                    organization.LendMedium();          //Ausleihe
                    organization.TextWriter();
                    break;

                case "2":
                    organization.GiveBackMedium();      //Rückgabe
                    organization.TextWriter();
                    break;

                case "3":
                    organization.ExpandLendMedium();    //Verlängerung
                    organization.TextWriter();
                    break;

                case "0":
                    MainMenu(organization);             //Hauptmenü
                    break;
            }
        }

        private void SubMenuManagement(Organization organization)
        {
            string option2 = ReadLine();

            switch (option2)
            {
                case "1":
                    organization.PrintCustomers();      //Alle Kunden anzeigen
                    break;

                case "2":
                    organization.PrintAllMedia();   //Alle Medien anzeigen
                    break;

                case "3":
                    organization.PrintOverdues();   //Überfällige Medien anzeigen
                    break;

                case "4":
                    organization.PrintAvailable();  //Verfügbare Medien anzeigen
                    break;

                case "5":
                    organization.AddNewCustomer();      //Neuen Kunden anlegen
                    break;

                case "6":
                    organization.AddNewMedia();         //Neues Medium anlegen
                    break;

                case "7":
                    organization.DeleteCustomer();      //Kunden entfernen
                    break;

                case "8":
                    organization.DeleteMediaObject();   //Medium entfernen
                    break;

                case "0":
                    MainMenu(organization);             //Hauptmenü
                    break;
            }
        }

        private void SubMenuSearchCustomer(Organization organization)
        {
            string option3 = ReadLine();

            switch (option3)
            {
                case "1":
                    organization.PrintSearchedCustomer();   //Kundensuche
                    break;

                case "2":
                    organization.PrintCustomers();          //Alle Kunden anzeigen
                    break;

                case "0":
                    MainMenu(organization);                 //Hauptmenü
                    break;
            }
        }
    }
}
