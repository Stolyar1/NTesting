using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Chuvstvitelnost
    {
        public int Код { get; set; }
        public string Ot { get; set; }
        public string Do { get; set; }
        public string Klass1 { get; set; }
        public string Klass2 { get; set; }
        public string Klass3 { get; set; }
    }
}
