using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Distributions
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public int? ИдПерсонал { get; set; }
        public int? Отчёты { get; set; }
        public int? Удостоверения { get; set; }
        public int? ДниРождения { get; set; }
    }
}
