using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class Bomviewer
    {
        public int Id { get; set; }
        public string ViewerName { get; set; }
        public int Bom { get; set; }

        public virtual Bomfile BomNavigation { get; set; }
    }
}
