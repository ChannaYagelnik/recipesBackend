using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class User
    {
        public User()
        {
            Recepies = new HashSet<Recepy>();
        }

        public int Codeusr { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public int PassWord { get; set; }

        public virtual ICollection<Recepy> Recepies { get; set; }
    }
}
