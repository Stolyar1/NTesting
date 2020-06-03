using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificatePeoplePb
    {
        public int Id { get; set; }
        public int PersonalId { get; set; }
        public string CertNomer { get; set; }
        public DateTime ДатаВыдачи { get; set; }
        public DateTime ДатаОкончания { get; set; }
        public string АттестационныйЦентр { get; set; }
        public string ОбъектыКонтроля { get; set; }
        public string Фио { get; set; }
        public string Json { get; set; }
        public string Comment { get; set; }
        public string Logger { get; set; }
    }
}
