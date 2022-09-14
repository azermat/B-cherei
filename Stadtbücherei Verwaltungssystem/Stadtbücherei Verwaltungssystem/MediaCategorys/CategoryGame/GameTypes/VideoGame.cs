using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryGame.GameTypes
{
    public class VideoGame : CategoryGame
    {
        public override string MediaType => Settings.MediaTypeVideogame;

        public override string MediaCategory => Settings.MediaCategoryGames;


        public override void PrintDetailsMedia()
        {
            Service.WriteAt($"Titel: {Name}", 59, 12);
            Service.WriteAt($"Publisher: {Publisher}", 59, 14);
            Service.WriteAt($"ISBN: {ISBNNumber}", 59, 16);
            Service.WriteAt($"Kategorie: {MediaCategory}", 59, 18);
        }
    }
}
