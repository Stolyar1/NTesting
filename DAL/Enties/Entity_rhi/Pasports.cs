using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Pasports
    {
        public int IdПаспорт { get; set; }
        public int? IdПерсонал { get; set; }
        public string ТипПаспорта { get; set; }
        public string Серия { get; set; }
        public string КемВыдан { get; set; }
        public string КодПодразделения { get; set; }
        public DateTime? ДатаВыдачи { get; set; }
        public string МестоРождения { get; set; }
        public string Прописка { get; set; }
        public string ФактическийАдрес { get; set; }
    }
}
