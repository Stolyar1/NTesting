using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Locactions
    {
        public int Id { get; set; }
        public string ЛокацияИмя { get; set; }
        public string WeatherId { get; set; }
        public string WeatherName { get; set; }
        public string Описание { get; set; }
        public string DataBaseName { get; set; }
        public int? Actual { get; set; }
        public string HashId { get; set; }
        public string ИдОдинС { get; set; }
    }
}
