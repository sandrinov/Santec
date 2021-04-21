using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class PoorFile
    {
        public PoorFile()
        {
            PoorViewers = new HashSet<PoorViewer>();
        }

        public int Id { get; set; }
        public string Owner { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public int Status { get; set; }
        public byte[] Blob { get; set; }
        public int Bom { get; set; }
        public int LoadTime { get; set; }
        public int? NotarizationTime { get; set; }

        public virtual Bomfile BomNavigation { get; set; }
        public virtual ICollection<PoorViewer> PoorViewers { get; set; }
    }
}
