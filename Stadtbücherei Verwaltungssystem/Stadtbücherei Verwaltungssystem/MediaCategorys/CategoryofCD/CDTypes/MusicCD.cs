using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryofCD.CDTypes
{
    public class MusicCD : CategoryCD
    {
        public override string MediaType => Settings.MediaTypeMusicdisc;

        public override string MediaCategory => Settings.MediaCategoryDiscs;


        public override void PrintDetailsMedia()
        {
            Service.WriteAt($"Titel: {Name}", 59, 11);
            Service.WriteAt($"Künstler: {Director}", 59, 13);
            Service.WriteAt($"Publisher: {Publisher}", 59, 15);
            Service.WriteAt($"ISBN: {ISBNNumber}", 59, 17);
            Service.WriteAt($"Kategorie: {MediaCategory}", 59, 19);
        }
    }
}
