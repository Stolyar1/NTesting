using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Clients
    {
        public int Код { get; set; }
        public string CompanyName { get; set; }
        public string ContractName { get; set; }
        public string BlanksName { get; set; }
    }
}
