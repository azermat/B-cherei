using static System.Console;

namespace Stadtbücherei_Verwaltungssystem
{
    class Service
    {
        public static void WriteAt(string s, int x, int y)
        {
            SetCursorPosition(x, y);
            Write(s);
        }

        //Programmstart
        public static void Bootup()
        {
            Title = Settings.ConsoleTitle;
            var switchcases = new Prozessor();
            Organization organization = new Organization();
            
            switchcases.MainMenu(organization);           
        }
    }
}
