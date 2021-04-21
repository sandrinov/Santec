using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class Bomfile
    {
        public Bomfile()
        {
            Bomviewers = new HashSet<Bomviewer>();
            PoorFiles = new HashSet<PoorFile>();
        }

        public int Id { get; set; }
        public string Owner { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public int Status { get; set; }
        public byte[] Blob { get; set; }
        public int Loadtime { get; set; }
        public int? NotarizationTime { get; set; }

        public virtual ICollection<Bomviewer> Bomviewers { get; set; }
        public virtual ICollection<PoorFile> PoorFiles { get; set; }
    }
}
