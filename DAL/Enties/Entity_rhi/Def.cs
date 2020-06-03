using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Def
    {
        public int Код { get; set; }
        public string SmallName { get; set; }
        public string LongName { get; set; }
        public string IdentityCard { get; set; }
        public string DataIdentity { get; set; }
    }
}
