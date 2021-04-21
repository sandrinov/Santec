using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class FileViewer
    {
        public int Id { get; set; }
        public string ViewerName { get; set; }
        public int OtherFile { get; set; }

        public virtual OtherFile OtherFileNavigation { get; set; }
    }
}
