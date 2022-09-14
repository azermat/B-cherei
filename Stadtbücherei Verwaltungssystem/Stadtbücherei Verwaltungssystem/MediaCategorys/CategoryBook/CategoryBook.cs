using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadtbücherei_Verwaltungssystem.MediaCategorys.CategoryBook
{
    public abstract class CategoryBook : Media
    {
       
        public override string MediaCategory => this.ToString();

        
    }
}
