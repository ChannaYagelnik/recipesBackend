using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Ingriduentce
    {
        public Ingriduentce()
        {
            IngridentcRecpeys = new HashSet<IngridentcRecpey>();
        }

        public int CodeIngrid { get; set; }
        public string? NameIngrid { get; set; }

        public virtual ICollection<IngridentcRecpey> IngridentcRecpeys { get; set; }
    }
}
