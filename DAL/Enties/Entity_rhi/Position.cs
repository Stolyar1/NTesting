using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Position
    {
        public int Id { get; set; }
        public string Должность { get; set; }
        public string IdОрганизация { get; set; }
    }
}
