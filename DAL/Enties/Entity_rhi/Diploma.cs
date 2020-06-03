using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Diploma
    {
        public int IdДиплом { get; set; }
        public int? IdПерсонал { get; set; }
        public string Образование { get; set; }
        public string Учреждение { get; set; }
        public string Номер { get; set; }
        public DateTime? Выдан { get; set; }
        public string Специальность { get; set; }
        public string Квалификация { get; set; }
        public string Коментарий { get; set; }
    }
}
