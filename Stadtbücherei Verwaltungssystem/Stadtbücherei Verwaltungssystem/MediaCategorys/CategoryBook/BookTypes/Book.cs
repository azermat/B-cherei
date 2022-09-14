using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryBook.BookTypes
{
    public class Book : CategoryBook
    {
        public override string MediaType => Settings.MediaTypeBook;

        public override string MediaCategory => Settings.MediaCategoryBooks;

        public override void PrintDetailsMedia()
        {
            Service.WriteAt($"Titel: {Name}", 59, 11);
            Service.WriteAt($"Autor: {Author}", 59, 13);
            Service.WriteAt($"Publisher: {Publisher}", 59, 15);
            Service.WriteAt($"ISBN: {ISBNNumber}", 59, 17);
            Service.WriteAt($"Kategorie: {MediaCategory}", 59, 19);
        }
    }
}
