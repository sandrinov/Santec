using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class PoorViewer
    {
        public int Id { get; set; }
        public string ViewerName { get; set; }
        public int Poor { get; set; }

        public virtual PoorFile PoorNavigation { get; set; }
    }
}
