using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Steels
    {
        public int Id { get; set; }
        public string SteelName { get; set; }
        public string Cr { get; set; }
        public string Ni { get; set; }
        public string Mo { get; set; }
        public string Mn { get; set; }
        public string Cu { get; set; }
        public string Si { get; set; }
        public string Ti { get; set; }
        public string C { get; set; }
        public string V { get; set; }
        public string Hbot { get; set; }
        public string Hbdo { get; set; }
        public string ElementName { get; set; }
        public string ElementRu { get; set; }
        public string ObjectLocation { get; set; }
    }
}
