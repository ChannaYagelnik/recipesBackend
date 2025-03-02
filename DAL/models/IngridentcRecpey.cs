using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class IngridentcRecpey
    {
        public int CodeIingridRecpie { get; set; }
        public int Coderecpiey { get; set; }
        public int CodeIngrid { get; set; }
        public int? Amount { get; set; }

        public virtual Ingriduentce CodeIngr { get; set; } = null!;
        public virtual Recepy CoderecpieyNavigation { get; set; } = null!;
    }
}
