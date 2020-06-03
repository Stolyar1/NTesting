using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificatePeopleOneS
    {
        public int Id { get; set; }
        public string CertNomer { get; set; }
        public int PersonalId { get; set; }
        public DateTime? ДатаВыдачи { get; set; }
        public string АттестационныйЦентр { get; set; }
        public int? Уровень { get; set; }
        public string Фио { get; set; }
        public string Json { get; set; }
        public string Comment { get; set; }
    }
}
