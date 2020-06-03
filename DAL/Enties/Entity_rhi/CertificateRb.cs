using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CertificateRb
    {
        public int IdУдостоверение { get; set; }
        public int? IdПерсонал { get; set; }
        public string Организация { get; set; }
        public string Тип { get; set; }
        public string НаименованиеУчебногоЦентра { get; set; }
        public string НомерУдостоверения { get; set; }
        public DateTime? Выдача { get; set; }
        public DateTime? Окончание { get; set; }
        public string НомерПротокола { get; set; }
        public DateTime? ДатаПротокола { get; set; }
        public string Коментарий { get; set; }
    }
}
