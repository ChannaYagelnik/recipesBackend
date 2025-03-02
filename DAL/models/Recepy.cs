using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Recepy
    {
        public Recepy()
        {
            IngridentcRecpeys = new HashSet<IngridentcRecpey>();
        }

        public int Code { get; set; }
        public string? Name { get; set; }
        public string? Discrib { get; set; }
        public string? Img { get; set; }
        public string? Levels { get; set; }
        public int? Time { get; set; }
        public string? Meals { get; set; }
        public string? Instruction { get; set; }
        public int? Codeuser { get; set; }

        public virtual User? CodeuserNavigation { get; set; }
        public virtual ICollection<IngridentcRecpey> IngridentcRecpeys { get; set; }
    }
}
