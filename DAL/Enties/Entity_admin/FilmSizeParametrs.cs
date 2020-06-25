using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class FilmSizeParametrs
    {
        public int Id { get; set; }
        public double? ФактДиаметр { get; set; }
        public double? ДлинаОкружности { get; set; }
        public double? ExpCount { get; set; }
        public double? SizeControl { get; set; }
        public double? FilmSize { get; set; }
        public double? LenAppends { get; set; }
    }
}
