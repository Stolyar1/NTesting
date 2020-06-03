using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Organization
    {
        public int IdОрганизация { get; set; }
        public string ПубличноеНаименование { get; set; }
        public string Организация { get; set; }
    }
}
